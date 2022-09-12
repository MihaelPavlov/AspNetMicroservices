namespace Shopping.Aggregator.Models
{
    public class BasketItemExtendedModel // It's came from Basket ShoppingCartItem
    {
        public int Quantity { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }

        public string ProductId { get; set; }

        public string ProductName { get; set; }

        //Product Related Additional Fields // See Catalog Model or Product inside the catalog
        public string Category { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public string ImageFile { get; set; }
    }
}
