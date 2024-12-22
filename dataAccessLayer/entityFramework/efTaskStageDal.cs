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
    public class efTaskStageDal : genericRepository<taskStage>, ITaskStageDal
    {
        public efTaskStageDal(context context) : base(context)
        {
        }
    }
}
