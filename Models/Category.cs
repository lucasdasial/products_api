namespace products_api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public String? Name{ get; set; }
        public String? ImageUrl { get; set; }
        public ICollection<Product> Products { get; set; } = [];
    }
}
