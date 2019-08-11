using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheAllCloudsWebClient.Services.ViewModels
{
    public class ProductViewModel
    {
        public string ProductId { get; set; }
        public string Name { get; set; }

        // A description for the product
        public string Description { get; set; }

        // The unit price for the product in Australian Dollars(AUD)
        public double UnitPrice { get; set; }
    }
}
