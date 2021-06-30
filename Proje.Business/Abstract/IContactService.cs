using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Abstract
{
    public interface IContactService
    {
        List<Contact> List();
        List<Contact> GetListById(int id);

        Contact GetById(int id);
        int GetListContactCount();

        void Add(Contact contact);
        void Delete(Contact contact);
        void Update(Contact contact);
    }
}
