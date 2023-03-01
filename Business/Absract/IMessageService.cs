using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absract
{
    public interface IMessageService
    {
        IDataResult<List<Message>> GetAll();
        IDataResult<Message> GetByUserId(int messageId);
        IResult Add(Message message);
        IResult Delete(Message message);
        IResult Update(Message message);
    }
}
