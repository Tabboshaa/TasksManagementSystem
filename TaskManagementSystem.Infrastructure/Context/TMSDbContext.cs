using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using TaskManagementSystem.Core.Entities;

namespace TaskManagementSystem.Infrastructure.Context
{
    public class TMSDbContext : DbContext
    {
        public DbSet<TaskEntity> Tasks { get; set; }
        public TMSDbContext(DbContextOptions<TMSDbContext> options) : base(options)
        {
        }
    }
}
