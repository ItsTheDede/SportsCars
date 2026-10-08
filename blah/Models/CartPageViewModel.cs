namespace blah.Models
{
    public class CartPageViewModel
    {
        public List<CartItemViewModel> Items { get; set; } = new();
        public decimal Total { get; set; }
    }
}