using Microsoft.EntityFrameworkCore;
using TodoListApp.WebApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TodoListApp.WebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {          
        }

        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<TodoTask> TodoTasks { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TodoList>().HasData(
              new TodoList { Id = 1, Title = "List1", Description = "First List", NumberOfTasks = 0 }
            );

            modelBuilder.Entity<TodoTask>().HasData(
             new TodoTask { Id = 1, Title = "Task1", Description = "First Task", TodoListId=1,  }
           );
        }
    }
}
