using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelAgencyIdentity.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAgencyIdentity.Data.Configuration
{
    public class ModelUserConfiguration : IEntityTypeConfiguration<ModelUser>
    {
        public void Configure(EntityTypeBuilder<ModelUser> builder)
        {
            builder.HasData(
                new ModelUser
                {
                    Country = "Nederland",
                    DOB = DateTime.Today,
                    Email = "Therese@gmail.com",
                    Name = "Therese",
                    PhoneNumber = "0645671234",
                    PostalCode = "8844 JG",
                    StreetAddress = "Ruwinastraat 69",
                    UserName = "Therese"
                },
                new ModelUser
                {
                    Country = "Nederland",
                    DOB = DateTime.Today,
                    Email = "Peter@gmail.com",
                    Name = "Peter",
                    PhoneNumber = "0678901234",
                    PostalCode = "3456 JG",
                    StreetAddress = "Gekkestraat 420",
                    UserName = "Peter"
                });
        }
    }
}
