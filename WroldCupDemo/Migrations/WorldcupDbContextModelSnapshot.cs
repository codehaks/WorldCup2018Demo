﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldCupDemo.Data;

namespace WorldCupDemo.Migrations
{
    [DbContext(typeof(WorldcupDbContext))]
    partial class WorldcupDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorldCupDemo.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date");

                    b.Property<int>("GoalsA");

                    b.Property<int>("GoalsB");

                    b.Property<int>("Index");

                    b.Property<int>("StadiumId");

                    b.Property<int>("TeamA");

                    b.Property<int>("TeamB");

                    b.HasKey("Id");

                    b.HasIndex("StadiumId");

                    b.ToTable("Match");
                });

            modelBuilder.Entity("WorldCupDemo.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("TeamId");

                    b.Property<int?>("TeamId1");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.HasIndex("TeamId1");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("WorldCupDemo.Models.Stadium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Stadium");
                });

            modelBuilder.Entity("WorldCupDemo.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Appearances");

                    b.Property<int>("Finals");

                    b.Property<string>("GroupName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<byte>("Rank")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Titles");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Teams");

                    b.HasData(
                        new { Id = 1, Appearances = 4, Finals = 0, GroupName = "B", Name = "Iran", Rank = (byte)32, Titles = (byte)0 },
                        new { Id = 2, Appearances = 4, Finals = 0, GroupName = "B", Name = "Morocco", Rank = (byte)40, Titles = (byte)0 }
                    );
                });

            modelBuilder.Entity("WorldCupDemo.Models.Match", b =>
                {
                    b.HasOne("WorldCupDemo.Models.Stadium")
                        .WithMany()
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorldCupDemo.Models.Player", b =>
                {
                    b.HasOne("WorldCupDemo.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorldCupDemo.Models.Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId1");
                });
#pragma warning restore 612, 618
        }
    }
}
