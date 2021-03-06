using System;

namespace TheOfficeFurnitureWarehouse.Core.Model
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
