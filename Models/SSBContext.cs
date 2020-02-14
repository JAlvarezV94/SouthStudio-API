using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SouthStudioBlog.Models
{
    public class SSBContext : DbContext
    {
        public SSBContext(DbContextOptions<SSBContext> options)
            : base(options)
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Study> Studies { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Post> Posts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            User user = new User
            {
                IdUser = 1,
                UserName = "Jose",
                UserSurname = "Álvarez Vivar",
                UserAka = "JNoma",
                UserDescription = "Pruebecita que te crió!",
                UserBirthday = new DateTime(1994, 9, 25),
                LastModificationDate = null,
                LeavingDate = null,
            };

            Study[] studies = new Study[]
            {
                new Study
                {
                    IdStudy = 1,
                    StudyTitle = "Técnico en Administración de Sistemas Microinformáticos y Redes",
                    StudyCenter = "I.E.S. Belén",
                    StudyStartDate = new DateTime(2011,9,10),
                    StudyEndDate = new DateTime(2014, 12, 31),
                    StudyDescription = "Ciclo formativo de grado medio en administración de sistemas microinformaáticos y redes.",
                    UserIdUser = 1,
                    LastModificationDate = null,
                    LeavingDate = null,
                },
                new Study
                {
                    IdStudy = 2,
                    StudyTitle = "Técnico en Desarrollo de Aplicaciones Multiplataforma",
                    StudyCenter = "Cenec Málaga",
                    StudyStartDate = new DateTime(2015, 10, 10),
                    StudyEndDate = new DateTime(2017, 6, 23),
                    StudyDescription = "Ciclo formativo de grado superior en desarrollo de aplicaciones multiplataforma.",
                    UserIdUser = 1,
                    LastModificationDate = null,
                    LeavingDate = null,
                }
            };
            Job[] jobs = new Job[]
            {
                new Job
                {
                    IdJob = 1,
                    JobPosition = "Desarrollador Android",
                    JobCompany = "Prodigia Consultores",
                    JobDescription = "Desarrollador de aplicaciones móviles en Android nativo.",
                    JobStartDate = new DateTime(2017, 3, 20),
                    JobEndDate = new DateTime(2017, 6, 20),
                    UserIdUser = 1,
                    LastModificationDate = null,
                    LeavingDate = null,
                },
                new Job
                {
                    IdJob = 2,
                    JobPosition = "Desarrollador Android",
                    JobCompany = "iUrban.es",
                    JobDescription = "Desarrollador de aplicaciones móviles en Android nativo.",
                    JobStartDate = new DateTime(2017, 12, 10),
                    JobEndDate = new DateTime(2019, 1, 15),
                    UserIdUser = 1,
                    LastModificationDate = null,
                    LeavingDate = null,
                },
                new Job
                {
                    IdJob = 3,
                    JobPosition = "Desarrollador .Net",
                    JobCompany = "TYM Soluciones",
                    JobDescription = "Desarrollador de aplicaciones web en .Net Framework.",
                    JobStartDate = new DateTime(2019, 3, 19),
                    UserIdUser = 1,
                    LastModificationDate = null,
                    LeavingDate = null,
                }
            };

            builder.Entity<User>().HasData(user);

            builder.Entity<Study>().HasData(studies);
            builder.Entity<Job>().HasData(jobs);
        }
    }
}
