namespace blah.Models
{
    public class AdminDashboardViewModel
    {
        public List<UserAccount> Users { get; set; } = new();
        public List<CartItem> CartItems { get; set; } = new();
        public decimal CartTotal { get; set; }
    }
}