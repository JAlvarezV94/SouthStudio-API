using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SouthStudioBlog.Models;

namespace SouthStudioBlog.Repositories
{
    public class UserRepository : IUserRepository, IDisposable
    {
        private readonly SSBContext context;

        public UserRepository(SSBContext context)
        {
            this.context = context;
        }

        public User GetUserById(int idUser)
        {
            User user = context.Users.Include(u => u.UserStudyList)
                .Include(u => u.UserJobList)
                .Where(u => u.IdUser == idUser)
                .FirstOrDefault();

            return user;
        }

        public List<User> GetUserList()
        {
            return context.Users.ToList();
        }

        public void InsertUser(User newUser)
        {
            context.Users.Add(newUser);
        }

        public bool CheckCredentials(string user, string password)
        {
            var found = context.Users.Where(u => u.UserEmail == user && u.UserPassword == password).FirstOrDefault();

            return found != null ? true : false;
        }

        public void UpdateUser(User userToUpdate)
        {
            context.Entry(userToUpdate).State = EntityState.Modified;
        }

        public void DeleteUser(int idUser)
        {
            User user = context.Users.Find(idUser);
            context.Users.Remove(user);
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
