using System.ComponentModel.DataAnnotations;

namespace apiEFtst.Models 
{
    public class Client 
    {
        [Key]
        public int Id {get; set;}

        [Required(ErrorMessage="This field is required")]
        [MinLength(1,ErrorMessage="This field must be minimum 1 character")]
        public string Email {get; set;}

        [Required(ErrorMessage="This field is required")]
        [MaxLength(60,ErrorMessage="This field must be between 3 and 60 characters")]
        [MinLength(3,ErrorMessage="This field must be between 3 and 60 characters")]
        public string Password {get; set;}

        [Required(ErrorMessage="This field is required")]
        [MinLength(4,ErrorMessage="This field must be minimum 4 characters")]
        public string Username {get; set;}
        [Range(1, int.MaxValue, ErrorMessage="Invalid Product")]
        public int ProductId {get; set;}
        public Product Product {get; set;}
    }
}