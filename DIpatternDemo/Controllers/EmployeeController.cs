using DIpatternDemo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DIpatternDemo.Models;

namespace DIpatternDemo.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly IEmployeeService service;
        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }
        // GET: EmployeeController
        public ActionResult Index()
        {
          var model=service.GetEmployees();
            return View(model);
        }

        // GET: EmployeeController/Details/5
        public ActionResult Details(int id)
        {
            var model = service.GetEmployeeById(id);
            return View(model);
        }

        // GET: EmployeeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Emp e)
        {
            try
            {
                int res = service.AddEmployee(e);
                if (res >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {

                    ViewBag.ErrorMsg = "Something went wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
        }

        // GET: EmployeeController/Edit/5
        public ActionResult Edit(int id)
        {
            var model = service.GetEmployeeById(id);
            return View(model);
        }

        // POST: EmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Emp e)
        {
            try
            {
                int res = service.EditEmployee(e);
                if (res >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {

                    ViewBag.ErrorMsg = "Something went wrong";
                    return View();
                }

            }
            catch (Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
        }

        // GET: EmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            var model = service.GetEmployeeById(id);
            return View(model);
        }

        // POST: EmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult Deletefrom(int id)
        {
            try
            {
                int res = service.DeleteEmployee(id);
                if (res >= 1)
                {
                    return RedirectToAction(nameof(Index));
                }
                else
                {

                    ViewBag.ErrorMsg = "Something went wrong";
                    return View();
                }
            }

            catch (Exception ex)
            {
                ViewBag.ErrorMsg = ex.Message;
                return View();
            }
        }
    }
}
