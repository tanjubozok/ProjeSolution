using System;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Concrete
{
    public class Message
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string SenderMail { get; set; }

        [StringLength(50)]
        public string ReceiverMail { get; set; }

        [StringLength(100)]
        public string Subject { get; set; }

        [StringLength(1000)]
        public string Content { get; set; }

        public DateTime MessageDate { get; set; }
    }
}
