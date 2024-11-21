using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCar.Models;


namespace WebCar.Data
{
    public class CarroContext : DbContext
    {
        public CarroContext(DbContextOptions<CarroContext> options) : base(options)
        {
        }

        public DbSet<VendasModel> Vendas { get; set; }

    }
}