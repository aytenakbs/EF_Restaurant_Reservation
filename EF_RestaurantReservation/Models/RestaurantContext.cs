using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_RestaurantReservation.Models;
public class RestaurantContext:DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=LAPTOP-SPHGMM2D;Database=RestaurantDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
    public DbSet<Reservation> Reservations { get; set; }
    public DbSet<Menu> Menus { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
}
