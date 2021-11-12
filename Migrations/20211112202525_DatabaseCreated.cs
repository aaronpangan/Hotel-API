using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_API.Migrations
{
    public partial class DatabaseCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Country_CountryModel",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_CountryModel",
                table: "Hotel");

            migrationBuilder.DropColumn(
                name: "CountryModel",
                table: "Hotel");

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CountryId",
                table: "Hotel",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Country_CountryId",
                table: "Hotel",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hotel_Country_CountryId",
                table: "Hotel");

            migrationBuilder.DropIndex(
                name: "IX_Hotel_CountryId",
                table: "Hotel");

            migrationBuilder.AddColumn<int>(
                name: "CountryModel",
                table: "Hotel",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hotel_CountryModel",
                table: "Hotel",
                column: "CountryModel");

            migrationBuilder.AddForeignKey(
                name: "FK_Hotel_Country_CountryModel",
                table: "Hotel",
                column: "CountryModel",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
