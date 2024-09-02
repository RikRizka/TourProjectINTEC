using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyTestAplicationMVCEnTity.Data;
using MyTestAplicationMVCEnTity.Models;

namespace MyTestAplicationMVCEnTity.Controllers
{
    public class PetsController : Controller
    {
        private readonly PetsContext _context;
        public PetsController(PetsContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var pet = await _context.Pets.ToListAsync();
            return View(pet);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(Pets pets)
        {
            var petsenToDelet = await _context.Pets.FirstOrDefaultAsync(m => m.PetsId == pets.PetsId);
            return View(petsenToDelet);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(Pets pets)
        {
            var petsenToDelet = await _context.Pets.FindAsync(pets.PetsId);
            _context.Pets.Remove(petsenToDelet);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
