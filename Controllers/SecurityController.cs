using Microsoft.AspNetCore.Mvc;
using SouthStudioBlog.Helpers;
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
        public IActionResult Login(string user, string password)
        {
            // Validations.
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(password))
                return Json(new BaseResponser { Success = false, Message = "Faltan campos." });

            // Encrypting password.
            var encryptedPass = SecurityHelper.EncryptSHA521(password);

            // Looking for the user in DB.
            var credenialsOk = userRepository.CheckCredentials(user, encryptedPass);
            if (!credenialsOk)
                return Json(new BaseResponser { Success = false, Message = "El usuario o la contraseña no son correctos." });

            // Creating a token based on user data.


            // Returning the response.

            return null;
        }
    }
}
