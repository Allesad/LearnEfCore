using System.Linq;
using LearningEFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions;

namespace LearningEFCore.Data
{
    public static class DbInit
    {
        public static void InitializeWithFakeData(AppDbContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Contacts.Any())
            {
                context.Contacts.Add(new Contact() { FirstName = "John", LastName = "Smith", Email = "john.smith@email.com"});
                context.Contacts.Add(new Contact() { FirstName = "John", LastName = "Doe", Email = "john.doe@email.com"});
                context.Contacts.Add(new Contact() { FirstName = "Thomas", LastName = "Anderson", Email = "neo@email.com"});
                context.Contacts.Add(new Contact() { FirstName = "Trinity", LastName = "Anderson", Email = "trinity@email.com"});
            }

            if (!context.Todos.Any())
            {
                context.Add(new ToDo { Text = "Task 1", Completed = true });
                context.Add(new ToDo { Text = "Task 2", Completed = false });
                context.Add(new ToDo { Text = "Task 3", Completed = false });
            }

            context.SaveChanges();
        }
    }
}