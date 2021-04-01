using MVP_Patterns_Practice.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Patterns_Practice.Data
{
    class PaymentContext : DbContext
    {
        public PaymentContext() : base("Payment DB") { }
        public DbSet<Payment> payments { get; set; }
    }
}
