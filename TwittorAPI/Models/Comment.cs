using System;
using System.ComponentModel.DataAnnotations;

namespace TwittorAPI.Model
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        [MaxLength(280)]
        public string CommentBody { get; set; }

        [Required]
        public int TwittorId { get; set; }

        public Twittor Twittor { get; set; }
    }
}
