using entityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace businessLayer.abstracts
{
    public interface ITaskStageService
    {
        void insert(taskStage p);
        void update(taskStage p);
        void delete(taskStage p);
        List<taskStage> getAll();
        taskStage getById(int id);
        List<taskStage> List(Expression<Func<taskStage, bool>> filter);
    }
}
