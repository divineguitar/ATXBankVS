using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ATXBank.Models;

namespace ATXBank.Data
{
    public class ATXBankContext : DbContext
    {
        public ATXBankContext (DbContextOptions<ATXBankContext> options)
            : base(options)
        {
            Database.EnsureCreated();

        }

        public DbSet<ATXBank.Models.Employee> Employee { get; set; }
    }
}
