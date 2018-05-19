﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WorldCupDemo.Data;

namespace WorldCupDemo.Migrations
{
    [DbContext(typeof(WorldcupDbContext))]
    [Migration("20180519214549_PlayerInfoOneToOne01")]
    partial class PlayerInfoOneToOne01
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorldCupDemo.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("Number");

                    b.Property<int>("TeamId");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");

                    b.HasData(
                        new { Id = 1, Name = "Sardar", Number = 0, TeamId = 1 },
                        new { Id = 2, Name = "Karim", Number = 0, TeamId = 1 }
                    );
                });

            modelBuilder.Entity("WorldCupDemo.Models.PlayerInfo", b =>
                {
                    b.Property<int>("PlayerInfoId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("PlayerId");

                    b.HasKey("PlayerInfoId");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("PlayersInfo");
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

            modelBuilder.Entity("WorldCupDemo.Models.Player", b =>
                {
                    b.HasOne("WorldCupDemo.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorldCupDemo.Models.PlayerInfo", b =>
                {
                    b.HasOne("WorldCupDemo.Models.Player", "Player")
                        .WithOne("PlayerInfo")
                        .HasForeignKey("WorldCupDemo.Models.PlayerInfo", "PlayerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
