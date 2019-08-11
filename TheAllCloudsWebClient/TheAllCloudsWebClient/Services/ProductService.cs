using System;
using System.Collections.Generic;
using TheAllCloudsWebClient.Models;
using TheAllCloudsWebClient.Repositories.Interfaces;
using TheAllCloudsWebClient.Services.Interfaces;
using TheAllCloudsWebClient.Services.ViewModels;

namespace TheAllCloudsWebClient.Services
{   
    public class ProductService : IProductService
    {
        IProductRepository _productRepo;
        const double _markupPercentage = 20;

        public ProductService(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }
        public List<ProductViewModel> GetProducts()
        {
           return AddMarkupToProductPrice(_productRepo.GetProducts());
        }

        private List<ProductViewModel> AddMarkupToProductPrice(List<Product> products)
        {
            List<ProductViewModel> productVMList = new List<ProductViewModel>();
            foreach(var product in products)
            {
                productVMList.Add(new ProductViewModel()
                {
                    ProductId = product.productId,
                    Name = product.name,
                    Description = product.description,
                    UnitPrice = product.unitPrice + Math.Round(product.unitPrice * (_markupPercentage / 100),2)
                });
            }
            return productVMList;
        }
    }
}
