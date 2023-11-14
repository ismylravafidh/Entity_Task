using ConsoleApp1.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    internal class StudentService
    {
        AppDBContext dbContexts = new AppDBContext();
        public void AddStudent(Student student)
        {
            dbContexts.Students.Add(student);
            dbContexts.SaveChanges();
        }

    }
}
