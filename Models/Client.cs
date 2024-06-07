﻿namespace TheCoffeeShop.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
        public ICollection<Purchase> Purchases { get; set; }
    }
}
