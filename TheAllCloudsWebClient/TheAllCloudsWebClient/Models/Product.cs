
namespace TheAllCloudsWebClient.Models
{
    public class Product
    {
        // The unique identifier for the product
        public string productId { get; set; }

        // The name of the product
        public string name { get; set; }

        // A description for the product
        public string description { get; set; }

        // The unit price for the product in Australian Dollars(AUD)
        public double unitPrice { get; set;  }

        // The maximum quantity that is allowed to be ordered(in a single order) for the product
        public int maximumQuantity { get; set; }
    }
}
