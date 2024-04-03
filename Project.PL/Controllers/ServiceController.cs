using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Interfaces;
using Project.DAL.Entities;

namespace Project.PL.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ServiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: ServiceController
        public IActionResult Index()
        {
            var services = _unitOfWork.ServiceRepo.GetAll();
            return View(services);
        }

  
        // GET: ServiceController/Create
        public IActionResult Create()
        {
     
            return View(new Service());
        }

        // POST: ServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Service service)
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

        // GET: ServiceController/Edit/5
        public IActionResult Edit(int id)
        {
            var service =_unitOfWork.ServiceRepo.GetById(id);

            return View(service);
        }

        // POST: ServiceController/Edit/5
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


              // GET: ServiceController/Details/5
        public ActionResult Details(int id)
        {

            var service = _unitOfWork.ServiceRepo.GetById(id);
            return View(service);
        }



        // GET: ServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            var service = _unitOfWork.ServiceRepo.GetById(id);
            _unitOfWork.ServiceRepo.Delete(service);
            return View();
        }

        // POST: ServiceController/Delete/5
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
        }
    }
}
