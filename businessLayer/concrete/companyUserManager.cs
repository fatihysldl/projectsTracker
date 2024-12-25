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
    public class companyUserManager : ICompanyUserService
    {
        ICompanyUserDal _companyUser;

        public companyUserManager(ICompanyUserDal companyUser)
        {
            _companyUser = companyUser;
        }

        public void delete(companyUser p)
        {
            _companyUser.delete(p);
        }

        public List<companyUser> getAll()
        {
            return _companyUser.getAll();
        }

        public companyUser getById(int id)
        {
            return _companyUser.getById(id);
        }

        public void insert(companyUser p)
        {
            _companyUser.insert(p);
        }

        public List<companyUser> List(Expression<Func<companyUser, bool>> filter)
        {
            return _companyUser.List(filter);
        }

        public void update(companyUser p)
        {
            _companyUser.update(p);
        }
    }
}
