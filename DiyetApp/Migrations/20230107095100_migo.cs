using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiyetApp.Migrations
{
    public partial class migo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adminler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminAd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adminler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAd = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cinsiyet = table.Column<bool>(type: "bit", nullable: false),
                    Yas = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kilo = table.Column<int>(type: "int", nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    GizliYanit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BesinPorsiyonlar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Porsiyon = table.Column<int>(type: "int", nullable: false),
                    Kalori = table.Column<int>(type: "int", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinPorsiyonlar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BesinPorsiyonlar_Kategoriler_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategoriler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UyeYemekler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Zaman = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UyeId = table.Column<int>(type: "int", nullable: false),
                    BesinId = table.Column<int>(type: "int", nullable: false),
                    OgunId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UyeYemekler", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UyeYemekler_BesinPorsiyonlar_BesinId",
                        column: x => x.BesinId,
                        principalTable: "BesinPorsiyonlar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UyeYemekler_Ogunler_OgunId",
                        column: x => x.OgunId,
                        principalTable: "Ogunler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UyeYemekler_Uyeler_UyeId",
                        column: x => x.UyeId,
                        principalTable: "Uyeler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "Id", "OgunAd" },
                values: new object[] { 1, "Sabah" });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "Id", "OgunAd" },
                values: new object[] { 2, "Öğle" });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "Id", "OgunAd" },
                values: new object[] { 3, "Akşam" });

            migrationBuilder.CreateIndex(
                name: "IX_BesinPorsiyonlar_KategoriId",
                table: "BesinPorsiyonlar",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_UyeYemekler_BesinId",
                table: "UyeYemekler",
                column: "BesinId");

            migrationBuilder.CreateIndex(
                name: "IX_UyeYemekler_OgunId",
                table: "UyeYemekler",
                column: "OgunId");

            migrationBuilder.CreateIndex(
                name: "IX_UyeYemekler_UyeId",
                table: "UyeYemekler",
                column: "UyeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adminler");

            migrationBuilder.DropTable(
                name: "UyeYemekler");

            migrationBuilder.DropTable(
                name: "BesinPorsiyonlar");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
