using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cwiczenia_6_zadania11.Migrations
{
    public partial class addData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "IdDoctor", "Email", "FirstName", "LastName" },
                values: new object[] { 1, "feredekKiepski@gmail.com", "Ferdek", "Kiepski" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "IdPatient", "BirthDate", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2020, 6, 6, 10, 39, 25, 229, DateTimeKind.Local).AddTicks(1567), "Marian", "Pazdzioch" });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "IdPrescription", "Date", "DueDate", "IdDoctor", "IdPatient" },
                values: new object[] { 1, new DateTime(2020, 6, 6, 10, 39, 25, 233, DateTimeKind.Local).AddTicks(3930), new DateTime(2020, 6, 8, 10, 39, 25, 233, DateTimeKind.Local).AddTicks(4811), 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "IdDoctor",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1);
        }
    }
}
