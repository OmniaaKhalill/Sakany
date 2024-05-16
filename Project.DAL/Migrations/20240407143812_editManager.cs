using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class editManager : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buildings_Manager_OwnerId",
                table: "buildings");

            migrationBuilder.DropIndex(
                name: "IX_buildings_OwnerId",
                table: "buildings");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "buildings",
                newName: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_buildings_ManagerId",
                table: "buildings",
                column: "ManagerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_buildings_Manager_ManagerId",
                table: "buildings",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buildings_Manager_ManagerId",
                table: "buildings");

            migrationBuilder.DropIndex(
                name: "IX_buildings_ManagerId",
                table: "buildings");

            migrationBuilder.RenameColumn(
                name: "ManagerId",
                table: "buildings",
                newName: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_buildings_OwnerId",
                table: "buildings",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_buildings_Manager_OwnerId",
                table: "buildings",
                column: "OwnerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
