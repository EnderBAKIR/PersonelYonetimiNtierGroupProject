using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NtierArchitecture.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SalartTrackingUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PayCheckDay",
                table: "SalaryTracking");

            migrationBuilder.AddColumn<int>(
                name: "PaymentMonth",
                table: "SalaryTracking",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentYear",
                table: "SalaryTracking",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentMonth",
                table: "SalaryTracking");

            migrationBuilder.DropColumn(
                name: "PaymentYear",
                table: "SalaryTracking");

            migrationBuilder.AddColumn<int>(
                name: "PayCheckDay",
                table: "SalaryTracking",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
