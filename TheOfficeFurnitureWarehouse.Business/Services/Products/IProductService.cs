﻿using System;
using System.Collections.Generic;
using System.Text;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Business.Services.Products
{
    public interface IProductService
    {
        Product GetProductById(Guid id);
        IEnumerable<Product> GetProductsOrderedByName();
        void Update(Product product);
    }
}
