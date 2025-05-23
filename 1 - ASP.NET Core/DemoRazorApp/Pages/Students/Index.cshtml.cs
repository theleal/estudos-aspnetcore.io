﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemoRazorApp.Data;
using DemoRazorApp.Models;

namespace DemoRazorApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly DemoRazorApp.Data.ApplicationDbContext _context;

        public IndexModel(DemoRazorApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Student != null)
            {
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
