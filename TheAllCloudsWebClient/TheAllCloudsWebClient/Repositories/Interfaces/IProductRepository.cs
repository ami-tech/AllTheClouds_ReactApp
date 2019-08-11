using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheAllCloudsWebClient.Models;

namespace TheAllCloudsWebClient.Repositories.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts();
    }
}
