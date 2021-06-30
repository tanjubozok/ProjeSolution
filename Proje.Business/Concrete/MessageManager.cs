using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Proje.Business.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;
        private readonly string message = "";

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
            message = "admin@admin.com";
        }

        public void Add(Message message)
        {
            _messageDal.Insert(message);
        }

        public void Delete(Message message)
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(x => x.Id == id);
        }

        public List<Message> GetIsDeleted()
        {
            return _messageDal.List(x => x.IsDeleted);
        }

        public List<Message> GetIsDrafted()
        {
            return _messageDal.List(x => x.IsDrafted);
        }

        public List<Message> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListInbox()
        {
            return _messageDal.List(x => x.ReceiverMail == message && !x.IsDeleted && !x.IsDrafted);
        }

        public int GetListInboxCount()
        {
            return _messageDal.List(x => x.ReceiverMail == message && !x.IsDeleted && !x.IsDrafted).Count;
        }

        public int GetListIsDeletedCount()
        {
            return _messageDal.List(x => x.IsDeleted).Count;
        }

        public int GetListIsDraftedCount()
        {
            return _messageDal.List(x => x.IsDrafted).Count;
        }

        public List<Message> GetListSendbox()
        {
            return _messageDal.List(x => x.SenderMail == message && !x.IsDeleted && !x.IsDrafted);
        }

        public int GetListSendboxCount()
        {
            return _messageDal.List(x => x.SenderMail == message && !x.IsDeleted && !x.IsDrafted).Count;
        }

        public List<Message> List()
        {
            throw new NotImplementedException();
        }

        public int ListCount()
        {
            return _messageDal.ListCount();
        }

        public void Update(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
