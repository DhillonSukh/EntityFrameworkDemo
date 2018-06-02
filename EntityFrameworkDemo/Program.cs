using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EntityFrameworkDemoEntities();
            var emp = new Employee()
            {
                EmployeeId = 1,
                EmployeeName = "Sukhpreet",
                Gender = "Female",
                Salary = 2000
            };
            context.Employees.Add(emp);
            context.SaveChanges();
        }
    }
}
