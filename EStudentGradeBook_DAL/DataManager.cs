using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_DAL
{
    public abstract class DataManager<T>
    {
        public abstract void Add(T addObj);
        public abstract void Remove(T removeObj);
        public abstract void Update(T updateObj);

        public abstract List<T> GetList();

    }
}
