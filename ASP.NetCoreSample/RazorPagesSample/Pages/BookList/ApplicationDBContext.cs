using System;
using System.Threading.Tasks;

namespace RazorPagesSample.Pages.BookList
{
    public class ApplicationDBContext
    {
        public object Book { get; internal set; }

        internal Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}