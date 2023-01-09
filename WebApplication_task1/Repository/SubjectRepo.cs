using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WebApplication_task1.Models;

namespace WebApplication_task1.Repository
{
    public class SubjectRepo : ISubjectRepo
    {
        private readonly MyContext _myContext;
        public SubjectRepo()
        {
            _myContext = new MyContext();
        }
  
        public List<Subject> GetSubjectList()
        {
            return _myContext.Subjects.ToList();
        }

        public Subject GetSubjectById(int id)
        {
            return _myContext.Subjects.FirstOrDefault(e => e.SubjectId == id);
        }

        public Subject AddSubject(Subject model)
        {
            _myContext.Subjects.Add(model);
            _myContext.SaveChanges();
            return model;
        }

        public Subject UpdateSubject(int id, Subject model)
        {
            var subject = GetSubjectById(id);
            subject.Name = model.Name;
        

            _myContext.Subjects.AddOrUpdate(subject);
            _myContext.SaveChanges();

            return subject;
        }

        void ISubjectRepo.DeleteSubject(int id)
        {
            throw new NotImplementedException();
        }
    }
}