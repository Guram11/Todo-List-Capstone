using Microsoft.EntityFrameworkCore;
using TodoListApp.Services;
using TodoListApp.Services.Database;

namespace TodoListApp.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        _ = builder.Services.AddControllers();
        _ = builder.Services.AddEndpointsApiExplorer();
        _ = builder.Services.AddSwaggerGen();
        _ = builder.Services.AddDbContext<TodoListDbContext>(options =>
        {
            _ = options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
        _ = builder.Services.AddScoped<ITodoListService, TodoListDatabaseService>();
        _ = builder.Services.AddScoped<ITodoTaskService, TodoTaskDatabaseService>();
        _ = builder.Services.AddControllersWithViews().AddNewtonsoftJson();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            _ = app.UseSwagger();
            _ = app.UseSwaggerUI();
        }

        _ = app.UseHttpsRedirection();

        _ = app.UseAuthorization();


        _ = app.MapControllers();

        app.Run();
    }
}
