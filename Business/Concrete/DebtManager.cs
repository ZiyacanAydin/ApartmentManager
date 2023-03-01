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
    public class DebtManager : IDebtService
    {
        IDebtDal _debtDal;
        public DebtManager(IDebtDal debtDal)
        {
            _debtDal = debtDal;
        }
        public IResult Add(Debt debt)
        {
            _debtDal.Add(debt);
            return new Result(true, "Debt Added");
        }

        public IResult Delete(Debt debt)
        {
            _debtDal.Delete(debt);
            return new Result(true, "debt Deleted");
        }

        public IDataResult<List<Debt>> GetAll()
        {
            return new SuccessDataResult<List<Debt>>(_debtDal.GetAll());
        }

        public IDataResult<Debt> GetByUserId(int debtId)
        {
            return new SuccessDataResult<Debt>(_debtDal.Get(u => u.Id == debtId));
        }

        public IResult Update(Debt debt)
        {
            _debtDal.Update(debt);
            return new Result(true, " Debt Updated");
        }
    }
}
