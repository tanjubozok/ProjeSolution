using Proje.Entity.Concrete;

namespace Proje.Business.Abstract
{
    public interface ISkillProfileService
    {
        SkillProfile GetById(int id);
    }
}
