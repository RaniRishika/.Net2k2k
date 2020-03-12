using System;
using EFDAL;
using EFDAL.Models;
using EFDAL.Context;
namespace EMS_Client
{
    class Program
    {
        static void Main(string[] args)
        {
           //Add new Project
           using(MyContext db=new MyContext())
            {
                Project p = new Project() { ProjectName = "BFS" };
                db.Add(p);
                db.SaveChanges();
            }
        }
    }
}
