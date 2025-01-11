using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Neuma.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addingToDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TopFeature",
                table: "TopFeature");

            migrationBuilder.RenameTable(
                name: "TopFeature",
                newName: "TopFeatures");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "User",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Photo",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TopFeatures",
                table: "TopFeatures",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TopFeatures",
                table: "TopFeatures");

            migrationBuilder.DropColumn(
                name: "Area",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "User");

            migrationBuilder.RenameTable(
                name: "TopFeatures",
                newName: "TopFeature");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TopFeature",
                table: "TopFeature",
                column: "Id");
        }
    }
}
