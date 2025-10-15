using System.ComponentModel.DataAnnotations;

namespace BlogWebApp1.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="the category name is required")]
        [MaxLength(100, ErrorMessage = "the category name cannot be exceed 100 char")]
        public string Name { get; set; }
       
        public string ? Description { get; set; }

        public ICollection<Post> Posts { get; set; }

    }
}
