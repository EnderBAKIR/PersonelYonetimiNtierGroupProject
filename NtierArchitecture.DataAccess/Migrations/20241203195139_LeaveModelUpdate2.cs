using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NtierArchitecture.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class LeaveModelUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Leaves",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Leaves");
        }
    }
}
