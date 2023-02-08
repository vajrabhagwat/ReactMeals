using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ReactMeals.Models;

public partial class ReactMealsContext : DbContext
{
    public ReactMealsContext()
    {
    }

    public ReactMealsContext(DbContextOptions<ReactMealsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Catalog> Catalogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=HJ-TTBTTD13930;Initial Catalog=ReactMeals;Integrated Security=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Catalog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Catalog__3214EC07D34B13D6");

            entity.ToTable("Catalog");

            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
