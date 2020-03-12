using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnAPIDemo2.Models;
namespace HandsOnAPIDemo2.Repositories
{
    public class EmployeeRepository
    {
        //Get All Employees
        public List<Employee> GetAll()
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                return db.Employee.ToList();
            }
        }
        //Get Employee By Id
        public Employee GetById(string eid)
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                return db.Employee.Find(eid);
            }
        }
        //Add Employee
        public void Add(Employee item)
        {
            using(EMSDBContext db=new EMSDBContext())
            {
                db.Employee.Add(item);
                db.SaveChanges();
            }
        }
        //Delete Record
        public void Delete(int eid)

        {
            using(EMSDBContext db=new EMSDBContext())
            {
                Employee e = db.Employee.Find(eid);
                db.Employee.Remove(e);
                db.SaveChanges();
            }
        }
        public void Update(Employee item)
        {
            using (EMSDBContext db = new EMSDBContext())
            {
                db.Employee.Update(item);
                db.SaveChanges();
            }
        }
    }
}
