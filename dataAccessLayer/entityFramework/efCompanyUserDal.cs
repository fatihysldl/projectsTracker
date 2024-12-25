using dataAccessLayer.abstracts;
using dataAccessLayer.concrete;
using dataAccessLayer.concrete.repositories;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.entityFramework
{
    public class efCompanyUserDal : genericRepository<companyUser>, ICompanyUserDal
    {
        public efCompanyUserDal(context context) : base(context)
        {
        }
    }
}
