using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Neuma.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TopFeature",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopFeature", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TopFeature",
                columns: new[] { "Id", "Description", "Image", "Title" },
                values: new object[,]
                {
                    { 1, "Somos gente que intenta vivir su vida siguiendo lo que Jesús enseñaba y en el camino nos dimos cuenta que era más facil hacerlo entre amigos", "~/images/Nico.jpg", "¿Quienes somos?" },
                    { 2, "Somos gente que intenta vivir su vida siguiendo lo que Jesús enseñaba y en el camino nos dimos cuenta que era más facil hacerlo entre amigos", "~/images/OtraNico.jpg", "¿Porque lo hacemos?" },
                    { 3, "Somos gente que intenta vivir su vida siguiendo lo que Jesús enseñaba y en el camino nos dimos cuenta que era más facil hacerlo entre amigos", "~/images/SomosUno.jpg", "¿Porque lo hacemos?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TopFeature");
        }
    }
}
