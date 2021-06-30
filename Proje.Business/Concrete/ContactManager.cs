using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void Add(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void Delete(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.Id == id);
        }

        public List<Contact> GetListById(int id)
        {
            return _contactDal.List(x => x.Id == id);
        }

        public int GetListContactCount()
        {
            return _contactDal.List().Count;
        }

        public List<Contact> List()
        {
            return _contactDal.List();
        }

        public void Update(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }
}
