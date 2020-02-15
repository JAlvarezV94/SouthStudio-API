using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Wrappers
{
    /// <summary>
    /// This class is a response class to manage API responses.
    /// </summary>
    /// <typeparam name="T">The type of the object contained in Result property.</typeparam>
    public class ResponseWrapper<T>
    {
        /// <summary>
        /// Indicates if the operation went well or wrong.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// The object required by the request.
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// A message that explain the result of the operation.
        /// </summary>
        public string Message { get; set; }
    }
}
