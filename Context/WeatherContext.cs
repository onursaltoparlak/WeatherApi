﻿using Microsoft.EntityFrameworkCore;
using Project6_ApiWeather.Entities;

namespace Project6_ApiWeather.Context
{
    public class WeatherContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0AOKHL4\\SQLEXPRESS;Initial Catalog=Db6Project20;Integrated Security=true;TrustServerCertificate=true");

        }

        public DbSet<City> Cities { get; set; }
    }
}
