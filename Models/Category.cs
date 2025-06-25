using System.ComponentModel.DataAnnotations;

namespace apiEFtst.Models
{

    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [MaxLength(60, ErrorMessage = "This field must be between 3 and 60 characters")]
        [MinLength(3, ErrorMessage = "This field must be between 3 and 60 characters")]
        public string Title { get; set; }
    }
}