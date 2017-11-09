using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoCMSAngular.Models
{
    public enum SubscriptionStatus
    {
        Free, Cancelled, Subscribed
    }

    public class ApplicationUser : IdentityUser
    {
        public SubscriptionStatus Subscription { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
