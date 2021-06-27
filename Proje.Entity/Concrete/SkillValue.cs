namespace Proje.Entity.Concrete
{
    public class SkillValue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public int SkillProfileId { get; set; }
        public SkillProfile SkillProfile { get; set; }
    }
}
