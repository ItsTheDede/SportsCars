using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace blah.Models
{
    public class MarketPreco
    {
        public int MarketPrecoId { get; set; }
        public float Preconumero { get; set; }
        public ICollection<MarketPlace> MarketPlaces { get; set; } = new List<MarketPlace>();
    }

    public class MarketQtd
    {
        public int MarketQtdId { get; set; }
        public int Qtdnumero { get; set; }
        public ICollection<MarketPlace> MarketPlaces { get; set; } = new List<MarketPlace>();
    }

    public class MarketSubtotal
    {
        public int MarketSubtotalId { get; set; }
        public float Subtotalnumero { get; set; }
        public ICollection<MarketPlace> MarketPlaces { get; set; } = new List<MarketPlace>();
    }

    public class MarketChassi
    {
        public int MarketChassiId { get; set; }
        public int NChassiNumero { get; set; }
        public ICollection<MarketPlace> MarketPlaces { get; set; } = new List<MarketPlace>();
    }

    public class MarketPlace
    {
        public int MarketPlaceId { get; set; }

        public int MarketPrecoId { get; set; }
        public MarketPreco MarketPreco { get; set; } = null!;

        public int MarketQtdId { get; set; }
        public MarketQtd MarketQtd { get; set; } = null!;

        public int MarketSubtotalId { get; set; }
        public MarketSubtotal MarketSubtotal { get; set; } = null!;

        public int MarketChassiId { get; set; }
        public MarketChassi MarketChassi { get; set; } = null!;
    }

    public class SportscarsContext : DbContext
    {
        public SportscarsContext(DbContextOptions<SportscarsContext> options)
            : base(options)
        {
        }

        public DbSet<MarketPlace> MarketPlaces { get; set; }
        public DbSet<MarketPreco> MarketPrecos { get; set; }
        public DbSet<MarketQtd> MarketQtds { get; set; }
        public DbSet<MarketSubtotal> MarketSubtotals { get; set; }
        public DbSet<MarketChassi> MarketChassis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarketPlace>()
                .HasOne(mp => mp.MarketPreco)
                .WithMany(p => p.MarketPlaces)
                .HasForeignKey(mp => mp.MarketPrecoId);

            modelBuilder.Entity<MarketPlace>()
                .HasOne(mp => mp.MarketQtd)
                .WithMany(q => q.MarketPlaces)
                .HasForeignKey(mp => mp.MarketQtdId);

            modelBuilder.Entity<MarketPlace>()
                .HasOne(mp => mp.MarketSubtotal)
                .WithMany(s => s.MarketPlaces)
                .HasForeignKey(mp => mp.MarketSubtotalId);

            modelBuilder.Entity<MarketPlace>()
                .HasOne(mp => mp.MarketChassi)
                .WithMany(c => c.MarketPlaces)
                .HasForeignKey(mp => mp.MarketChassiId);
        }
    }
}
