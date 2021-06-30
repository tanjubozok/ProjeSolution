using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Abstract
{
    public interface IImageService
    {
        List<Image> List();

        int ListCount();
    }
}
