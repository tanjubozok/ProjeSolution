using Proje.Entity.Concrete;
using System.Collections.Generic;

namespace Proje.Business.Abstract
{
    public interface IMessageService
    {
        List<Message> List();
        List<Message> GetListById(int id);
        List<Message> GetIsDeleted();
        List<Message> GetIsDrafted();

        List<Message> GetListSendbox();
        List<Message> GetListInbox();

        int GetListSendboxCount();
        int GetListInboxCount();
        int GetListIsDraftedCount();
        int GetListIsDeletedCount();

        Message GetById(int id);

        void Add(Message message);
        void Delete(Message message);
        void Update(Message message);

        int ListCount();
    }
}
