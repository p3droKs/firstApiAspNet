using System.ComponentModel.DataAnnotations;

namespace apiEFtst.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "This field must be between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must be between 3 and 60 characters")]
        public string Title { get; set; }

        [MaxLength(1024, ErrorMessage = "This field must be max 1024 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "The price must be greater than zero")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Invalid Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}