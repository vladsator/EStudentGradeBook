using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_BLL
{
    interface IDataManager
    {
        void Add();
        void Remove();
        object GetList();
    }
}
