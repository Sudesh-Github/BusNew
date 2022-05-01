using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BusNew.Models
{
    public class BusDbContext : DbContext
    {
        public BusDbContext()
            : base("name=conn")
        {

        }

        public DbSet<Bus> Buses { get; set; }
    }
}