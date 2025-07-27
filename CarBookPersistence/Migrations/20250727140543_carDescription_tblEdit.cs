using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBookPersistence.Migrations
{
    /// <inheritdoc />
    public partial class carDescription_tblEdit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescriptions_Cars_CarID1",
                table: "CarDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_CarDescriptions_CarID1",
                table: "CarDescriptions");

            migrationBuilder.DropColumn(
                name: "CarID1",
                table: "CarDescriptions");

            migrationBuilder.AlterColumn<int>(
                name: "CarID",
                table: "CarDescriptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_CarDescriptions_CarID",
                table: "CarDescriptions",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions",
                column: "CarID",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarDescriptions_Cars_CarID",
                table: "CarDescriptions");

            migrationBuilder.DropIndex(
                name: "IX_CarDescriptions_CarID",
                table: "CarDescriptions");

            migrationBuilder.AlterColumn<string>(
                name: "CarID",
                table: "CarDescriptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CarID1",
                table: "CarDescriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CarDescriptions_CarID1",
                table: "CarDescriptions",
                column: "CarID1");

            migrationBuilder.AddForeignKey(
                name: "FK_CarDescriptions_Cars_CarID1",
                table: "CarDescriptions",
                column: "CarID1",
                principalTable: "Cars",
                principalColumn: "CarID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
