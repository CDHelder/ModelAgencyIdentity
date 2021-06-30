using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ModelAgencyIdentity.Data;
using ModelAgencyIdentity.Data.Entities;

namespace ModelAgencyIdentity.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DetailsModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public CustomerUser CustomerUser { get; set; }

        public async Task<IActionResult> OnGetAsync(string? email)
        {
            if (email == null)
            {
                return NotFound();
            }

            CustomerUser = await _context.Customers.FirstOrDefaultAsync(m => m.Email == email);;

            if (CustomerUser == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
