using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Models
{
    public class Study
    {
        [Key]
        public int IdStudy { get; set; }

        public string StudyTitle { get; set; }

        public DateTime StudyStartDate { get; set; }

        public DateTime StudyEndDate { get; set; }

        public string StudyDescription { get; set; }

        public string StudyCenter { get; set; }

        public DateTime LastModificationDate { get; set; }

        /// <summary>
        /// Variable for soft deletion in database.
        /// </summary>
        public DateTime LeavingDate { get; set; }
    }
}
