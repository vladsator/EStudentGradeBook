//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EStudentGradeBook_DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class grouplesson
    {
        public int grouplesson_id { get; set; }
        public int grouplesson_group_id { get; set; }
        public int grouplesson_lesson_id { get; set; }
    
        public virtual group group { get; set; }
        public virtual lesson lesson { get; set; }
    }
}