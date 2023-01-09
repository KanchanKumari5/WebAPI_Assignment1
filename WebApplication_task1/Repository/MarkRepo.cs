using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using WebApplication_task1.Models;

namespace WebApplication_task1.Repository
{
    public class MarkRepo : IMarkRepo
    {
        private readonly MyContext _myContext;
        public MarkRepo()
        {
            _myContext = new MyContext();
        }
        public List<Mark> AddMark(Mark model)
        {
            _myContext.Marks.Add(model);
            _myContext.SaveChanges();
            return GetMarkList();
        }

        public void DeleteMark(int id)
        {
            var Mark = _myContext.Marks.FirstOrDefault(e => e.MarkId == id);
            _myContext.Marks.Remove(Mark);
            _myContext.SaveChanges();
        }

        public Mark GetMarkById(int id)
        {
            var Mark = _myContext.Marks.FirstOrDefault(e => e.MarkId == id);
            return Mark;
        }

        public List<Mark> GetMarkList()
        {
            return _myContext.Marks.ToList();
        }

        public Mark UpdateMark(int id, Mark model)
        {
            var Mark = _myContext.Marks.FirstOrDefault(e => e.MarkId == id);

            Mark.Marks = model.Marks;

            _myContext.Marks.AddOrUpdate(Mark);
            _myContext.SaveChanges();
            return Mark;
        }
    }
}