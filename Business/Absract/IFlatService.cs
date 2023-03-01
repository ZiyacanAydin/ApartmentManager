using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Absract
{
    public interface IFlatService
    {
        IDataResult<List<Flat>> GetAll();
        IDataResult<Flat> GetByUserId(int flatId);
        IResult Add(Flat flat);
        IResult Delete(Flat flat);
        IResult Update(Flat flat);
    }
}
