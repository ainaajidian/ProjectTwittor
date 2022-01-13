using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TwittorAPI.Model
{
    public class User
    {
        [Key]
        [Required]
        public int UserId { get; set; }
        [Required] 
        public string Fullname { get; set; }
        [Required] 
        public string Email { get; set; }
        [Required] 
        public string Username { get; set; }
        [Required] 
        public string Password { get; set; }
        [Required] 
        public bool IsLocked { get; set; }

        public ICollection<Twittor> Twittors { get; set; }
    }
}
