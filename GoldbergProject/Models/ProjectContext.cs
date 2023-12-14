using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GoldbergProject.Models;

public partial class ProjectContext : DbContext
{
    public ProjectContext()
    {
    }

    public ProjectContext(DbContextOptions<ProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CommunitiesForOrganization> CommunitiesForOrganizations { get; set; }

    public virtual DbSet<Community> Communities { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-24EQMFH;Database=Project;Integrated Security=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CommunitiesForOrganization>(entity =>
        {
            entity.HasKey(e => e.CommunitiesForOrganizationsId).HasName("PK__Communit__7F2D79A1910C4395");

            entity.HasOne(d => d.Community).WithMany(p => p.CommunitiesForOrganizations)
                .HasForeignKey(d => d.CommunityId)
                .HasConstraintName("FK__Communiti__Commu__2C3393D0");

            entity.HasOne(d => d.Organization).WithMany(p => p.CommunitiesForOrganizations)
                .HasForeignKey(d => d.OrganizationId)
                .HasConstraintName("FK__Communiti__Organ__2B3F6F97");
        });

        modelBuilder.Entity<Community>(entity =>
        {
            entity.HasKey(e => e.CommunityId).HasName("PK__Communit__CCAA5B69BF72022A");

            entity.Property(e => e.CommunityName).HasMaxLength(50);
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.ImageId).HasName("PK__Images__7516F70CC6429620");

            entity.Property(e => e.ImageName).HasMaxLength(50);

            entity.HasOne(d => d.ImageOrganization).WithMany(p => p.Images)
                .HasForeignKey(d => d.ImageOrganizationId)
                .HasConstraintName("FK__Images__ImageOrg__286302EC");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity.HasKey(e => e.OrganizationId).HasName("PK__Organiza__CADB0B12A42001EC");

            entity.Property(e => e.ColorOfFirstPart).HasMaxLength(50);
            entity.Property(e => e.ColorOfSecondPart).HasMaxLength(50);
            entity.Property(e => e.ColorOfThirddPart).HasMaxLength(50);
            entity.Property(e => e.OrganizationName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
