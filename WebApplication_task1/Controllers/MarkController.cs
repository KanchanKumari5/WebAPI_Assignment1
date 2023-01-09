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
    public class MarkController : ApiController
    {
        private readonly IMarkRepo _mark;
        public MarkController()
        {
            _mark = new MarkRepo();
        }
        public List<Mark> Get()
        {
            return _mark.GetMarkList();

        }

        public List<Mark> Post(Mark model)
        {
            var Mark = _mark.AddMark(model);

            return Mark;
        }

        public Mark Put(int id, Mark model)
        {
            var Mark = _mark.GetMarkById(id);
            var emp = _mark.UpdateMark(id, model);
            return emp;
        }

        public List<Mark> Delete(int id)
        {

            var Mark = _mark.GetMarkById(id);
            _mark.DeleteMark(id);
            return _mark.GetMarkList(); ;
        }
    }
}
