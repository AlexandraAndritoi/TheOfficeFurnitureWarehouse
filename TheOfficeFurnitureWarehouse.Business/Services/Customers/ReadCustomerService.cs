﻿using System.Collections.Generic;
using TheOfficeFurnitureWarehouse.Core.Model;
using TheOfficeFurnitureWarehouse.Data.Repository;

namespace TheOfficeFurnitureWarehouse.Business.Services.Customers
{
    public class ReadCustomerService : IReadCustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public ReadCustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetCustomersOrderedByName()
        {
            return customerRepository.GetCustomersOrderedByName();
        }
    }
}