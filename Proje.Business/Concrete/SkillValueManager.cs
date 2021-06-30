using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Concrete
{
    public class SkillValueManager : ISkillValueService
    {
        private readonly ISkillValueDal _skillValueDal;

        public SkillValueManager(ISkillValueDal skillValueDal)
        {
            _skillValueDal = skillValueDal;
        }

        public List<SkillValue> List()
        {
            return _skillValueDal.List();
        }
    }
}
