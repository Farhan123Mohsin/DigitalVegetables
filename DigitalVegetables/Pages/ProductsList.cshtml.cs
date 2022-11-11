using DigitalVegetables.Models;
using DigitalVegetables.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace DigitalVegetables.Pages
{
    public class ProductsListModel : PageModel
    {

        JasonProductFile ProductService;
        public IEnumerable<Product> Products;

        public ProductsListModel(JasonProductFile productService)
        {
            this.ProductService = productService;
        }
        public void OnGet()
        {
            Products = ProductService.getProductsData();
        }
    }
}
