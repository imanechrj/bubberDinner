﻿using BubberDinner.Application;
using BubberDinner.Infrastructure;

namespace BuberDinner.WebApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        {
            builder.Services
                .AddApplication()
                .AddInfrastructure(builder.Configuration);

            builder.Services.AddControllers();

        }

        var app = builder.Build();
        {
            app.UseHttpsRedirection();
            app.MapControllers();
            app.Run();
        }
    }
}

