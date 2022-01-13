using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TwittorAPI.Model
{
    public class Twittor
    {
        [Key]
        [Required]
        public int TwittorId { get; set; }
        public int UserId { get; set; }
        public string TwitBody { get; set; }
        public DateTime CreatedDate { get; set; }

        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
