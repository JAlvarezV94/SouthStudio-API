using Microsoft.AspNetCore.Mvc;
using SouthStudioBlog.Helpers;
using SouthStudioBlog.Models;
using SouthStudioBlog.Repositories;
using SouthStudioBlog.Wrappers;
using System;

namespace SouthStudioBlog.Controllers
{
    [Route("api/{controller}")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly PostRepository postRepository;

        public PostController(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
     
        [HttpPost]
        public IActionResult Post(Post post)
        {
            // Validations.
            if (post == null)
                return Json(new BaseResponser { Success = false, Message = "El post no puede estar vacío." });

            bool mandatoryFieldOk = ValidationsHelper.CheckPostMinFields(post);
            if (!mandatoryFieldOk)
                return Json(new BaseResponser { Success = false, Message = "El post no contiene los datos minimos." });

            // Create the post.
            post.PostCreationDate = DateTime.Now;
            postRepository.InsertPost(post);
            postRepository.Save();
            
            return Json(new BaseResponser { Success = true, Message = "El post ha sido guardado." });
        }


    }
}
