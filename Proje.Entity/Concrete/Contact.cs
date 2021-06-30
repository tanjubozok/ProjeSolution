using System;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Concrete
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Username { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Subject { get; set; }

        [StringLength(1000)]
        public string Message { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsDrafted { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
