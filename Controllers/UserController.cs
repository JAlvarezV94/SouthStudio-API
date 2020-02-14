using Microsoft.AspNetCore.Mvc;
using SouthStudioBlog.Helpers;
using SouthStudioBlog.Models;
using SouthStudioBlog.Repositories;
using SouthStudioBlog.Wrappers;
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
        [Route("GetUserById")]
        public IActionResult GetUserById(int userId)
        {
            User user = _userRepository.GetUserById(userId);
            user = user == null ? new User() : user;


            ResponseWrapper<User> response = new ResponseWrapper<User>()
            {
                Success = user != null,
                Result = user,
                Message = "Entidad obtenida correctamente.",
            };
            return Json(response);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(User userToUpdate)
        {
            // Validations.
            if (userToUpdate == null)
                return Json(new BaseResponser() { Success = false, Message = "No se han recibido suficientes datos." });

            bool minimumInfoOk = ValidationsHelper.CheckUseMinFields(userToUpdate);
            if(!minimumInfoOk)
                return Json(new BaseResponser() { Success = false, Message = "No se han recibido suficientes datos." });

            // Update user.
            userToUpdate.LastModificationDate = DateTime.Now;
            _userRepository.UpdateUser(userToUpdate);
            _userRepository.Save();

            return Json(new BaseResponser() { Success = false, Message = "Usuario actualizado correctamente." });
        }
    }
}
