using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OtelRezervasyon2.Data.Migrations
{
    public partial class EkleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "kategori",
                columns: table => new
                {
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_kategori", x => x.KategoriId);
                });

            migrationBuilder.CreateTable(
                name: "musteri",
                columns: table => new
                {
                    MusteriId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cinsiyet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_musteri", x => x.MusteriId);
                });

            migrationBuilder.CreateTable(
                name: "OdemeMetodu",
                columns: table => new
                {
                    OdemeMetoduId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Metot = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OdemeMetodu", x => x.OdemeMetoduId);
                });

            migrationBuilder.CreateTable(
                name: "Otel",
                columns: table => new
                {
                    OtelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yildiz = table.Column<int>(type: "int", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    Kapasite = table.Column<int>(type: "int", nullable: false),
                    Sehir = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DenizeUzaklik = table.Column<double>(type: "float", nullable: false),
                    MerkezeUzaklik = table.Column<double>(type: "float", nullable: false),
                    HavaAlaniUzaklik = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Otel", x => x.OtelId);
                    table.ForeignKey(
                        name: "FK_Otel_kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "kategori",
                        principalColumn: "KategoriId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fotograf",
                columns: table => new
                {
                    FotografId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    DosyaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DosyaYolu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fotograf", x => x.FotografId);
                    table.ForeignKey(
                        name: "FK_Fotograf_Otel_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Otel",
                        principalColumn: "OtelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "otelOlanaklari",
                columns: table => new
                {
                    OtelOlanaklariID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtelId = table.Column<int>(type: "int", nullable: false),
                    UcretsizIptal = table.Column<bool>(type: "bit", nullable: false),
                    TumGunServis = table.Column<bool>(type: "bit", nullable: false),
                    WIFI = table.Column<bool>(type: "bit", nullable: false),
                    AlakartRestoran = table.Column<bool>(type: "bit", nullable: false),
                    YikamaServisi = table.Column<bool>(type: "bit", nullable: false),
                    UcretsizOtopark = table.Column<bool>(type: "bit", nullable: false),
                    ToplantıOdasi = table.Column<bool>(type: "bit", nullable: false),
                    LobiBar = table.Column<bool>(type: "bit", nullable: false),
                    HavuzBar = table.Column<bool>(type: "bit", nullable: false),
                    SporSalonu = table.Column<bool>(type: "bit", nullable: false),
                    AcikHavuz = table.Column<bool>(type: "bit", nullable: false),
                    KapaliHavuz = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_otelOlanaklari", x => x.OtelOlanaklariID);
                    table.ForeignKey(
                        name: "FK_otelOlanaklari_Otel_OtelId",
                        column: x => x.OtelId,
                        principalTable: "Otel",
                        principalColumn: "OtelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "otelYorum",
                columns: table => new
                {
                    OtelYorumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OtelId1 = table.Column<int>(type: "int", nullable: false),
                    OtelId = table.Column<int>(type: "int", nullable: false),
                    Yorum = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Yildiz = table.Column<int>(type: "int", nullable: false),
                    Durum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_otelYorum", x => x.OtelYorumId);
                    table.ForeignKey(
                        name: "FK_otelYorum_musteri_OtelId",
                        column: x => x.OtelId,
                        principalTable: "musteri",
                        principalColumn: "MusteriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_otelYorum_Otel_OtelId1",
                        column: x => x.OtelId1,
                        principalTable: "Otel",
                        principalColumn: "OtelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rezervasyon",
                columns: table => new
                {
                    RezervasyonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MusteriId1 = table.Column<int>(type: "int", nullable: false),
                    MusteriId = table.Column<int>(type: "int", nullable: false),
                    YetiskinSayisi = table.Column<int>(type: "int", nullable: false),
                    CocukSayisi = table.Column<int>(type: "int", nullable: false),
                    GirisTar = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CikisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RezervasyonTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToplamUcret = table.Column<double>(type: "float", nullable: false),
                    Onay = table.Column<bool>(type: "bit", nullable: false),
                    durum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rezervasyon", x => x.RezervasyonId);
                    table.ForeignKey(
                        name: "FK_Rezervasyon_musteri_MusteriId1",
                        column: x => x.MusteriId1,
                        principalTable: "musteri",
                        principalColumn: "MusteriId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rezervasyon_Otel_MusteriId",
                        column: x => x.MusteriId,
                        principalTable: "Otel",
                        principalColumn: "OtelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RezervasyonOdeme",
                columns: table => new
                {
                    RezervasyonOdemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RezervasyonId = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<double>(type: "float", nullable: false),
                    ToplamUcret = table.Column<double>(type: "float", nullable: false),
                    MetotOdemeMetoduId = table.Column<int>(type: "int", nullable: false),
                    KartNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SonKullanmaTarihi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CVV = table.Column<int>(type: "int", nullable: false),
                    durum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RezervasyonOdeme", x => x.RezervasyonOdemeId);
                    table.ForeignKey(
                        name: "FK_RezervasyonOdeme_OdemeMetodu_MetotOdemeMetoduId",
                        column: x => x.MetotOdemeMetoduId,
                        principalTable: "OdemeMetodu",
                        principalColumn: "OdemeMetoduId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RezervasyonOdeme_Rezervasyon_RezervasyonId",
                        column: x => x.RezervasyonId,
                        principalTable: "Rezervasyon",
                        principalColumn: "RezervasyonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fotograf_KategoriId",
                table: "Fotograf",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Otel_KategoriId",
                table: "Otel",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_otelOlanaklari_OtelId",
                table: "otelOlanaklari",
                column: "OtelId");

            migrationBuilder.CreateIndex(
                name: "IX_otelYorum_OtelId",
                table: "otelYorum",
                column: "OtelId");

            migrationBuilder.CreateIndex(
                name: "IX_otelYorum_OtelId1",
                table: "otelYorum",
                column: "OtelId1");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyon_MusteriId",
                table: "Rezervasyon",
                column: "MusteriId");

            migrationBuilder.CreateIndex(
                name: "IX_Rezervasyon_MusteriId1",
                table: "Rezervasyon",
                column: "MusteriId1");

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonOdeme_MetotOdemeMetoduId",
                table: "RezervasyonOdeme",
                column: "MetotOdemeMetoduId");

            migrationBuilder.CreateIndex(
                name: "IX_RezervasyonOdeme_RezervasyonId",
                table: "RezervasyonOdeme",
                column: "RezervasyonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fotograf");

            migrationBuilder.DropTable(
                name: "otelOlanaklari");

            migrationBuilder.DropTable(
                name: "otelYorum");

            migrationBuilder.DropTable(
                name: "RezervasyonOdeme");

            migrationBuilder.DropTable(
                name: "OdemeMetodu");

            migrationBuilder.DropTable(
                name: "Rezervasyon");

            migrationBuilder.DropTable(
                name: "musteri");

            migrationBuilder.DropTable(
                name: "Otel");

            migrationBuilder.DropTable(
                name: "kategori");
        }
    }
}
