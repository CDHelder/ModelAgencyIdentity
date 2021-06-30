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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<CustomerUser> CustomerUsers { get;set; }

        public void OnGetAsync()
        {
            CustomerUsers =  _context.Customers.Where(customer => customer.AccountState == AccountState.Approved).ToList();
        }
    }
}
