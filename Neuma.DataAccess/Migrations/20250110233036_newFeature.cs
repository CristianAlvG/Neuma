using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neuma.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class newFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TopFeature",
                columns: new[] { "Id", "Description", "Image", "Title" },
                values: new object[] { 4, "Neuma no tiene un espacio logico definido porque somos un grupo de amigos", "~/images/SomosUno.jpg", "¿Donde estamos?" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TopFeature",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
