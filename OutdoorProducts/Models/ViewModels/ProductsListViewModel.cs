using System;
using System.Collections.Generic;
using OutdoorProducts.Models;
using System.Linq;
using System.Threading.Tasks;


namespace OutdoorProducts.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }

    }
}
