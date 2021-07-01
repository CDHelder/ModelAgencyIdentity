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

        public IActionResult OnPostApprove(string email)
        {
            var user = dbContext.Users.First(user => user.Email == email);
            if (user != null)
            {
                user.AccountState = AccountState.Approved;
                dbContext.SaveChanges();
            }

            return LocalRedirect("/UserApprovals");
        }

        public IActionResult OnPostReject(string email)
        {
            var user = dbContext.Users.First(user => user.Email == email);
            if (user != null)
            {
                user.AccountState = AccountState.Rejected;
                dbContext.SaveChanges();
            }

            return LocalRedirect("/UserApprovals");
        }
    }
}
