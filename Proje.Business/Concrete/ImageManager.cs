using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Concrete
{
    public class ImageManager : IImageService
    {
        private readonly IImageDal _imageDal;

        public ImageManager(IImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public List<Image> List()
        {
            return _imageDal.List();
        }

        public int ListCount()
        {
            return _imageDal.ListCount();
        }
    }
}
