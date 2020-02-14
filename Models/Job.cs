using System;
using System.ComponentModel.DataAnnotations;

namespace SouthStudioBlog.Models
{

    /// <summary>
    /// Model for Job table entity.
    /// </summary>
    public class Job
    {

        [Key]
        public int IdJob { get; set; }

        public string JobPosition { get; set; }

        public string JobCompany { get; set; }

        public string JobDescription { get; set; }

        public DateTime JobStartDate { get; set; }

        public DateTime JobEndDate { get; set; }

        public DateTime? LastModificationDate { get; set; }

        /// <summary>
        /// Variable for soft deletion in database.
        /// </summary>
        public DateTime? LeavingDate { get; set; }

        public int UserIdUser { get; set; }
    }
}
