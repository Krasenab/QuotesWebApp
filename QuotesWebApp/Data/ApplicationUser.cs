﻿using Microsoft.AspNetCore.Identity;

namespace QuotesWebApp.Data
{
    public class ApplicationUser:IdentityUser<Guid>
    {
        public ApplicationUser()
        {
                   
        }

        public List<Comment> Comments { get; set; }
    }
}
