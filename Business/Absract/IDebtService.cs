using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absract
{
    public interface IDebtService
    {
        IDataResult<List<Debt>> GetAll();
        IDataResult<Debt> GetByUserId(int debtId);
        IResult Add(Debt debt);
        IResult Delete(Debt debt);
        IResult Update(Debt debt);
    }
}
