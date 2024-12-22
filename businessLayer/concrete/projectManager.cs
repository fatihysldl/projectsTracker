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
    public class projectManager : IProjectService
    {
        IProjectDal _project;

        public projectManager(IProjectDal project)
        {
            _project = project;
        }

        public void delete(project p)
        {
            _project.delete(p);
        }

        public List<project> getAll()
        {
            return _project.getAll();
        }

        public project getById(int id)
        {
            return _project.getById(id);
        }

        public void insert(project p)
        {
            _project.insert(p);
        }

        public List<project> List(Expression<Func<project, bool>> filter)
        {
            return _project.List(filter);
        }

        public void update(project p)
        {
            _project.update(p);
        }
    }
}
