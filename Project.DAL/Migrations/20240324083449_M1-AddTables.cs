using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class M1AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Owners",
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
                    table.PrimaryKey("PK_Owners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Renters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "buildings",
                columns: table => new
                {
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_buildings", x => x.BuildingId);
                    table.ForeignKey(
                        name: "FK_buildings_Owners_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Floors",
                columns: table => new
                {
                    FloorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FloorNumbr = table.Column<int>(type: "int", nullable: false),
                    FloorType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Floors", x => x.FloorId);
                    table.ForeignKey(
                        name: "FK_Floors_buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "buildings",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Services_buildings_BuildingId",
                        column: x => x.BuildingId,
                        principalTable: "buildings",
                        principalColumn: "BuildingId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Apartments",
                columns: table => new
                {
                    ApartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApartName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false),
                    Rent = table.Column<int>(type: "int", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApartmentStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoolrId = table.Column<int>(type: "int", nullable: false),
                    RenterId = table.Column<int>(type: "int", nullable: false),
                    FloorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apartments", x => x.ApartmentId);
                    table.ForeignKey(
                        name: "FK_Apartments_Floors_FloorId",
                        column: x => x.FloorId,
                        principalTable: "Floors",
                        principalColumn: "FloorId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Apartments_Renters_RenterId",
                        column: x => x.RenterId,
                        principalTable: "Renters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RenterServices",
                columns: table => new
                {
                    RenterId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    ServiceStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RenterServices", x => new { x.RenterId, x.ServiceId });
                    table.ForeignKey(
                        name: "FK_RenterServices_Renters_RenterId",
                        column: x => x.RenterId,
                        principalTable: "Renters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_RenterServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "ServiceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomId);
                    table.ForeignKey(
                        name: "FK_Rooms_Apartments_ApartmentId",
                        column: x => x.ApartmentId,
                        principalTable: "Apartments",
                        principalColumn: "ApartmentId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_FloorId",
                table: "Apartments",
                column: "FloorId");

            migrationBuilder.CreateIndex(
                name: "IX_Apartments_RenterId",
                table: "Apartments",
                column: "RenterId");

            migrationBuilder.CreateIndex(
                name: "IX_buildings_OwnerId",
                table: "buildings",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Floors_BuildingId",
                table: "Floors",
                column: "BuildingId");

            migrationBuilder.CreateIndex(
                name: "IX_RenterServices_ServiceId",
                table: "RenterServices",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_ApartmentId",
                table: "Rooms",
                column: "ApartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_BuildingId",
                table: "Services",
                column: "BuildingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RenterServices");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Apartments");

            migrationBuilder.DropTable(
                name: "Floors");

            migrationBuilder.DropTable(
                name: "Renters");

            migrationBuilder.DropTable(
                name: "buildings");

            migrationBuilder.DropTable(
                name: "Owners");
        }
    }
}
