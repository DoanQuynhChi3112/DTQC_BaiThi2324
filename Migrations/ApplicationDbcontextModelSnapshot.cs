﻿// <auto-generated />
using System;
using DTQC_BaiThi2324.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DTQC_BaiThi2324.Migrations
{
    [DbContext(typeof(ApplicationDbcontext))]
    partial class ApplicationDbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("DTQC_BaiThi2324.Models.DTQC114Employee", b =>
                {
                    b.HasBaseType("DTQC_BaiThi2324.Models.DTQC114Person");

                    b.ToTable("DTQC114Employee");
                });

            modelBuilder.Entity("DTQC_BaiThi2324.Models.DTQC114Student", b =>
                {
                    b.HasBaseType("DTQC_BaiThi2324.Models.DTQC114Person");

                    b.ToTable("DTQC114Student");
                });

            modelBuilder.Entity("DTQC_BaiThi2324.Models.DTQC114Employee", b =>
                {
                    b.HasOne("DTQC_BaiThi2324.Models.DTQC114Person", null)
                        .WithOne()
                        .HasForeignKey("DTQC_BaiThi2324.Models.DTQC114Employee", "DTQC114PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
