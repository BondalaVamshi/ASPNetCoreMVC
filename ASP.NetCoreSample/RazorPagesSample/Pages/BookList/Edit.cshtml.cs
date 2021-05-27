using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesSample.Model;

namespace RazorPagesSample.Pages.BookList
{
    public class EditModel : PageModel
    {
        public ApplicationDBContext _db;
        public EditModel(ApplicationDBContext db)
        {
            _db = db;
        }
        public Book Book { get; set; }
        public async Task OnGet(int Bookid) => Book = await _db.Book.FindAsync(Bookid);
    }
}
