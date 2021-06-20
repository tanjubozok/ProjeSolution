using System;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Concrete
{
    public class About
    {
        [Key]
        public int Id { get; set; }

        [StringLength(500)]
        public string DetailFirst { get; set; }

        [StringLength(500)]
        public string DetailSecond { get; set; }

        [StringLength(100)]
        public string ImageFirst { get; set; }

        [StringLength(100)]
        public string ImageSecond { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
