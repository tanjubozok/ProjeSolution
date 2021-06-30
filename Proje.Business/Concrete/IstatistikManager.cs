using Proje.Data.Concrete;
using System.Linq;

namespace Proje.Business.Concrete
{
    public class IstatistikManager
    {
        private readonly DatabaseContext _databaseContext = new DatabaseContext();

        public int CountCategory()
        {
            int categoryCount = _databaseContext.Categories.Count();
            return categoryCount;
        }

        public int CountHeading()
        {
            int headingCount = _databaseContext.Headings.Count(x => x.Category.Name == "Yazılım");
            return headingCount;
        }

        public int CountStatus()
        {
            int trueCount = _databaseContext.Categories.Count(x => x.Status == true);
            int falseCount = _databaseContext.Categories.Count(x => x.Status == false);
            int countStatus = trueCount - falseCount;
            return countStatus;
        }

        public int CountWriter()
        {
            int writerCount = _databaseContext.Writers.Count(x => x.Name.Contains("a"));
            return writerCount;
        }

        public string MaxCategory()
        {
            string categoryName = _databaseContext.Headings.Max(x => x.Category.Name);
            return categoryName;
        }
    }
}
