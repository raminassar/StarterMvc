﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using StarterMvc.Web.Core.Models;
using StarterMvc.Web.Core.ViewModels;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;


namespace StarterMvc.Web.Controllers
{
    public class UsersProfileController : Controller
    {
        public UsersProfileController()
        {

        }
        public UsersProfileController(ApplicationUserManager userManager)
        {
            UserManager = userManager;
        }

        private ApplicationUserManager _userManager;
        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }
        // GET: UsersProfile
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ManageAccountViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await UserManager.FindByIdAsync(User.Identity.GetUserId<int>());

            if (user != null)
            {
                await SignInAsync(user, isPersistent: false);
                model.FirstName = user.Profile.FirstName;
                model.LastName = user.Profile.LastName;
                model.Theme = user.Profile.Theme;
                model.UserPhoto = user.Profile.UserPhoto;
            }

            return View(model);
        }

        private async Task SignInAsync(ApplicationUser user, bool isPersistent)
        {
            AuthenticationManager.SignOut(DefaultAuthenticationTypes.ExternalCookie, DefaultAuthenticationTypes.TwoFactorCookie);
            AuthenticationManager.SignIn(new AuthenticationProperties { IsPersistent = isPersistent }, await user.GenerateUserIdentityAsync(UserManager));
        }

        private IAuthenticationManager AuthenticationManager
        {
            get
            {
                return HttpContext.GetOwinContext().Authentication;
            }
        }
    }
}