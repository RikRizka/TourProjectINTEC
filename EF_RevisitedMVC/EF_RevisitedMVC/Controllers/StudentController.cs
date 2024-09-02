using EF_RevisitedMVC.Data;
using EF_RevisitedMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.CodeDom;
using static NuGet.Packaging.PackagingConstants;

namespace EF_RevisitedMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentContext _context;
        public StudentController(StudentContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index() //unuk mencegah terjadinya crash jika void harus membuat Task
        {
            var student = await _context.Students.ToListAsync();
            return View(student);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            if (ModelState.IsValid)
            {
                //untuk ke data base
                _context.Students.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            var boek = await _context.Students.FirstOrDefaultAsync(m => m.StudentId == id);
            return View(boek);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var boekToDelete = await _context.Students.FindAsync(id);


            _ = _context.Students.Remove(boekToDelete);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var student = await _context.Students.FindAsync(id);
            return View(student);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                await _context.SaveChangesAsync();

            }
            return RedirectToAction("Index");
        }

     
    }
}
