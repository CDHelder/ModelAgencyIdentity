using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelAgencyIdentity.Areas.Identity.Pages
{
    public class PageOwnerRequirement : IAuthorizationRequirement
    {
    }
}
