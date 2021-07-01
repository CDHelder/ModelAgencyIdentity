using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ModelAgencyIdentity.Data;
using ModelAgencyIdentity.Data.Entities;

namespace ModelAgencyIdentity.Pages.Models
{
    [Authorize(Policy = "ApprovedUsers")]
    public class IndexModel : PageModel
    {
        
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<ModelUser> ModelUsers { get;set; }

        public void OnGetAsync()
        {
            ModelUsers = _context.Models.Where(customer => customer.AccountState == AccountState.Approved).ToList();
        }
    }
}
