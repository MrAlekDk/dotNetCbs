using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace students.Models.Entities;

public class Post
    {
        public int PostId { get; set; }
        [StringLength(60, MinimumLength =3, ErrorMessage = "A Title should have minimum 3 characters")]
        [Required (ErrorMessage = "Please insert a titel")]
        public string? Title { get; set; }
        [MinLength(3)]
        [Required (ErrorMessage = "Please insert Text")]
        public string? Text { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)] // Used for only use date and not time.
        public DateTime CreatedDate { get; set; }

        public int MyProperty { get; set; }

        public PostStatus Status { get; set; }

        public List<Comment> Comments {get; set;}

        public string UserId{get; set;}

        public IdentityUser? User{get; set;}
    }
    
