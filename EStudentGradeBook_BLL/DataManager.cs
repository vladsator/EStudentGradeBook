using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_BLL
{
    abstract class DataManager
    {
        public abstract void Add(object obj);

        public abstract void Remove(object obj);

        public abstract void Update(object destobj, object sourceobj);

        public abstract object DataMapper(object obj);
    }
}
