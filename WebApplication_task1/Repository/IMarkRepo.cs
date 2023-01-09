using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication_task1.Models;

namespace WebApplication_task1.Repository
{
    public interface IMarkRepo
    {
        List<Mark> GetMarkList();
        Mark GetMarkById(int id);
        List<Mark> AddMark(Mark model);

        Mark UpdateMark(int id, Mark model);

        void DeleteMark(int id);
    }
}
