using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfMessageDal : EfEntityRepositoryBase<Message, InvoiceDbContext>, IMessageDal
    {
    }
}
