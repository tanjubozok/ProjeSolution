using Proje.Business.Abstract;
using Proje.Data.Abstract;
using Proje.Entity.Concrete;
using System;
using System.Collections.Generic;

namespace Proje.Business.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;
        string message = "";

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
            message = "admin@admin.com";
        }

        public void Add(Message message)
        {
            throw new NotImplementedException();
        }

        public void Delete(Message message)
        {
            throw new NotImplementedException();
        }

        public Message GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Message> GetListReceiver()
        {
            return _messageDal.List(x => x.ReceiverMail == message);
        }

        public List<Message> GetListSender()
        {
            return _messageDal.List(x => x.SenderMail == message);
        }

        public List<Message> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
