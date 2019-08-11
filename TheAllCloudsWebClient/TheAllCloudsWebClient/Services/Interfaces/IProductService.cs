using System.Collections.Generic;
using TheAllCloudsWebClient.Models;
using TheAllCloudsWebClient.Services.ViewModels;

namespace TheAllCloudsWebClient.Services.Interfaces
{
    public interface IProductService
    {
        List<ProductViewModel> GetProducts();
    }    
}
