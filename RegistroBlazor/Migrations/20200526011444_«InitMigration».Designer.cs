﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistroBlazor.DAL;

namespace RegistroBlazor.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200526011444_«InitMigration»")]
    partial class InitMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4");

            modelBuilder.Entity("RegistroBlazor.Models.Notas", b =>
                {
                    b.Property<int>("notasId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("importancia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ruta")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("notasId");

                    b.ToTable("Notas");
                });
#pragma warning restore 612, 618
        }
    }
}
