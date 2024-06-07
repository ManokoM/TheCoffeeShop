namespace TheCoffeeShop.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public int ClientId { get; set; }
        public int Quantity { get; set; }
        public Client Client { get; set; }
    }
}
