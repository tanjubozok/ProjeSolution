using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Concrete
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string Username { get; set; }

        [StringLength(250)]
        public string Password { get; set; }

        [StringLength(1)]
        public string Role { get; set; }
    }
}
