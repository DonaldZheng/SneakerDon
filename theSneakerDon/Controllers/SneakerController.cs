using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theSneakerDon.Models;

namespace theSneakerDon.Controllers
{
    public class SneakerController : Controller
    {
        private readonly ISneakerRepository _sneakerRepository;
        private readonly ICategoryRepository _categoryRepository;
        public SneakerController(ISneakerRepository sneakerRepository, ICategoryRepository categoryRepository)
        {
            _sneakerRepository = sneakerRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            return View(_sneakerRepository.GetAllSneaker); 
        }

        // GET: SneakerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SneakerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SneakerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SneakerController/Create
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

        // GET: SneakerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SneakerController/Edit/5
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

        // GET: SneakerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SneakerController/Delete/5
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
