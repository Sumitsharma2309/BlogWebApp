using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogWebApp1.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "the username name is required")]
        [MaxLength(100, ErrorMessage = "the username name cannot be exceed 100 char")]
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }
        [Required]
        public string Content { get; set; }

        [ForeignKey("Post")]
        public int PostId  { get; set; }

        public Post Post { get; set; }
    }
}
