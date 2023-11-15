using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eTheater.Services.Database;

public partial class ETheaterContext : IdentityDbContext<User, IdentityRole<int>, int>
{
    private IServiceProvider _serviceProvider;
  
    public ETheaterContext(DbContextOptions<ETheaterContext> options, IServiceProvider serviceProvider)
        : base(options)
    {
        _serviceProvider = serviceProvider;
    }

    public virtual DbSet<Hall> Halls { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<Show> Shows { get; set; }

    public virtual DbSet<ShowSchedule> ShowSchedules { get; set; }

    public virtual DbSet<TheaterInfo> TheaterInfos { get; set; }

    public virtual DbSet<Ticket> Tickets { get; set; }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<ShowActor> ShowActors { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer("Server=DESKTOP-2PVVE49\\MSSQLSERVER_OLAP;Database=eTheater;Trusted_Connection=True; TrustServerCertificate=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Hall>(entity =>
        {
            entity.HasKey(e => e.HallId).HasName("PK__Hall__7E60E21495C08AC1");

            entity.ToTable("Hall");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.NotificationId).HasName("PK__Notifica__20CF2E12A19052D9");

            entity.ToTable("Notification");
        });

       

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasKey(e => e.PurchaseId).HasName("PK__Purchase__6B0A6BBED4913846");

            entity.ToTable("Purchase");
        });

        modelBuilder.Entity<Show>(entity =>
        {
            entity.HasKey(e => e.ShowId).HasName("PK__Show__6DE3E0B25CC97D35");

            entity.ToTable("Show");
        });

        

        modelBuilder.Entity<ShowSchedule>(entity =>
        {
            entity.HasKey(e => e.ShowScheduleId).HasName("PK__ShowSche__7C6D43B2380E7A80");

            entity.ToTable("ShowSchedule");

            entity.Property(e => e.ShowDate).HasColumnType("datetime");

            entity.HasOne(d => d.Hall).WithMany(p => p.ShowSchedules)
                .HasForeignKey(d => d.HallId)
                .HasConstraintName("FK__ShowSched__HallI__30F848ED");

            entity.HasOne(d => d.Show).WithMany(p => p.ShowSchedules)
                .HasForeignKey(d => d.ShowId)
                .HasConstraintName("FK__ShowSched__ShowI__300424B4");
        });

        modelBuilder.Entity<TheaterInfo>(entity =>
        {
            entity.HasKey(e => e.TheaterInfoId).HasName("PK__TheaterI__814E88BD6D5EB47F");

            entity.ToTable("TheaterInfo");
        });

        modelBuilder.Entity<Ticket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__Ticket__712CC6079B969D08");

            entity.ToTable("Ticket");

            entity.Property(e => e.IsActive).HasColumnName("isActive");

            entity.HasOne(d => d.Purchase).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.PurchaseId)
                .HasConstraintName("FK__Ticket__Purchase__36B12243");

            entity.HasOne(d => d.ShowSchedule).WithMany(p => p.Tickets)
                .HasForeignKey(d => d.ShowScheduleId)
                .HasConstraintName("FK__Ticket__ShowSche__35BCFE0A");
        });

        OnModelCreatingPartial(modelBuilder);
        base.OnModelCreating(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
