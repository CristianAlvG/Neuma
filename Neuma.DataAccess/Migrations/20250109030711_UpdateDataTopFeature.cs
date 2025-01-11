using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neuma.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataTopFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TopFeature",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Porque creemos que solo a traves del verdadero amor podemos encontrar el proposito de nuestra vida");

            migrationBuilder.UpdateData(
                table: "TopFeature",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Neuma no tiene un espacio logico definido porque somos un grupo de amigos", "¿Donde estamos?" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TopFeature",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "Somos gente que intenta vivir su vida siguiendo lo que Jesús enseñaba y en el camino nos dimos cuenta que era más facil hacerlo entre amigos");

            migrationBuilder.UpdateData(
                table: "TopFeature",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Somos gente que intenta vivir su vida siguiendo lo que Jesús enseñaba y en el camino nos dimos cuenta que era más facil hacerlo entre amigos", "¿Porque lo hacemos?" });
        }
    }
}
