using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.abstracts
{
    public interface IUserService
    {
        void insert(AppUser p);
        void update(AppUser p);
        void delete(AppUser p);
        List<AppUser> getAll();
        AppUser getById(int id);
        List<AppUser> List(Expression<Func<AppUser, bool>> filter);
    }
}
