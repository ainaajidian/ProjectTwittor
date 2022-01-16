using System;
using System.Collections.Generic;

#nullable disable

namespace KafkaApp.Models
{
    public partial class Twittor
    {
        public Twittor()
        {
            Comments = new HashSet<Comment>();
        }

        public int TwittorId { get; set; }
        public string TwitBody { get; set; }
        public int UserId { get; set; }
        public DateTime Created { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
