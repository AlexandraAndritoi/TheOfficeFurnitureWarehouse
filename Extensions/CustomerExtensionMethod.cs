using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TheOfficeFurnitureWarehouse.Core.Models;

namespace TheOfficeFurnitureWarehouse.Extensions
{
    public static class CustomerExtensionMethod
    {
        public static IEnumerable<SelectListItem> GetAsSelectListItems(this IEnumerable<Customer>  customers)
        {
            return customers.Select(_ => new SelectListItem { Value = _.Name, Text = _.Name }).ToList();
        }
    }
}
