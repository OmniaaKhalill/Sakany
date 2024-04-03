using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.BLL.Interfaces;
using Project.DAL.Entities;

namespace Project.PL.Controllers
{
    public class OwnerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public OwnerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: OwnerController
        public ActionResult Index()
        {

            var owner = _unitOfWork.OwnerRepo.GetAll();
            return View(owner);
        }

        // GET: OwnerController/Details/5
        public ActionResult Details(int id)
        {
            return View(new Manager());
        }

        // GET: OwnerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OwnerController/Create
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

        // GET: OwnerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OwnerController/Edit/5
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

        // GET: OwnerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OwnerController/Delete/5
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
