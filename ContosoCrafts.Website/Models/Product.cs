﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCrafts.Website.Models
{
    public class Product
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("maker")]
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int[] Ratings { get; set; }

        public Product()
        {
            
        }

        public override string ToString()=> JsonSerializer.Serialize<Product>(this);



    }
}
