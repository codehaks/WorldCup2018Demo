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
    [Migration("20180519124552_RemoveSemifinalsFromTeams")]
    partial class RemoveSemifinalsFromTeams
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rc1-32029")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorldCupDemo.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Appearances");

                    b.Property<int>("Finals");

                    b.Property<string>("GroupName");

                    b.Property<string>("Name");

                    b.Property<int>("Rank");

                    b.Property<int>("Titles");

                    b.HasKey("Id");

                    b.ToTable("Teams");

                    b.HasData(
                        new { Id = 1, Appearances = 4, Finals = 0, GroupName = "B", Name = "Iran", Rank = 32, Titles = 0 },
                        new { Id = 2, Appearances = 4, Finals = 0, GroupName = "B", Name = "Morocco", Rank = 40, Titles = 0 }
                    );
                });
#pragma warning restore 612, 618
        }
    }
}
