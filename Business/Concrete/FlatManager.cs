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
    public class FlatManager : IFlatService
    {
        IFlatDal _flatDal;
        public FlatManager(IFlatDal flatDal)
        {
            _flatDal= flatDal;
        }
        public IResult Add(Flat flat)
        {
            _flatDal.Add(flat);
            return new Result(true, "Flat Added");
        }

        public IResult Delete(Flat flat)
        {
            _flatDal.Delete(flat);
            return new Result(true, "Flat Deleted");
        }

        public IDataResult<List<Flat>> GetAll()
        {
            return new SuccessDataResult<List<Flat>>(_flatDal.GetAll());
        }

        public IDataResult<Flat> GetByUserId(int flatId)
        {
            return new SuccessDataResult<Flat>(_flatDal.Get(u => u.Id == flatId));
        }

        public IResult Update(Flat flat)
        {
            throw new NotImplementedException();
        }
    }
}
