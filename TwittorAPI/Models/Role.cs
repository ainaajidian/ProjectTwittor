using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TwittorAPI.Model
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<UserRole> UserRoles { get; set; }
    }
}
