namespace Proje.Business.Abstract
{
    public interface IIstatistikService
    {
        int CountCategory();
        int CountHeading();
        int CountWriter();
        string MaxCategory();
        int CountStatus();
    }
}
