using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using bazar_prg.Models;

namespace bazar_prg.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

     public DbSet<Cliente> DataCliente { get; set; }
     public DbSet<Productos> DataProducto { get; set; }
    public DbSet<Proforma> DataProforma { get; set; }

}
