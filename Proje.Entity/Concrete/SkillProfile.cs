using System.Collections.Generic;

namespace Proje.Entity.Concrete
{
    public class SkillProfile
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Profession { get; set; }

        public ICollection<SkillValue> SkillValues { get; set; }

    }
}
