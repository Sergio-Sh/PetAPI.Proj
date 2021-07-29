using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebAPI.Proj.DAL.Entities;
using WebAPI.Proj.DAL.Enums;


namespace WebAPI.Proj.DAL.Context
{
    public class WebDbContext : DbContext
    {
        public WebDbContext(DbContextOptions<WebDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var users = new List<User>()
            {
                new User(){ Id = 1, TeamId = 1, FirstName = "Sergo", LastName= "Shevchuk", Email = "serhiy2002shev@gmail.com", RegisteredAt = new(2021, 6, 3), BirthDay = new DateTime(2002, 2, 19)},
                new User(){ Id = 2, TeamId = 1, FirstName = "Gago", LastName = "Gagoich", Email = "GagoGagoich@gmail.com", RegisteredAt = new(2001, 5, 13), BirthDay = new DateTime(1980, 7, 15)},
                new User(){ Id = 3, TeamId = 2, FirstName = "Gavrulo", LastName = "Vista", Email = "Vista@gmail.com", RegisteredAt = new(2019, 6, 3), BirthDay = new DateTime(2012, 6, 5)}
            };

            var teams = new List<Team>
            {
                new Team(){ Id = 1, Name = "SergoAndGago", CreatedAt = new(2000, 1, 1) },
                new Team(){ Id = 2, Name = "GavruloTeam", CreatedAt = new(1999, 3, 3) }
            };

            var tasks = new List<Task>
            {
                new Task(){ Id = 1, ProjectId = 1, PerformerId = 1, Name ="SergoTask", Description = "do", State = TaskState.InProgress, CreatedAt = new(2021, 7, 1), FinishedAt = new(2021, 7, 3)},
                new Task(){ Id = 2, ProjectId = 2, PerformerId = 2, Name ="GagoTask", Description = "do", State = TaskState.InProgress, CreatedAt = new(2020, 7, 1), FinishedAt = new(2021, 7, 3)},
                new Task(){ Id = 3, ProjectId = 2, PerformerId = 2, Name ="GagoTask", Description = "do", State = TaskState.InProgress, CreatedAt = new(2019, 7, 1), FinishedAt = new(2021, 7, 3)}
            };

            var projects = new List<Project>()
            {
                new Project() { Id = 1, AuthorId = 3, TeamId = 1, Name = "SergoGagoProj", Description = "bestProj", CreatedAt = DateTime.Now.ToString(), Deadline = new DateTime(2021, 7, 3).ToString()},
                new Project() { Id = 2, AuthorId = 1 ,TeamId = 2, Name = "GavruloProj", Description = "bestGavrulo", CreatedAt =  new DateTime(2010, 6, 2).ToString(), Deadline = new DateTime(2021, 7, 3).ToString()}
            };

            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Team>().HasData(teams);
            modelBuilder.Entity<Task>().HasData(tasks);
            modelBuilder.Entity<Project>().HasData(projects);

            base.OnModelCreating(modelBuilder);
        }
    }
}
