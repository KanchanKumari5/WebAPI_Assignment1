using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication_task1.Models;

namespace WebApplication_task1.Repository
{
    public interface ISubjectRepo
    {
        List<Subject> GetSubjectList();

        Subject GetSubjectById(int id);

        Subject AddSubject(Subject model);

        Subject UpdateSubject(int id, Subject model);

        void DeleteSubject(int id);


    }
}