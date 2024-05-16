using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.BLL.Interfaces;
using Project.DAL.Entities;
using System.Diagnostics;

namespace Project.PL.Controllers
{
    public class ManagerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public ManagerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: OwnerController
        public IActionResult Index()
        {

            var manager = _unitOfWork.ManagerRepo.GetAll();
            return View(manager);
        }

        // GET: OwnerController/Details/5
        public IActionResult Details(Manager manager)
        {
            var mngr = _unitOfWork.ManagerRepo.GetById(manager.Id);

            return View(mngr);
        }

        // GET: OwnerController/Create
        public IActionResult Create()
        {
            return View(new Manager());
        }

        // POST: OwnerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Manager mngr)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    
                    var dublicatedId = _unitOfWork.ManagerRepo.GetById(mngr.Id);
                    if (dublicatedId != null)
                    {
                        ModelState.AddModelError("Manger", "Manger already exists.");
                        return View(mngr);
                    }
                    _unitOfWork.ManagerRepo.Add(mngr);

                    TempData["Message"] = "Manger Created Successfully!!";

                    return RedirectToAction("Details",mngr);
                }
                catch (DbUpdateException ex)
                {
                    var innerException = ex.InnerException;
                    Debug.WriteLine(innerException);
                }
            }
            return View(mngr);
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
