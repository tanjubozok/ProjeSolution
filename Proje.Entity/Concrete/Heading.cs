﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Concrete
{
    public class Heading
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public DateTime CreateDate { get; set; }

        public bool Status { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int WriterId { get; set; }
        public virtual Writer Writer { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
