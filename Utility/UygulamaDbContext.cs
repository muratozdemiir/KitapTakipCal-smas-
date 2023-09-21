using KitapTakip.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace KitapTakip.Utility;

public class UygulamaDbContext:DbContext 
{
    public DbSet<KitapTuru> KitapTurleri { get; set; }
    public UygulamaDbContext(DbContextOptions<UygulamaDbContext> options) : base(options) { }
}
