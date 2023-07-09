using JobForm.Data;
using JobForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace JobForm.Controllers
{
    public class FormRequirementController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FormRequirementController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<FormRequirement> objFormList = _context.FormRequirements;
            return View(objFormList);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(FormRequirement obj)
        {
            if(ModelState.IsValid)
            {
                _context.FormRequirements.Add(obj);
                _context.SaveChanges();
                TempData["success"] = "Form field created successfully";
               
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var form = _context.FormRequirements.Find(id);
            if (form == null)
            {
                return NotFound();
            }
            return View(form);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FormRequirement obj)
        {
            if (ModelState.IsValid)
            {
                _context.FormRequirements.Update(obj);
                _context.SaveChanges();
                TempData["success"] = "Form field edited successfully";

                return RedirectToAction("Index");
            }
            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();  
            }
            var form = _context.FormRequirements.Find(id);
            if(form == null)
            {
                return NotFound();
            }
            return View(form);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            var form = _context.FormRequirements.Find(id);
            if(form == null)
            {
                return NotFound();
            }
            _context.FormRequirements.Remove(form);
            _context.SaveChanges();
            TempData["success"] = "Form field deleted successfully";

            return RedirectToAction("Index");
        }
    }
}
