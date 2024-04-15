using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Interfaces;
using Project.BLL.Repositories;

namespace Project.PL.Controllers
{
    public class ApartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ApartmentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: AparatmentController
        [Authorize] // add middleware check cookie
        public IActionResult Index()
        {
            var apartmns = _unitOfWork.ApartmentRepo.GetAll();
            return View(apartmns);
        }

        public IActionResult Rented()
        {
            var apartmns = _unitOfWork.ApartmentRepo.Rented();
            return View(apartmns);
        }


        public IActionResult Available()
        {
            var apartmns = _unitOfWork.ApartmentRepo.Available();
            return View(apartmns);
        }


        // GET: AparatmentController/Details/5
        public IActionResult Details(int id)
        {
            return View();
        }

        // GET: AparatmentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AparatmentController/Create
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

        // GET: AparatmentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AparatmentController/Edit/5
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

        // GET: AparatmentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AparatmentController/Delete/5
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
