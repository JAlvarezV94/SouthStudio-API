using SouthStudioBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Helpers
{
    public static class ValidationsHelper
    {
        public static bool CheckUseMinFields(User user)
        {
            return user.IdUser > 0 &&
                !string.IsNullOrEmpty(user.UserName) &&
                !string.IsNullOrEmpty(user.UserSurname) &&
                !string.IsNullOrEmpty(user.UserDescription) &&
                user.UserBirthday != null;
        }
    }
}
