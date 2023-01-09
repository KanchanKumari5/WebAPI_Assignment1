using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WebApplication_task1.Models;

namespace WebApplication_task1.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private readonly MyContext _myContext;
        public StudentRepo()
        {
            _myContext = new MyContext();
        }
        public Student AddStudent(Student model)
        {
            _myContext.Students.Add(model);
            _myContext.SaveChanges();
            return model;
        }

        public void Delete(int Id)
        {
            _myContext.Students.Remove(GetStudent(Id));
            _myContext.SaveChanges();
        }

        public List<Student> GetStudent()
        {
            return _myContext.Students.ToList();
        }

        public Student GetStudent(int Id)
        {
            return _myContext.Students.FirstOrDefault(e => e.StudentId == Id);
        }

      

        public Student Update(int Id, Student model)
        {
            var student = GetStudent(Id);
            student.FirstName = model.FirstName;
            student.LastName = model.LastName;
            student.Email = model.Email;
            student.MobileNumber = model.MobileNumber;

            _myContext.Students.AddOrUpdate(student);
            _myContext.SaveChanges();

            return student;
        }
    }
}