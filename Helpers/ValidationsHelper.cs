using SouthStudioBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Helpers
{
    public static class ValidationsHelper
    {
        /// <summary>
        /// Validate if the user contains the mandatory fields.
        /// </summary>
        /// <param name="user">Object User.</param>
        /// <returns>Boolean.</returns>
        public static bool CheckUserMinFields(User user)
        {
            return user.IdUser > 0 &&
                !string.IsNullOrEmpty(user.UserName) &&
                !string.IsNullOrEmpty(user.UserSurname) &&
                !string.IsNullOrEmpty(user.UserDescription) &&
                user.UserBirthday != null;
        }

        /// <summary>
        /// Validate if the post contains the mandatory fields.
        /// </summary>
        /// <param name="post">Object Post.</param>
        /// <returns>Boolean.</returns>
        public static bool CheckPostMinFields(Post post)
        {
            return post.UserIdUser > 0 &&
                !string.IsNullOrEmpty(post.PostTitle) &&
                !string.IsNullOrEmpty(post.PostContent) &&
                post.PostImages.Count > 0;
        }
    }
}
