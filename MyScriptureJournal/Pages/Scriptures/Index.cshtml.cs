using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

        // Constructor below
        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public string BookSort { get; set; }
        public string DateSort { get; set; }

        public IList<Scripture> Scripture { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            BookSort = String.IsNullOrEmpty(sortOrder) ? "book_desc" : "";
            DateSort = sortOrder == "Date" ? "date_desc" : "Date";
            IQueryable<Scripture> scripturesIQ = from x in _context.Scripture
                                                 select x;
            switch (sortOrder)
            {
                case "book_desc":
                    scripturesIQ = scripturesIQ.OrderByDescending(x => x.Book);
                    break;
                case "Date":
                    scripturesIQ = scripturesIQ.OrderBy(x => x.DateAdded);
                    break;
                case "date_desc":
                    scripturesIQ = scripturesIQ.OrderByDescending(x => x.DateAdded);
                    break;
                default:
                    scripturesIQ = scripturesIQ.OrderBy(x => x.Book);
                    break;
            }

            // Use LINQ to get list of books.
            IQueryable<string> genreQuery = from x in _context.Scripture
                                            orderby x.Book
                                            select x.Book;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scripturesIQ = scripturesIQ.Where(s => s.Note.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scripturesIQ = scripturesIQ.Where(x => x.Book == ScriptureBook);
            }

            Scripture = await scripturesIQ.AsNoTracking().ToListAsync();
            Books = new SelectList(await genreQuery.Distinct().ToListAsync());
            //Scripture = await scriptures.ToListAsync();
        }
    }
}
