﻿using Microsoft.EntityFrameworkCore;
using MyAppModel.Models;

namespace MyApp.DataAccessLayer.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
    }
}
