using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Leave_Management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Leave_History> LeaveHistories { get; set; }
        public DbSet<Leave_Type> LeaveTypes { get; set; }
        public DbSet<Leave_Allocation> LeaveAllocations { get; set; }
    }
}
