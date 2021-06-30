using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ModelAgencyIdentity.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelAgencyIdentity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerUser> Customers { get; set; }
        public DbSet<ModelUser> Models { get; set; }
    }
}
