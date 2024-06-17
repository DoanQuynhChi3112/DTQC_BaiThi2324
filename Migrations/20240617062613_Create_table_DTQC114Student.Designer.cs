﻿// <auto-generated />
using System;
using DTQC_BaiThi2324.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DTQC_BaiThi2324.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    [Migration("20240617062613_Create_table_DTQC114Student")]
    partial class Create_table_DTQC114Student
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.6");

            modelBuilder.Entity("DTQC_BaiThi2324.Models.DTQC114Person", b =>
                {
                    b.Property<string>("DTQC114PersonID")
                        .HasColumnType("TEXT");

                    b.Property<int>("DTQC114Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DTQC114Ngaysinh")
                        .HasColumnType("TEXT");

                    b.HasKey("DTQC114PersonID");

                    b.ToTable("DTQC114Person");

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("DTQC_BaiThi2324.Models.DTQC114Student", b =>
                {
                    b.HasBaseType("DTQC_BaiThi2324.Models.DTQC114Person");

                    b.ToTable("DTQC114Student");
                });

            modelBuilder.Entity("DTQC_BaiThi2324.Models.DTQC114Student", b =>
                {
                    b.HasOne("DTQC_BaiThi2324.Models.DTQC114Person", null)
                        .WithOne()
                        .HasForeignKey("DTQC_BaiThi2324.Models.DTQC114Student", "DTQC114PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}