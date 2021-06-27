using Proje.Entity.Concrete;
using System.Data.Entity;

namespace Proje.Data.Concrete
{
    public class DatabaseContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<SkillProfile> SkillProfiles { get; set; }
        public DbSet<SkillValue> SkillValues { get; set; }
    }
}
