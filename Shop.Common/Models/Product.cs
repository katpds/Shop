﻿

namespace Shop.Common.Models
{
    
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Newtonsoft.Json;
    public class Product
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("imageUrl")]
        public object ImageUrl { get; set; }

        [JsonProperty("lastPurchase")]
        public DateTime? LastPurchase { get; set; }

        [JsonProperty("lastSale")]
        public DateTime? LastSale { get; set; }

        [JsonProperty("isAvailabe")]
        public bool IsAvailabe { get; set; }

        [JsonProperty("stock")]
        public long Stock { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("imageFullPath")]
        public object ImageFullPath { get; set; }

        public override string ToString()
        {
            return $"{this.Name} {this.Price:C2}";
        }
    }
}
