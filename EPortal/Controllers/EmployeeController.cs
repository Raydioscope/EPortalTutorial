using EPortal.Models;
using EPortal.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EPortal.Controllers
{
    //[RoutePrefix("Employee")]
    public class EmployeeController : Controller
    {
        EmployeeService service = new EmployeeService();
        // GET: Employee

        //[Route("Employee/Index")]

        [ActionName("Index")]
        public ActionResult Index()
        {
            var empList = service.GetEmployees();   
            return View("Index",empList);
            
        }

        // GET: Employee/Details/5
        [Route("Employee/EmpDetails/{empid}/{name}")]
        public ActionResult Details(int empid, string name)
        {            
            return View(service.getEmployeeDetails(empid, name));
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            try
            {
                
                if (ModelState.IsValid)
                {
                    
                    service.AddEmployee(emp);
                    return RedirectToAction("Index");
                }
                else
                {
                    
                    return View(emp);
                }
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(int empid)
        {
            Employee editedEmployee = service.getEmployeeDetailsByID(empid);
            return View(editedEmployee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Employee emp)
        {
            try
            {

                service.UpdateEmployee(emp);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            
            return View(service.getEmployeeDetailsByID(id));
        }

        // POST: Employee/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Employee emp)
        {
            try
            {

                service.DeleteEmployee(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Show()
        {
            
            Employee showEmployee =  new Employee
            {
                EmployeeID = 1,
                EmployeeName = "Arijit",
                EmployeeCity = "Bangalore",
                EmployeeAge = 28,
                EmployeeSex = "M",
                JoiningDate = "10/4/2021",
                EmailID = "arijitray.prof@gmail.com"
            };
            ViewData["emp"] = showEmployee;
            ViewBag.message = "this is a message";
            return View(showEmployee);
        }

        
    }
}
