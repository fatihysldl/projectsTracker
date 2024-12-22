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
    public class taskStageManager : ITaskStageService
    {
        ITaskStageDal _taskStage;

        public taskStageManager(ITaskStageDal taskStage)
        {
            _taskStage = taskStage;
        }

        public void delete(taskStage p)
        {
            _taskStage.delete(p);
        }

        public List<taskStage> getAll()
        {
            return _taskStage.getAll();
        }

        public taskStage getById(int id)
        {
            return _taskStage.getById(id);
        }

        public void insert(taskStage p)
        {
            _taskStage.insert(p);
        }

        public List<taskStage> List(Expression<Func<taskStage, bool>> filter)
        {
            return _taskStage.List(filter);
        }

        public void update(taskStage p)
        {
            _taskStage.update(p);
        }
    }
}
