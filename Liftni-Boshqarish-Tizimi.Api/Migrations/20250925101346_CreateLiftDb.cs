//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: Liftni_Boshqarish_Tizimi.Api
//===================================================

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Liftni_Boshqarish_Tizimi.Api.Migrations
{
    /// <inheritdoc />
    public partial class CreateLiftDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElevatorStates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CurrentFloor = table.Column<int>(type: "integer", nullable: false),
                    Direction = table.Column<int>(type: "integer", nullable: false),
                    IsBusy = table.Column<bool>(type: "boolean", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElevatorStates", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElevatorStates");
        }
    }
}
