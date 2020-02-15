using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SouthStudioBlog.Models
{
    /// <summary>
    /// Model for Post table entity.
    /// </summary>
    public class Post
    {
        [Key]
        public int IdPost { get; set; }

        public string PostTitle { get; set; }

        public string PostContent { get; set; }

        public List<string> PostImages { get; set; }

        public int UserIdUser { get; set; }

        public DateTime PostCreationDate { get; set; }

        public DateTime? LastModificationDate { get; set; }

        /// <summary>
        /// Variable for soft deletion in database.
        /// </summary>
        public DateTime? LeavingDate { get; set; }
    }
}
