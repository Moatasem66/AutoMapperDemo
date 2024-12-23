
using AutoMapperDemo.Contracts;
using AutoMapperDemo.Data;
using AutoMapperDemo.Mappings;
using AutoMapperDemo.Services;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AutoMapperDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            /// <summary> Add AutoMapperService to Container </summary>
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddAutoMapper( opt =>
            {
                opt.AddProfile<CustomerMapping>();
                opt.AddProfile<CustomerMapping>();

            });


            builder.Services.AddDbContext<AppDBContext>(
                o => o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                );

            builder.Services.AddScoped<ICustomerService , CustomerService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
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
}
