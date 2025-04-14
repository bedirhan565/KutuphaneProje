using Kutuphane.Models;
using Kutuphane.Data;
using Microsoft.EntityFrameworkCore;
namespace Kutuphane.Data{
public class ApplicationDbContext : DbContext{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Sinif> Siniflar{ get; set; }
    public DbSet<Ogrenci> Ogrenciler {get; set;}
}
}