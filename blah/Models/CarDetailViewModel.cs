namespace blah.Models
{
    public class CarDetailViewModel
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string Model3dPath { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public List<string> PossibleModifications { get; set; } = new();
    }
}
