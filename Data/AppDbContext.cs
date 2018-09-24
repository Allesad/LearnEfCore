using LearningEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningEFCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ToDo> Todos { get; set; }
    }
}