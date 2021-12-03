using AutoMapper;
using EmailService;
using Entities.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace BaskislaAPI.Controllers
{
    public class AccountController : Controller
    {
        private IMapper _mapper;
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IEmailSender _emailSender;

        public AccountController(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegistrationModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            var user = _mapper.Map<User>(model);

            var result = await _userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
            {
                foreach(var error in result.Errors)
                    ModelState.TryAddModelError(error.Code, error.Description);

                return View(model);
            }

            var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            var confirmLink = Url.Action(nameof(ConfirmEmail), "Account", new { token, email = user.Email }, Request.Scheme);
            var message = new Message(new string[] {user.Email}, "Confirmation email link", confirmLink, null);

            await _emailSender.SendEmailAsync(message);

            await _userManager.AddToRoleAsync(user, "Visitor");
            return RedirectToAction(nameof(SuccessRegistration));
        }

        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return View("Error");

            var result = await _userManager.ConfirmEmailAsync(user, token);
            return View(result.Succeeded ? nameof(ConfirmEmail) : "Error");
        }
        [HttpGet]
        
        public IActionResult Error()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SuccessRegistration()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginModel model, string returnUrl = null)
        {
            if(!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user == null)
            {
                ModelState.AddModelError(String.Empty, "No such user");
                return View();
            }
            var isConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            if(!isConfirmed)
            {
                ModelState.AddModelError(String.Empty, "Email is not confirmed");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
            if (result.Succeeded)
                return RedirectToLocal(returnUrl);
            else
            {
                ModelState.AddModelError(string.Empty, "Invalid username or password");
                return View();
            }
            //var user = await _userManager.FindByEmailAsync(model.Email);
            //if(user != null && await _userManager.CheckPasswordAsync(user, model.Password))
            //{
            //    var identity = new ClaimsIdentity(IdentityConstants.ApplicationScheme);
            //    identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, user.Id));
            //    identity.AddClaim(new Claim(ClaimTypes.Name, user.UserName));

            //    await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme,
            //        new ClaimsPrincipal(identity));

            //    return RedirectToLocal(returnUrl);//RedirectToAction(nameof(HomeController.Index), "Home");
            //}
            //return View();
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if(Url.IsLocalUrl(returnUrl))
                return Redirect(returnUrl);
            else
                return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if(user == null)
                return RedirectToAction(nameof(ForgotPasswordConfirmation));

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action(nameof(ResetPassword), "Account", new { token, email = user.Email }, Request.Scheme);

            var message = new Message(new string[] { user.Email }, "Reset your password", callback, null);
            await _emailSender.SendEmailAsync(message);

            return RedirectToAction(nameof(ForgotPasswordConfirmation));


        }

        [HttpGet]
        public IActionResult ForgotPasswordConfirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ResetPassword(string token, string email)
        {
            var model = new ResetPasswordModel { Token = token, Email = email };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordModel model)
        {
            if(!ModelState.IsValid)
                return View(model);

            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null)
                return RedirectToAction(nameof(ResetPasswordConfirmation));

            var resetPwResult = await _userManager.ResetPasswordAsync(user, model.Token, model.Password);
            if (!resetPwResult.Succeeded)
            {
                foreach(var error in resetPwResult.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return View();
            }

            return RedirectToAction(nameof(ResetPasswordConfirmation));
        }

        [HttpGet]
        public IActionResult ResetPasswordConfirmation()
        {
            return View();
        }
    }
}
