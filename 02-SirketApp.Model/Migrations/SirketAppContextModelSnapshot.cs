﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _02_SirketApp.Model.Model;

#nullable disable

namespace _02_SirketApp.Model.Migrations
{
    [DbContext(typeof(SirketAppContext))]
    partial class SirketAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_01_SirketApi.Entity.Entity.Birim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BirimAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Birims");
                });

            modelBuilder.Entity("_01_SirketApi.Entity.Entity.Cocuk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cinsiyet")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("IlId")
                        .HasColumnType("int");

                    b.Property<int>("IlceId")
                        .HasColumnType("int");

                    b.Property<int>("PersonelId")
                        .HasColumnType("int");

                    b.Property<string>("Soyadi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cocuks");
                });

            modelBuilder.Entity("_01_SirketApi.Entity.Entity.Gorevlendirme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("PersonelNo")
                        .HasColumnType("int");

                    b.Property<int>("ProjeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Gorevlendirmes");
                });

            modelBuilder.Entity("_01_SirketApi.Entity.Entity.Il", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IlAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ils");
                });

            modelBuilder.Entity("_01_SirketApi.Entity.Entity.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("IlId")
                        .HasColumnType("int");

                    b.Property<int>("IlceAdi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Ilces");
                });

            modelBuilder.Entity("_01_SirketApi.Entity.Entity.Personel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BirimNo")
                        .HasColumnType("int");

                    b.Property<byte>("CalismaSaati")
                        .HasColumnType("tinyint");

                    b.Property<decimal>("Maas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Prim")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UnvanNo")
                        .HasColumnType("int");

                    b.Property<DateTime>("baslamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("dogumTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("_01_SirketApi.Entity.Entity.Proje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ProjeAdi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProjeBitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ProjeTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Projes");
                });

            modelBuilder.Entity("_01_SirketApi.Entity.Entity.Unvan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("UnvanAdi")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Unvans");
                });
#pragma warning restore 612, 618
        }
    }
}
