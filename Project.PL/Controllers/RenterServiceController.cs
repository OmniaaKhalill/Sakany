using Microsoft.AspNetCore.Mvc;
using Project.BLL.Interfaces;

namespace Project.PL.Controllers
{
    public class RenterServiceController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public RenterServiceController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: RenterServiceController
        public IActionResult Index()
        {

           var requestedServices=_unitOfWork.RenterServiceRepo.GetAll();

            return View(requestedServices);
        }

        // GET: RenterServiceController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: RenterServiceController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RenterServiceController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: RenterServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RenterServiceController/Edit/5
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

        // GET: RenterServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RenterServiceController/Delete/5
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
