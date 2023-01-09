using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication_task1.Models;

namespace WebApplication_task1.Repository
{
    public  interface IStudentRepo
    {
        List<Student> GetStudent();

        Student GetStudent(int Id);

        Student AddStudent(Student model);

        void Delete(int Id);
        Student Update(int id, Student model);
    }
}
