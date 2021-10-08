using EPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EPortal.Services
{
    public class EmployeeService
    {
        public static List<Employee> empList = new List<Employee>();
        public List<Employee> GetEmployees()
        {
           
            if (!empList.Any())
            {
                Employee emp1 = new Employee
                {
                    EmployeeID = 1,
                    EmployeeName = "Arijit",
                    EmployeeCity = "Bangalore",
                    EmployeeAge = 28,
                    EmployeeSex = "M",
                    JoiningDate = "10/4/2021",
                    EmailID = "arijitray.prof@gmail.com"
                };
                Employee emp2 = new Employee
                {
                    EmployeeID = 2,
                    EmployeeName = "Prem",
                    EmployeeCity = "Bangalore",
                    EmployeeAge = 28,
                    EmployeeSex = "M",
                    JoiningDate = "10/4/2021",
                    EmailID = "arijitray.prof@gmail.com"
                };


                empList.Add(emp1);
                empList.Add(emp2);
            }
            return empList;
        }

        public Employee getEmployeeDetailsByID( int ID)
        {
            var index = empList.FindIndex(x => x.EmployeeID == ID );
            return empList[index];

        }

        public void AddEmployee(Employee emp)
        {
            empList.Add(emp);
        }

        public void UpdateEmployee(Employee emp)
        {
            int index = empList.FindIndex(e => e.EmployeeID == emp.EmployeeID);
            empList[index] = emp;
        }

        public Employee getEmployeeDetails(int ID, string name)
        {
            var index = empList.FindIndex(x => x.EmployeeID == ID  && x.EmployeeName == name);
            return empList[index];
        }

        public void DeleteEmployee(int id)
        {
            Employee delEmp = empList.Find(x => x.EmployeeID == id);
            empList.Remove(delEmp);
        }
    }
}
