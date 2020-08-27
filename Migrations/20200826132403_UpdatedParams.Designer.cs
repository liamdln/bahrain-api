﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bahrain_api.Data;

namespace bahrain_api.Migrations
{
    [DbContext(typeof(ATControllerContext))]
    [Migration("20200826132403_UpdatedParams")]
    partial class UpdatedParams
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("bahrain_api.Models.ATController", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("comments")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("hasSignOff")
                        .HasColumnType("bit");

                    b.Property<string>("networkID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("onSolo")
                        .HasColumnType("bit");

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("varchar(2)")
                        .HasMaxLength(2);

                    b.HasKey("id");

                    b.ToTable("ATControllers");
                });
#pragma warning restore 612, 618
        }
    }
}
