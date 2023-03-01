using Business.Absract;
using Core.Utilities.Results;
using DataAccessLayer.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal= userDal;
        }
        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new Result(true,"User Added");
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new Result(true, "User Deleted");
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetByUserId(int userId)
        {
            return new SuccessDataResult<User>(_userDal.Get(u => u.Id == userId));
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new Result(true, " User Updated");
        }
    }
}
