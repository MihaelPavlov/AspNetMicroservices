namespace Shopping.Aggregator.Models
{
    using System.Collections.Generic;

    public class BasketModel // It's came from Basket ShoopingCart
    {
        public string UserName { get; set; }

        public List<BasketItemExtendedModel> Items { get; set; } = new List<BasketItemExtendedModel>();

        public decimal TotalPrice { get; set; }
    }
}
