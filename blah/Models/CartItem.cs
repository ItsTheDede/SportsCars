namespace blah.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public string CarId { get; set; } = string.Empty;
        public string CarName { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}