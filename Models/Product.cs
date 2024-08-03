using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace products_api.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(80)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(300)]
        public string? ImageUrl { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public decimal Price { get; set; }
        public float QuantityInStock { get; set; } = 1F;
        public DateTime CreateAt { get; set; } = DateTime.Now;

        public int CategoryId { get; set; }

        [JsonIgnore]
        public Category? Category { get; set; }
    }
}
