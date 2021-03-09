using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TheOfficeFurnitureWarehouse.Business.PriceStrategyCreators;
using TheOfficeFurnitureWarehouse.Business.Services.Customers;
using TheOfficeFurnitureWarehouse.Business.Services.Orders;
using TheOfficeFurnitureWarehouse.Business.Services.Prices;
using TheOfficeFurnitureWarehouse.Business.Services.Products;
using TheOfficeFurnitureWarehouse.Data;
using TheOfficeFurnitureWarehouse.Data.Repositories.Customers;
using TheOfficeFurnitureWarehouse.Data.Repositories.Orders;
using TheOfficeFurnitureWarehouse.Data.Repositories.Products;
using TheOfficeFurnitureWarehouse.Data.UnitOfWork;

namespace TheOfficeFurnitureWarehouse
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureDbContext(services);
            ConfigureRepositories(services);
            ConfigureBusinessServices(services);

            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }

        private void ConfigureDbContext(IServiceCollection services)
        {
            services.AddDbContextPool<TheOfficeFurnitureWarehouseDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("TheOfficeFurnitureWarehouseDb"));
            });
        }

        private void ConfigureRepositories(IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICreateOrderUoW, CreateOrderUoW>();
        }

        private void ConfigureBusinessServices(IServiceCollection services)
        {
            services.AddScoped<ICreateCustomerService, CreateCustomerService>();
            services.AddScoped<IReadCustomerService, ReadCustomerService>();
            services.AddScoped<ICreateProductService, CreateProductService>();
            services.AddScoped<IUpdateProductService, UpdateProductService>();
            services.AddScoped<IReadProductService, ReadProductService>();
            services.AddScoped<ICreateOrderService, CreateOrderService>();
            services.AddScoped<IPriceService, PriceService>();
            services.AddScoped<IPriceStrategyCreator, PriceStrategyCreator>();
        }
    }
}
