using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.Model;

namespace RazorPagesSample.Pages.BookList
{
    public class CreateModel : PageModel
    {
        public readonly ApplicationDBContext _db;
        public CreateModel(ApplicationDBContext db)
        {
            _db  =db;
        }
     [BindProperty]
        public Book Book { get; set; }
     
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                object p = await _db.Book.AddAsync(Book);
                //await _db.Book.addasync(Book);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");

                //object p = await _db.Book.addasync(Book);
                //await _db.savechangesasync();
                //return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
