using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.abstracts
{
    public interface IProjectService
    {
        void insert(project p);
        void update(project p);
        void delete(project p);
        List<project> getAll();
        project getById(int id);
        List<project> getProjectsByCompany(int companyUserID);

    }
}
