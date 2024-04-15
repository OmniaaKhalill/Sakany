using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Project.DAL.Entities;
using Project.PL.ViewModels;

namespace Project.PL.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManger;
        private readonly SignInManager<ApplicationUser> _signMangr;

        public AccountController(UserManager<ApplicationUser> userManger, SignInManager<ApplicationUser> signMangr)
        {
            _userManger = userManger;
            _signMangr = signMangr;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel newUserVM)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser userModel = new ApplicationUser();
                userModel.UserName = newUserVM.UserName;
                userModel.PasswordHash = newUserVM.Password;
                //mapp from vm to model
                IdentityResult result= await  _userManger.CreateAsync(userModel, newUserVM.Password);
                if (result.Succeeded)
                {
                    //create cookie
                     await _signMangr.SignInAsync(userModel,false);  // id name role
                    return RedirectToAction("index", "Home");
                }
                else
                {
                    foreach (var err in result.Errors)
                    {
                        ModelState.AddModelError("password", err.Description);
                    }
                   
                }
                //save to db
            }
            return View(newUserVM);
        }


        [HttpGet]
        public IActionResult LogIn()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LoginUserViewModel UserVM)
        {
            if (ModelState.IsValid)
            {
                //checked db user manager
              ApplicationUser user = await  _userManger.FindByNameAsync(UserVM.UserName);
                if (user != null)
                {
                   bool found = await _userManger.CheckPasswordAsync(user, UserVM.Password);
                    if (found==true)
                    {
                        //create cookie
                        await _signMangr.SignInAsync(user,UserVM.RememberMe);
                        return RedirectToAction("index", "Home");

                    }
                }
             
                ModelState.AddModelError("", "user name or password is wrong");
                
            }


            return View(UserVM);

        }



        public async Task< IActionResult> LogOut()
        {
           await _signMangr.SignOutAsync(); // remove cookie

            return RedirectToAction("Register"); // change to login
        }





        }
}
