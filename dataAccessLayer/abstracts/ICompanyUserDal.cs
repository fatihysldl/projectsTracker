﻿using dataAccessLayer.concrete.repositories;
using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.abstracts
{
    public interface ICompanyUserDal:IRepositoryDal<companyUser>
    {
    }
}
