using Microsoft.AspNetCore.Mvc;
using Project.BLL.Interfaces;


namespace Project.PL.Controllers
{
    public class BuildingController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
       
        public BuildingController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        // GET: BuildingController
        public IActionResult Index()
        {
            

            return View();
        }

        // GET: BuildingController/Details/5
        public IActionResult Details()
        {
           // _unitOfWork.BuildingRepo
            return View();
        }

        // GET: BuildingController/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View(new DAL.Entities.Building());
        }

        // POST: BuildingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IFormCollection collection)
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

        // GET: BuildingController/Edit/5
        public IActionResult Edit(int id)
        {
            return View();
        }

        // POST: BuildingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IFormCollection collection)
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

        // GET: BuildingController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        // POST: BuildingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
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
