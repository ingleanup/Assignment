using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WB_SQLServer.Models;

namespace WB_SQLServer.Controllers
{
    public class EmployeeeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public EmployeeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
            var model = _employeeRepository.GetAllEmployee();
            return View(model);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var model = _employeeRepository.GetEmployee(id);
            return View(model);
        }


        // GET: EmployeeeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employeee employee)
        {
            try
            {
                var model = _employeeRepository.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _employeeRepository.GetEmployee(id);
            return View(model);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employeee emp)
        {
            try
            {
                var model = _employeeRepository.Update(emp);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        /*  // GET: EmployeeeController1/Edit/5
          public ActionResult Edit(int id)
          {
              return View();
          }

          // POST: EmployeeeController1/Edit/5
          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Edit(int id, IFormCollection collection)
          {
              try
              {
                  return RedirectToAction(nameof(Index));
              }
              catch
              {
                  return View();
              }
          }

          // GET: EmployeeeController1/Delete/5
          public ActionResult Delete(int id)
          {
              return View();
          }

          // POST: EmployeeeController1/Delete/5
          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Delete(int id, IFormCollection collection)
          {
              try
              {
                  return RedirectToAction(nameof(Index));
              }
              catch
              {
                  return View();
              }
          }*/
    }
}
