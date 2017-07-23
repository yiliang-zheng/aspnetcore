﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DefaultCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DefaultCore.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
            
        }
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Student>().ToTable("Students");
            builder.Entity<Course>().ToTable("Courses");
            builder.Entity<Enrollment>().ToTable("Enrollments");
        }
    }
}
