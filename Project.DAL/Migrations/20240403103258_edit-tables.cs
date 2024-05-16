using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class editTables_AprtRntr_Mngr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartments_Renters_RenterId",
                table: "Apartments");

            migrationBuilder.DropForeignKey(
                name: "FK_buildings_Owners_OwnerId",
                table: "buildings");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropIndex(
                name: "IX_Apartments_RenterId",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "RenterId",
                table: "Apartments");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Services",
                newName: "Description");

            migrationBuilder.AddColumn<int>(
                name: "ApartmentId",
                table: "Renters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Manager",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatsAppNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Renters_ApartmentId",
                table: "Renters",
                column: "ApartmentId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_buildings_Manager_OwnerId",
                table: "buildings",
                column: "OwnerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Renters_Apartments_ApartmentId",
                table: "Renters",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "ApartmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_buildings_Manager_OwnerId",
                table: "buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Renters_Apartments_ApartmentId",
                table: "Renters");

            migrationBuilder.DropTable(
                name: "Manager");

            migrationBuilder.DropIndex(
                name: "IX_Renters_ApartmentId",
                table: "Renters");

            migrationBuilder.DropColumn(
                name: "ApartmentId",
                table: "Renters");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Services",
                newName: "Discription");

            migrationBuilder.AddColumn<int>(
                name: "RenterId",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WhatsAppNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_RenterId",
                table: "Apartments",
                column: "RenterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartments_Renters_RenterId",
                table: "Apartments",
                column: "RenterId",
                principalTable: "Renters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_buildings_Owners_OwnerId",
                table: "buildings",
                column: "OwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
