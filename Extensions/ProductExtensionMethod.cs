using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TheOfficeFurnitureWarehouse.Core.Model;

namespace TheOfficeFurnitureWarehouse.Extensions
{
    public static class ProductExtensionMethod
    {
        public static IEnumerable<SelectListItem> GetAsSelectListItems(this IEnumerable<Product> products)
        {
            return products.Select(_ => new SelectListItem { Value = _.Name, Text = _.Name }).ToList();
        }
    }
}
