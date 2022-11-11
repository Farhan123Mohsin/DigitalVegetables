using System.Text.Json.Serialization;
using System.Text.Json;

namespace DigitalVegetables.Models
{
    public class Product
    {
        [JsonPropertyName("id")]
        public int Product_id { get; set; }

        [JsonPropertyName("name")]
        public string Product_name { get; set; }

        [JsonPropertyName("image")]
        public string Product_image { get; set; }
        public override string ToString()
        {
            return JsonSerializer.Serialize<Product>(this);
        }
    }
}
