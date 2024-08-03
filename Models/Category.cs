using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace products_api.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(80)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(300)]
        public string ImageUrl { get; set; } = string.Empty;
        public ICollection<Product> Products { get; set; } = [];
    }
}
