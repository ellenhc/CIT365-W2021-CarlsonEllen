﻿using System;
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

        public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Books { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ScriptureBook { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of books in the scriptures.
            IQueryable<string> bookQuery = from x in _context.Scripture
                                            orderby x.Title
                                            select x.Title;

            var scriptures = from x in _context.Scripture
                             select x;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(ScriptureBook))
            {
                scriptures = scriptures.Where(x => x.Title == ScriptureBook);
            }
            Books = new SelectList(await bookQuery.Distinct().ToListAsync());

            Scripture = await scriptures.ToListAsync();
        }
    }
}
