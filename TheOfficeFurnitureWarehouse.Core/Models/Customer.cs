using System;

namespace TheOfficeFurnitureWarehouse.Core.Models
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
