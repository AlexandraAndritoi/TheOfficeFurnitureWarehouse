using System;
using System.ComponentModel.DataAnnotations;

namespace TheOfficeFurnitureWarehouse.Core.Models
{
    public class Customer : IEntity
    {
        public Guid Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; }

        [Required, StringLength(80)]
        public string Address { get; set; }

        public int Discount { get; set; }
    }
}
