using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.abstracts
{
    public interface ICompanyUserService
    {
        void insert(companyUser p);
        void update(companyUser p);
        void delete(companyUser p);
        List<companyUser> getAll();
        companyUser getById(int id);
        List<companyUser> List(Expression<Func<companyUser, bool>> filter);
    }
}
