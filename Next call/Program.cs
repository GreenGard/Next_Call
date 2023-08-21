using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Next_call.Data;
using Next_call.Services; // Import the CustomerService namespace

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Configuration.AddJsonFile("appsettings.json");

        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        // Add DbContext as a service
        builder.Services.AddDbContext<DataContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        // Add CustomerService as a singleton service
        builder.Services.AddTransient<CustomerService>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}