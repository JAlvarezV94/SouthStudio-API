using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Wrappers
{
    public class ResponseWrapper<T>
    {
        public bool Success { get; set; }

        public T Result { get; set; }

        public string Message { get; set; }
    }
}
