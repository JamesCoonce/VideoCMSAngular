using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using VideoCMSAngular.Models;
using VideoCMSAngular.Areas.Admin.Models.UserViewModels;
using VideoCMSAngular.Data;

namespace VideoCMSAngular.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UsersController : Controller
    {
        private UserManager<ApplicationUser> _userManager;

        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context,
            UserManager<ApplicationUser> userMgr)
        {
            _context = context;
            _userManager = userMgr;
        }
        [HttpGet]
        [Route("/users")]
        public IEnumerable<ProfileViewModel> GetUsers()
        {
            var users = _userManager.Users;
            var profiles = ProfileViewModel.GetUserProfiles(_userManager.Users);
            return profiles;
        }


    }
}