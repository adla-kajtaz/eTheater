﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eTheater.Services.Database;

#nullable disable

namespace eTheater.Services.Migrations
{
    [DbContext(typeof(ETheaterContext))]
    partial class ETheaterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("eTheater.Services.Database.Hall", b =>
                {
                    b.Property<int>("HallId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HallId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfSeatsPerRow")
                        .HasColumnType("int");

                    b.Property<int?>("TotalRows")
                        .HasColumnType("int");

                    b.Property<int?>("TotalSeats")
                        .HasColumnType("int");

                    b.HasKey("HallId")
                        .HasName("PK__Hall__7E60E21495C08AC1");

                    b.ToTable("Hall", (string)null);

                    b.HasData(
                        new
                        {
                            HallId = 1,
                            CreatedAt = new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            Name = "Mala sala",
                            NumberOfSeatsPerRow = 10,
                            TotalRows = 10,
                            TotalSeats = 100
                        },
                        new
                        {
                            HallId = 2,
                            CreatedAt = new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Local),
                            IsDeleted = false,
                            Name = "Velika sala",
                            NumberOfSeatsPerRow = 15,
                            TotalRows = 10,
                            TotalSeats = 150
                        });
                });

            modelBuilder.Entity("eTheater.Services.Database.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NotificationCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("NotificationId")
                        .HasName("PK__Notifica__20CF2E12A19052D9");

                    b.HasIndex("NotificationCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Notification", (string)null);
                });

            modelBuilder.Entity("eTheater.Services.Database.NotificationCategory", b =>
                {
                    b.Property<int>("NotificationCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationCategoryId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NotificationCategoryId")
                        .HasName("PK__Notifica__C7B551ABC13F63DA");

                    b.ToTable("NotificationCategory", (string)null);
                });

            modelBuilder.Entity("eTheater.Services.Database.Purchase", b =>
                {
                    b.Property<int>("PurchaseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PurchaseId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NumberOfTickets")
                        .HasColumnType("int");

                    b.Property<int?>("TotalPrice")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("PurchaseId")
                        .HasName("PK__Purchase__6B0A6BBED4913846");

                    b.HasIndex("UserId");

                    b.ToTable("Purchase", (string)null);
                });

            modelBuilder.Entity("eTheater.Services.Database.Show", b =>
                {
                    b.Property<int>("ShowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Duration")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShowGenreId")
                        .HasColumnType("int");

                    b.HasKey("ShowId")
                        .HasName("PK__Show__6DE3E0B25CC97D35");

                    b.HasIndex("ShowGenreId");

                    b.ToTable("Show", (string)null);
                });

            modelBuilder.Entity("eTheater.Services.Database.ShowGenre", b =>
                {
                    b.Property<int>("ShowGenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowGenreId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShowGenreId")
                        .HasName("PK__ShowGenr__5D1898B1648F4AFA");

                    b.ToTable("ShowGenre", (string)null);
                });

            modelBuilder.Entity("eTheater.Services.Database.ShowSchedule", b =>
                {
                    b.Property<int>("ShowScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowScheduleId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("HallId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ShowDateTime")
                        .HasColumnType("datetime");

                    b.Property<int?>("ShowId")
                        .HasColumnType("int");

                    b.Property<int?>("TicketPrice")
                        .HasColumnType("int");

                    b.HasKey("ShowScheduleId")
                        .HasName("PK__ShowSche__7C6D43B2380E7A80");

                    b.HasIndex("HallId");

                    b.HasIndex("ShowId");

                    b.ToTable("ShowSchedule", (string)null);
                });

            modelBuilder.Entity("eTheater.Services.Database.TheaterInfo", b =>
                {
                    b.Property<int>("TheaterInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TheaterInfoId"));

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Webpage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TheaterInfoId")
                        .HasName("PK__TheaterI__814E88BD6D5EB47F");

                    b.ToTable("TheaterInfo", (string)null);
                });

            modelBuilder.Entity("eTheater.Services.Database.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit")
                        .HasColumnName("isActive");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumberOfRow")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfSeat")
                        .HasColumnType("int");

                    b.Property<int?>("PurchaseId")
                        .HasColumnType("int");

                    b.Property<string>("Seat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ShowScheduleId")
                        .HasColumnType("int");

                    b.HasKey("TicketId")
                        .HasName("PK__Ticket__712CC6079B969D08");

                    b.HasIndex("PurchaseId");

                    b.HasIndex("ShowScheduleId");

                    b.ToTable("Ticket", (string)null);
                });

            modelBuilder.Entity("eTheater.Services.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("eTheater.Services.Database.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("eTheater.Services.Database.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("eTheater.Services.Database.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("eTheater.Services.Database.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("eTheater.Services.Database.Notification", b =>
                {
                    b.HasOne("eTheater.Services.Database.NotificationCategory", "NotificationCategory")
                        .WithMany("Notifications")
                        .HasForeignKey("NotificationCategoryId")
                        .HasConstraintName("FK__Notificat__Notif__267ABA7A");

                    b.HasOne("eTheater.Services.Database.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId");

                    b.Navigation("NotificationCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eTheater.Services.Database.Purchase", b =>
                {
                    b.HasOne("eTheater.Services.Database.User", "User")
                        .WithMany("Purchases")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("eTheater.Services.Database.Show", b =>
                {
                    b.HasOne("eTheater.Services.Database.ShowGenre", "ShowGenre")
                        .WithMany("Shows")
                        .HasForeignKey("ShowGenreId")
                        .HasConstraintName("FK__Show__ShowGenreI__2D27B809");

                    b.Navigation("ShowGenre");
                });

            modelBuilder.Entity("eTheater.Services.Database.ShowSchedule", b =>
                {
                    b.HasOne("eTheater.Services.Database.Hall", "Hall")
                        .WithMany("ShowSchedules")
                        .HasForeignKey("HallId")
                        .HasConstraintName("FK__ShowSched__HallI__30F848ED");

                    b.HasOne("eTheater.Services.Database.Show", "Show")
                        .WithMany("ShowSchedules")
                        .HasForeignKey("ShowId")
                        .HasConstraintName("FK__ShowSched__ShowI__300424B4");

                    b.Navigation("Hall");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("eTheater.Services.Database.Ticket", b =>
                {
                    b.HasOne("eTheater.Services.Database.Purchase", "Purchase")
                        .WithMany("Tickets")
                        .HasForeignKey("PurchaseId")
                        .HasConstraintName("FK__Ticket__Purchase__36B12243");

                    b.HasOne("eTheater.Services.Database.ShowSchedule", "ShowSchedule")
                        .WithMany("Tickets")
                        .HasForeignKey("ShowScheduleId")
                        .HasConstraintName("FK__Ticket__ShowSche__35BCFE0A");

                    b.Navigation("Purchase");

                    b.Navigation("ShowSchedule");
                });

            modelBuilder.Entity("eTheater.Services.Database.Hall", b =>
                {
                    b.Navigation("ShowSchedules");
                });

            modelBuilder.Entity("eTheater.Services.Database.NotificationCategory", b =>
                {
                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("eTheater.Services.Database.Purchase", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("eTheater.Services.Database.Show", b =>
                {
                    b.Navigation("ShowSchedules");
                });

            modelBuilder.Entity("eTheater.Services.Database.ShowGenre", b =>
                {
                    b.Navigation("Shows");
                });

            modelBuilder.Entity("eTheater.Services.Database.ShowSchedule", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("eTheater.Services.Database.User", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}
