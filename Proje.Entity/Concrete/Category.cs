﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Concrete
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public bool Status { get; set; }
        public DateTime CreateDate { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
