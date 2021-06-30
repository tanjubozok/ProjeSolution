using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;

namespace Proje.Business.Concrete
{
    public class SkillProfileManager : ISkillProfileService
    {
        private readonly ISkillProfileDal _skillProfileDal;

        public SkillProfileManager(ISkillProfileDal skillProfileDal)
        {
            _skillProfileDal = skillProfileDal;
        }

        public SkillProfile GetById(int id)
        {
            return _skillProfileDal.Get(x => x.Id == id);
        }
    }
}
