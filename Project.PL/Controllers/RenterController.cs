using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Interfaces;
using Project.DAL.Entities;

namespace Project.PL.Controllers
{
    public class RenterController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public RenterController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: RenterController
        public IActionResult Index()
        {
            var renters = _unitOfWork.RenterRepo.GetAll();
            return View(renters);
        }

        // GET: RenterController/Details/5
        public IActionResult Details(int id)
        {
           var renter = _unitOfWork.RenterRepo.GetById(id);
            return View(renter);
        }

        // GET: RenterController/Create
        public IActionResult Create()
        {
            ViewBag.Apartments = _unitOfWork.ApartmentRepo.Available();
            return View(new Renter());
        }

        // POST: RenterController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Renter renter)
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


        // GET: RenterController/Edit/5
        public IActionResult Edit(int id)
        {
            var renter = _unitOfWork.RenterRepo.GetById(id);
            return View(renter);
        }

        // POST: RenterController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Renter renter)
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

        // GET: RenterController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RenterController/Delete/5
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
