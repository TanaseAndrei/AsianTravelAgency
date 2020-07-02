using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AsianTravelAgency.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutUsPostSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true),
                    ImageTitle = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutUsPostSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FAQSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PictureSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureName = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Question = table.Column<string>(nullable: true),
                    ImageName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PriceSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(nullable: true),
                    OnePersonPrice = table.Column<int>(nullable: false),
                    TwoPersonsPrice = table.Column<int>(nullable: false),
                    ThreePersonsPrice = table.Column<int>(nullable: false),
                    SendingWay = table.Column<string>(nullable: true),
                    TicketType = table.Column<string>(nullable: true),
                    Guiding = table.Column<string>(nullable: true),
                    LeavingFrom = table.Column<string>(nullable: true),
                    TripInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    DateOfRegistration = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSet", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutUsPostSet");

            migrationBuilder.DropTable(
                name: "FAQSet");

            migrationBuilder.DropTable(
                name: "PictureSet");

            migrationBuilder.DropTable(
                name: "PostSet");

            migrationBuilder.DropTable(
                name: "PriceSet");

            migrationBuilder.DropTable(
                name: "UserSet");
        }
    }
}
