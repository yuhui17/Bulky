using BulkyBookWebRazor_Temp.Data;
using BulkyBookWebRazor_Temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyBookWebRazor_Temp.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {

        private readonly ApplicationDbContext _db;
        public Category? Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int? categoryId)
        {
            if(categoryId != null)
            {
                Category = _db.Categories.Find(categoryId);
            }
        }

        public IActionResult OnPost()
        {
            if(Category != null)
            {
                _db.Categories.Remove(Category);
                _db.SaveChanges();
                TempData["success"] = "Category deleted successfully!";
            }

            return RedirectToPage("Index");
        }
    }
}
