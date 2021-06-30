using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModelAgencyIdentity.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAgencyIdentity.Data.Configuration
{
    public class CustomerUserConfiguration : IEntityTypeConfiguration<CustomerUser>
    {
        public void Configure(EntityTypeBuilder<CustomerUser> builder)
        {
            builder.HasData(
                new CustomerUser
                {
                    UserName = "Henk",
                    BTW = "123456789JWZ",
                    Country = "Nederland",
                    Email = "GekkeHenk@gmail.com",
                    KvK = "987654321JWZ",
                    Name = "Henk",
                    PhoneNumber = "06123456789",
                    PostalCode = "4201 GG",
                    StreetAddress = "Sesamstraat 12",
                    AccountState = AccountState.Approved

                },
                new CustomerUser
                {
                    UserName = "Jaap",
                    BTW = "67891234JWZ",
                    Country = "Nederland",
                    Email = "Jaapie@gmail.com",
                    KvK = "12341234JWZ",
                    Name = "Jaap",
                    PhoneNumber = "06987654312",
                    PostalCode = "6969 TR",
                    StreetAddress = "Zwaluwstraat 12",
                    AccountState = AccountState.Approved
                    
                });
        }
    }
}
