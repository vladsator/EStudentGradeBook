﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_DAL
{
    public class StudentDataManager : DataManager<Student>
    {
        private readonly EStudentGradeBookDBContext _context = new EStudentGradeBookDBContext();

        public override void Add(Student addObj)
        {
            _context.Students.Add(addObj);
            _context.SaveChanges();
        }

        public override void Remove(Student removeObj)
        {
            _context.Students.Remove(removeObj);
            _context.SaveChanges();
        }
        
        //TODO: test this shit!
        public override void Update(Student updateObj)
        {
            var student = _context.Students.FirstOrDefault(s => s.student_id == updateObj.student_id);
            student = updateObj;
            _context.SaveChanges();

        }

        public override List<Student> GetList()
        {
            EStudentGradeBookDBContext context = new EStudentGradeBookDBContext();
            var query = from s in context.Students
                select s;            
            return query.ToList();
        }
    }
}
