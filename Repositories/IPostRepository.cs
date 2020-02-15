using SouthStudioBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Repositories
{
    interface IPostRepository : IDisposable
    {
        void InsertPost(Post newPost);
        List<Post> GetPostList();
        Post GetPostById(int idPost);
        bool UpdatePost(Post postToUpdate);
        void DeletePost(int idPost);
        void Save();
    }
}
