using BeställningsApp5.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BeställningsApp5.Models
{
    public class Product 
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("price")]
        public float Price { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("category")]
        public string Category { get; set; }

        [JsonPropertyName("image")]
        public string Image { get; set; }

        [JsonPropertyName("rating")]
        public Rating Rating { get; set; }

    }

    public class Rating
    {
        [JsonPropertyName("rate")]
        public float Rate { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }
    }
    

}
