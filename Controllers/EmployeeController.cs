using comandamancare.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;




namespace comandamancare.Controllers
{
    public class EmployeeController : Controller
    {

        IList<Employee> employeeList = new List<Employee>() {
                    new Employee(){ EmployeeID=1, EmployeeName="Steve", Age = 21 },
                    new Employee(){ EmployeeID=2, EmployeeName="Bill", Age = 25 },
                    new Employee(){ EmployeeID=3, EmployeeName="Ram", Age = 20 },
                    new Employee(){ EmployeeID=4, EmployeeName="Ron", Age = 31 },
                    new Employee(){ EmployeeID=5, EmployeeName="Rob", Age = 19 }
                };
        // GET: Employee
        public ActionResult ListEmployee()
        {
            ViewBag.TotalEmployees = employeeList.Count();

            return View();
        }

    }

}