using DbConfigLib;
using Microsoft.EntityFrameworkCore;

namespace EF_NavigationProperty.Models;

public class DB : DbContext
{
    public DbSet<Person> TablePersons { get; set; }
    public DbSet<Student> TableStudents { get; set; }

    public DB()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(DbConfig.ImportFromJson("db.json").ToString());
    }
}