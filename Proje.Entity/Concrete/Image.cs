using System.ComponentModel.DataAnnotations;

namespace Proje.Entity.Concrete
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        [StringLength(250)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Path { get; set; }
    }
}
