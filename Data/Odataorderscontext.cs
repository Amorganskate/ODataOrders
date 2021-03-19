using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataOrders.Data
{
    public class Odataorderscontext : DbContext
    {
        public Odataorderscontext(DbContextOptions<Odataorderscontext> options)
            :base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
