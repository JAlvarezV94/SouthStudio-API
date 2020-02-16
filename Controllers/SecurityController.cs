using Microsoft.AspNetCore.Mvc;
using SouthStudioBlog.Helpers;
using SouthStudioBlog.Models;
using SouthStudioBlog.Repositories;
using SouthStudioBlog.Wrappers;

namespace SouthStudioBlog.Controllers
{
    [ApiController]
    [Route("auth")]
    public class SecurityController : Controller
    {

        private readonly UserRepository userRepository;

        public SecurityController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login([FromBody] User user)
        {
            // Validations.
            if (string.IsNullOrEmpty(user.UserEmail) || string.IsNullOrEmpty(user.UserPassword))
                return Json(new BaseResponser { Success = false, Message = "Faltan campos." });

            // Encrypt password.
            var encryptedPass = SecurityHelper.EncryptSHA521(user.UserPassword);

            // Looking for the user in DB.
            var credenialsOk = userRepository.CheckCredentials(user.UserEmail, encryptedPass);
            if (!credenialsOk)
                return Json(new BaseResponser { Success = false, Message = "El usuario o la contraseña no son correctos." });

            // Create a token based on user data.
            var token = SecurityHelper.GenerateToken(user.UserName + user.UserSurname);

            // Return the response.
            return Json(new ResponseWrapper<string> { Success = true, Result = token, Message = "Login correcto." });
        }
    }
}
