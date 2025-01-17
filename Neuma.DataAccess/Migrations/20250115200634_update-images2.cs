using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neuma.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updateimages2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TopFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "~/images/OtraNico.jpg");

            migrationBuilder.UpdateData(
                table: "TopFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "~/images/SomosUno.jpg");

            migrationBuilder.UpdateData(
                table: "TopFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "~/images/Nico.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TopFeatures",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "~/images/friends.jpg");

            migrationBuilder.UpdateData(
                table: "TopFeatures",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "~/images/somosuno2.jpg");

            migrationBuilder.UpdateData(
                table: "TopFeatures",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "~/images/cresiendo.jpg");
        }
    }
}
