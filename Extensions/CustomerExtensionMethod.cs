using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Extensions
{
    public static class CustomerExtensionMethod
    {
        public static IEnumerable<SelectListItem> GetAsSelectListItems(this IEnumerable<Customer>  customers)
        {
            var selectListItems = customers.Select(_ => new SelectListItem { Value = _.Name, Text = _.Name }).ToList();
            var defaultItem = new SelectListItem { Value = null, Text = "--- select customer ---" };
            selectListItems.Add(defaultItem);
            return selectListItems;
        }
    }
}
