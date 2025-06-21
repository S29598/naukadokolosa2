using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APDB_Kolokwium_template.Migrations
{
    /// <inheritdoc />
    public partial class Wiadomosc123456789 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Budget = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursPerWeek = table.Column<int>(type: "int", nullable: false),
                    AssignmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignment_Assignment_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignment",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Assignment_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Assignment_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Position", "Salary" },
                values: new object[,]
                {
                    { 1, "anna.kowalska@example.eu", "Anna", "Kowalska", "Senior Developer", 10000m },
                    { 2, "tomasz.kot@example.eu", "Tomasz", "Kot", "Service Desk", 5000m }
                });

            migrationBuilder.InsertData(
                table: "Project",
                columns: new[] { "Id", "Budget", "Description", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, 150000m, "Opis", new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "System CRM", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 250000m, "Opis 2", new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "System ABC", new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Assignment",
                columns: new[] { "Id", "AssignmentDate", "AssignmentId", "EmployeeId", "HoursPerWeek", "ProjectId" },
                values: new object[] { 1, new DateTime(2024, 10, 1, 9, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 0, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_AssignmentId",
                table: "Assignment",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_EmployeeId",
                table: "Assignment",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignment_ProjectId",
                table: "Assignment",
                column: "ProjectId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Project");
        }
    }
}
