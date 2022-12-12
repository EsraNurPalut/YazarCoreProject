using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1_added_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminUserName = table.Column<string>(maxLength: 50, nullable: true),
                    AdminPassword = table.Column<string>(maxLength: 50, nullable: true),
                    AdminRole = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminID);
                });

            migrationBuilder.CreateTable(
                name: "Belges",
                columns: table => new
                {
                    BelgeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BelgeAd = table.Column<string>(nullable: true),
                    BelgeIcerik = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Belges", x => x.BelgeID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 50, nullable: true),
                    UserPassword = table.Column<string>(maxLength: 50, nullable: true),
                    UserRole = table.Column<string>(maxLength: 1, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlars",
                columns: table => new
                {
                    YazarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YazarAdSoyad = table.Column<string>(maxLength: 50, nullable: false),
                    YazarMail = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlars", x => x.YazarID);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplars",
                columns: table => new
                {
                    KitapID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KitapAd = table.Column<string>(maxLength: 50, nullable: false),
                    KitapBasimYili = table.Column<string>(maxLength: 4, nullable: true),
                    YazarID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kitaplars", x => x.KitapID);
                    table.ForeignKey(
                        name: "FK_Kitaplars_Yazarlars_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazarlars",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yayinevleris",
                columns: table => new
                {
                    YayineviID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YayineviAd = table.Column<string>(maxLength: 50, nullable: false),
                    YayineviAdres = table.Column<string>(maxLength: 50, nullable: true),
                    YazarID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayinevleris", x => x.YayineviID);
                    table.ForeignKey(
                        name: "FK_Yayinevleris_Yazarlars_YazarID",
                        column: x => x.YazarID,
                        principalTable: "Yazarlars",
                        principalColumn: "YazarID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplars_YazarID",
                table: "Kitaplars",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_Yayinevleris_YazarID",
                table: "Yayinevleris",
                column: "YazarID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Belges");

            migrationBuilder.DropTable(
                name: "Kitaplars");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Yayinevleris");

            migrationBuilder.DropTable(
                name: "Yazarlars");
        }
    }
}
