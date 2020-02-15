using Microsoft.EntityFrameworkCore;
using SouthStudioBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Repositories
{
    public class PostRepository : IPostRepository
    {

        private readonly SSBContext context;
        public PostRepository(SSBContext context)
        {
            this.context = context;
        }

        public Post GetPostById(int idPost)
        {
            return context.Posts.Find(idPost);
        }

        public List<Post> GetPostList()
        {
            return context.Posts.ToList();
        }

        public void InsertPost(Post newPost)
        {
            context.Posts.Add(newPost);
        }

        public void UpdatePost(Post postToUpdate)
        {
            context.Entry(postToUpdate).State = EntityState.Modified;
        }

        public void DeletePost(int idPost)
        {
            Post post = context.Posts.Find(idPost);
            context.Posts.Remove(post);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
