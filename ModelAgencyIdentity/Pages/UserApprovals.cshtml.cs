using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ModelAgencyIdentity.Data;
using ModelAgencyIdentity.Data.Entities;

namespace ModelAgencyIdentity.Pages
{
    [Authorize(Policy = "PageOwner")]
    public class UserApprovalsModel : PageModel
    {
        private readonly ApplicationDbContext dbContext;

        public UserApprovalsModel(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<ApplicationUser> Users { get; set; }

        public void OnGet()
        {
            Users = dbContext.Users.Where(user => user.AccountState == AccountState.Pending).ToList();
        }
    }
}
