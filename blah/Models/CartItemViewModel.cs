namespace blah.Models
{
    public class CartItemViewModel
    {
        public int Id { get; set; }
        public string CarId { get; set; } = string.Empty;
        public string CarName { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Model3dPath { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
