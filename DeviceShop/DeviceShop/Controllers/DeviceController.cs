using DeviceShop.Core;
using DeviceShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace DeviceShop.Controllers
{
 
    public class DeviceController : Controller
    {
        // GET: DeviceController
        private readonly DeviceShopContext _context;

        public DeviceController(DeviceShopContext context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            List<Device> devices = _context.Devices.ToList();
            return View(devices);
        }

        // GET: DeviceController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DeviceController/Create
        

        // GET: DeviceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DeviceController/Edit/5
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
     
        

        // GET: DeviceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.Devices.Find(id));
        }

        // POST: DeviceController/Delete/5
        [HttpPost]
     
        
        public ActionResult Delete(int? id)
        {
            _context.Devices.Remove(_context.Devices.Find(id));
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public IActionResult Detail(int id)
        {
            if (id == null) return NotFound();

            var device = _context.Devices
                .FirstOrDefault(x => x.DeviceId == id);
            if(device == null) return NotFound();
            return View(device);
        }

        
        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Device device)
        {

            _context.Add(device);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
