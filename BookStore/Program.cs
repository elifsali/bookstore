using BookStore.BL.Intefaces;
using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using BookStore.DL.NewFolder;
using BookStore.DL.Repositories;
using Microsoft.AspNetCore.Authorization;

namespace BookStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IBookRepository, BookRepository>();
            builder.Services.AddSingleton<IAuthorRepository, AuthorRepository>();

            builder.Services.AddSingleton<IBookService, BookService>();
            builder.Services.AddSingleton<IAuthorService, AuthorService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
