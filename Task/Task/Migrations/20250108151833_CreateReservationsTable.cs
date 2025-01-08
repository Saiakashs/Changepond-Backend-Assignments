using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task.Migrations
{
    /// <inheritdoc />
    public partial class CreateReservationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation");

            migrationBuilder.RenameTable(
                name: "Reservation",
                newName: "Reservations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Reservations",
                table: "Reservations");

            migrationBuilder.RenameTable(
                name: "Reservations",
                newName: "Reservation");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reservation",
                table: "Reservation",
                column: "Id");
        }
    }
}
