using DigitalVegetables.Models;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System;

namespace DigitalVegetables.Services
{
    public class JasonProductFile
    {
        public JasonProductFile(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }

        public string JsonFilePath
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Vegetables.json");
            }
        }
        public IEnumerable<Product> getProductsData()
        {
            using (var json_file = File.OpenText(JsonFilePath))
            {
                return JsonSerializer.Deserialize<Product[]>(json_file.ReadToEnd());
            }
        }

        internal void setProductRecords(Product obj, JasonProductFile productService)
        {
            throw new NotImplementedException();
        }
    }
}
