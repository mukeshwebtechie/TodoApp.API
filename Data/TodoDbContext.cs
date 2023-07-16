// TodoDbContext.cs
using Microsoft.EntityFrameworkCore;
using TodoApp.API.Models;

namespace TodoApp.API.Data
{
    public class TodoDbContext : DbContext
    {
        // protected readonly IConfiguration Configuration;

        // public TodoDbContext(IConfiguration configuration)
        // {
        //     Configuration = configuration;
        // }
        public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }


        // protected override void OnConfiguring(DbContextOptionsBuilder options)
        // {
        //     // connect to sql server with connection string from app settings
        //     options.UseSqlServer(Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING"));
        // }
        // public void ConfigureServices(IServiceCollection services)
        // {
        //     services.AddDbContext<TodoDbContext>(options =>
        //         options.UseSqlServer(Configuration.GetConnectionString("BloggingDatabase")));
        // }
    }
}
