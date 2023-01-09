using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication_task1.Models;
using WebApplication_task1.Repository;

namespace WebApplication_task1.Controllers
{
    public class SubjectController : ApiController
    {
        private readonly ISubjectRepo _subj;

        public SubjectController()
        {
            _subj = new SubjectRepo();
        }
        public IEnumerable<Subject> Get()
        {
            return _subj.GetSubjectList();
        }

        // GET api/values/5
        public Subject GetSubject(int id)
        {
            return _subj.GetSubjectById(id);
        }

        // POST api/values
        public Subject Post([FromBody] Subject model)
        {
            return _subj.AddSubject(model);
        }

        // PUT api/values/5
        public Subject Put(int id, Subject model)
        {
            return _subj.UpdateSubject(id, model);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            _subj.DeleteSubject(id);
        }
    }
}
