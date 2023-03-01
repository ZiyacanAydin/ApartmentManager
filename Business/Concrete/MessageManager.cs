using Business.Absract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MessageManager : IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public IResult Add(Message message)
        {
            _messageDal.Add(message);
            return new Result(true, "Message Added");
        }

        public IResult Delete(Message message)
        {
            _messageDal.Delete(message);
            return new Result(true, "Message Deleted");
        }

        public IDataResult<List<Message>> GetAll()
        {
            return new SuccessDataResult<List<Message>>(_messageDal.GetAll());
        }

        public IDataResult<Message> GetByUserId(int messageId)
        {
            return new SuccessDataResult<Message>(_messageDal.Get(u => u.Id == messageId));
        }

        public IResult Update(Message message)
        {
            _messageDal.Update(message);
            return new Result(true, " User Updated");
        }
    }
}
