using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NtierArchitecture.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class LeaveModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Leaves_LeaveId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_LeaveId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "LeaveId",
                table: "Employees");

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeId",
                table: "Leaves",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Leaves_EmployeeId",
                table: "Leaves",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leaves_Employees_EmployeeId",
                table: "Leaves",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leaves_Employees_EmployeeId",
                table: "Leaves");

            migrationBuilder.DropIndex(
                name: "IX_Leaves_EmployeeId",
                table: "Leaves");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Leaves");

            migrationBuilder.AddColumn<Guid>(
                name: "LeaveId",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_LeaveId",
                table: "Employees",
                column: "LeaveId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Leaves_LeaveId",
                table: "Employees",
                column: "LeaveId",
                principalTable: "Leaves",
                principalColumn: "Id");
        }
    }
}
