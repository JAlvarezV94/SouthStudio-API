using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Wrappers
{
    /// <summary>
    /// This class is a base responser for the API returns.
    /// </summary>
    public class BaseResponser
    {
        /// <summary>
        /// Indicates if the operation went well or wrong.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// A message that explain the result of the operation.
        /// </summary>
        public string Message { get; set; }
    }
}
