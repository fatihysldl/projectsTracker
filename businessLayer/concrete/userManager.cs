using businessLayer.abstracts;
using dataAccessLayer.abstracts;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.concrete
{
    public class userManager : IUserService
    {
        IUserDal _userDal;

        public userManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void delete(AppUser p)
        {
            _userDal.delete(p);
        }

        public List<AppUser> getAll()
        {
            return _userDal.getAll();
        }

        public AppUser getById(int id)
        {
            return _userDal.getById(id);
        }

        public void insert(AppUser p)
        {
            _userDal.insert(p);
        }

        public List<AppUser> List(Expression<Func<AppUser, bool>> filter)
        {
            return _userDal.List(filter);
        }

        public void update(AppUser p)
        {
            _userDal.update(p);
        }
    }
}
