using Microsoft.AspNetCore.Mvc;
using SouthStudioBlog.Models;
using SouthStudioBlog.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly UserRepository _userRepository;
        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("getuserbyid")]
        public IActionResult GetUserById(int userId)
        {
            User user = _userRepository.GetUserById(userId);
            user = user == null ? new User() : user;

            return Json(user);
        }
    }
}
