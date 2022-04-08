using System.ComponentModel.DataAnnotations;

namespace students.Models.Entities;

public class Comment
    {
    
        public int CommentId { get; set; }
        [StringLength(60, MinimumLength =3, ErrorMessage = "A Title should have minimum 3 characters")]
        [Required (ErrorMessage = "Please insert a titel")]
        public string Author { get; set; }
        [MinLength(3)]
        [Required (ErrorMessage = "Please insert your name")]
        public string Text { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)] // Used for only use date and not time.
        public DateTime CreatedDate { get; set; }
        public int Likes {get; set;}
        public int PostId {get;set;}
        public Post Post {get; set;}



    }