namespace products_api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String? Name { get; set; }
        public String? ImageUrl { get; set; }
        public decimal Price { get; set; }
        public float QuantityInStock { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }
        public Category Category { get; set; } = new();
    }
}
