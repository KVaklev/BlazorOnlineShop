namespace BlazorOnlineShop.Shared
{
    public class Product
    {
        public Product()
        {
            
        }
        public int? ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public DateTime DeliveryOn { get; set; }
    }
}
