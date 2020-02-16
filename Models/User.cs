using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SouthStudioBlog.Models
{
    /// <summary>
    /// Model for User table entity.
    /// </summary>
    public class User
    {
        [Key]
        public int IdUser { get; set; }

        public string UserName { get; set; }

        public string UserSurname { get; set; }

        public string UserAka { get; set; }

        public DateTime UserBirthday { get; set; }

        public string UserDescription { get; set; }

        public string UserPassword { get; set; }

        public string UserEmail { get; set; }

        public List<Study> UserStudyList { get; set; }

        public List<Job> UserJobList { get; set; }

        public List<Post> UserPostList { get; set; }

        public DateTime? LastModificationDate { get; set; }

        /// <summary>
        /// Variable for soft deletion in database.
        /// </summary>
        public DateTime? LeavingDate { get; set; }
    }
}
