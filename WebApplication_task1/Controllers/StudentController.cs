using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebApplication_task1.Models;
using WebApplication_task1.Repository;

namespace WebApplication_task1.Controllers
{
    public class StudentController : ApiController
    {
        private readonly IStudentRepo _stud;
        // GET: Student
       public StudentController() 
       {
            _stud = new StudentRepo();
       }

        public IEnumerable<Student> Get()
        {
           return _stud.GetStudent();
        }

        // GET api/values/5
        public Student Get(int id)
        {
            return _stud.GetStudent(id);
        }

        // POST api/values
        public Student Post([FromBody] Student model)
        {
            return _stud.AddStudent(model);
        }

        // PUT api/values/5
        public Student Put(int id,Student model)
        {
            return _stud.Update(id, model);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _stud.Delete(id);
        }
    }
}