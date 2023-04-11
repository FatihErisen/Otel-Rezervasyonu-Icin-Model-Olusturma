﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OtelRezervasyon2.Data;

#nullable disable

namespace OtelRezervasyon2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.Fotograf", b =>
                {
                    b.Property<int>("FotografId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FotografId"), 1L, 1);

                    b.Property<string>("DosyaAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DosyaYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.HasKey("FotografId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Fotograf");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriId"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KategoriId");

                    b.ToTable("kategori");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.Musteri", b =>
                {
                    b.Property<int>("MusteriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MusteriId"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EPosta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yas")
                        .HasColumnType("int");

                    b.Property<int>("cinsiyet")
                        .HasColumnType("int");

                    b.HasKey("MusteriId");

                    b.ToTable("musteri");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.OdemeMetodu", b =>
                {
                    b.Property<int>("OdemeMetoduId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OdemeMetoduId"), 1L, 1);

                    b.Property<int>("Metot")
                        .HasColumnType("int");

                    b.HasKey("OdemeMetoduId");

                    b.ToTable("OdemeMetodu");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.Otel", b =>
                {
                    b.Property<int>("OtelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtelId"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("DenizeUzaklik")
                        .HasColumnType("float");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("HavaAlaniUzaklik")
                        .HasColumnType("float");

                    b.Property<string>("Ilce")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kapasite")
                        .HasColumnType("int");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<double>("MerkezeUzaklik")
                        .HasColumnType("float");

                    b.Property<string>("Sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yildiz")
                        .HasColumnType("int");

                    b.HasKey("OtelId");

                    b.HasIndex("KategoriId");

                    b.ToTable("Otel");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.OtelOlanaklari", b =>
                {
                    b.Property<int>("OtelOlanaklariID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtelOlanaklariID"), 1L, 1);

                    b.Property<bool>("AcikHavuz")
                        .HasColumnType("bit");

                    b.Property<bool>("AlakartRestoran")
                        .HasColumnType("bit");

                    b.Property<bool>("HavuzBar")
                        .HasColumnType("bit");

                    b.Property<bool>("KapaliHavuz")
                        .HasColumnType("bit");

                    b.Property<bool>("LobiBar")
                        .HasColumnType("bit");

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.Property<bool>("SporSalonu")
                        .HasColumnType("bit");

                    b.Property<bool>("ToplantıOdasi")
                        .HasColumnType("bit");

                    b.Property<bool>("TumGunServis")
                        .HasColumnType("bit");

                    b.Property<bool>("UcretsizIptal")
                        .HasColumnType("bit");

                    b.Property<bool>("UcretsizOtopark")
                        .HasColumnType("bit");

                    b.Property<bool>("WIFI")
                        .HasColumnType("bit");

                    b.Property<bool>("YikamaServisi")
                        .HasColumnType("bit");

                    b.HasKey("OtelOlanaklariID");

                    b.HasIndex("OtelId");

                    b.ToTable("otelOlanaklari");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.OtelYorum", b =>
                {
                    b.Property<int>("OtelYorumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OtelYorumId"), 1L, 1);

                    b.Property<int>("Durum")
                        .HasColumnType("int");

                    b.Property<int>("OtelId")
                        .HasColumnType("int");

                    b.Property<int>("OtelId1")
                        .HasColumnType("int");

                    b.Property<int>("Yildiz")
                        .HasColumnType("int");

                    b.Property<string>("Yorum")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OtelYorumId");

                    b.HasIndex("OtelId");

                    b.HasIndex("OtelId1");

                    b.ToTable("otelYorum");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.Rezervasyon", b =>
                {
                    b.Property<int>("RezervasyonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RezervasyonId"), 1L, 1);

                    b.Property<DateTime>("CikisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("CocukSayisi")
                        .HasColumnType("int");

                    b.Property<DateTime>("GirisTar")
                        .HasColumnType("datetime2");

                    b.Property<int>("MusteriId")
                        .HasColumnType("int");

                    b.Property<int>("MusteriId1")
                        .HasColumnType("int");

                    b.Property<bool>("Onay")
                        .HasColumnType("bit");

                    b.Property<DateTime>("RezervasyonTarihi")
                        .HasColumnType("datetime2");

                    b.Property<double>("ToplamUcret")
                        .HasColumnType("float");

                    b.Property<int>("YetiskinSayisi")
                        .HasColumnType("int");

                    b.Property<int>("durum")
                        .HasColumnType("int");

                    b.HasKey("RezervasyonId");

                    b.HasIndex("MusteriId");

                    b.HasIndex("MusteriId1");

                    b.ToTable("Rezervasyon");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.RezervasyonOdeme", b =>
                {
                    b.Property<int>("RezervasyonOdemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RezervasyonOdemeId"), 1L, 1);

                    b.Property<int>("CVV")
                        .HasColumnType("int");

                    b.Property<double>("Fiyat")
                        .HasColumnType("float");

                    b.Property<string>("KartNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MetotOdemeMetoduId")
                        .HasColumnType("int");

                    b.Property<int>("RezervasyonId")
                        .HasColumnType("int");

                    b.Property<string>("SonKullanmaTarihi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ToplamUcret")
                        .HasColumnType("float");

                    b.Property<int>("durum")
                        .HasColumnType("int");

                    b.HasKey("RezervasyonOdemeId");

                    b.HasIndex("MetotOdemeMetoduId");

                    b.HasIndex("RezervasyonId");

                    b.ToTable("RezervasyonOdeme");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.Fotograf", b =>
                {
                    b.HasOne("OtelRezervasyon2.Models.Otel", "otel")
                        .WithMany("Foto")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("otel");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.Otel", b =>
                {
                    b.HasOne("OtelRezervasyon2.Models.Kategori", "Kategori")
                        .WithMany()
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.OtelOlanaklari", b =>
                {
                    b.HasOne("OtelRezervasyon2.Models.Otel", "Otel")
                        .WithMany()
                        .HasForeignKey("OtelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Otel");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.OtelYorum", b =>
                {
                    b.HasOne("OtelRezervasyon2.Models.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("OtelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelRezervasyon2.Models.Otel", "Otel")
                        .WithMany()
                        .HasForeignKey("OtelId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");

                    b.Navigation("Otel");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.Rezervasyon", b =>
                {
                    b.HasOne("OtelRezervasyon2.Models.Otel", "Otel")
                        .WithMany()
                        .HasForeignKey("MusteriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelRezervasyon2.Models.Musteri", "Musteri")
                        .WithMany()
                        .HasForeignKey("MusteriId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Musteri");

                    b.Navigation("Otel");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.RezervasyonOdeme", b =>
                {
                    b.HasOne("OtelRezervasyon2.Models.OdemeMetodu", "Metot")
                        .WithMany()
                        .HasForeignKey("MetotOdemeMetoduId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OtelRezervasyon2.Models.Rezervasyon", "Rezervasyon")
                        .WithMany()
                        .HasForeignKey("RezervasyonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Metot");

                    b.Navigation("Rezervasyon");
                });

            modelBuilder.Entity("OtelRezervasyon2.Models.Otel", b =>
                {
                    b.Navigation("Foto");
                });
#pragma warning restore 612, 618
        }
    }
}