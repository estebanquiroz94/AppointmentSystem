using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppointmentSystem.DataAccess.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointment",
                columns: table => new
                {
                    AppointmentId = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointment", x => x.AppointmentId);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    DoctorId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.DoctorId);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatientId = table.Column<Guid>(nullable: false),
                    Document = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "AppointmentDetail",
                columns: table => new
                {
                    AppointmentDetailId = table.Column<Guid>(nullable: false),
                    AppointmentId = table.Column<Guid>(nullable: false),
                    PatientId = table.Column<Guid>(nullable: false),
                    DoctorId = table.Column<Guid>(nullable: false),
                    ConsultingRoom = table.Column<int>(nullable: false),
                    Diagnostic = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppointmentDetail", x => x.AppointmentDetailId);
                    table.ForeignKey(
                        name: "FK_AppointmentDetail_Appointment_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointment",
                        principalColumn: "AppointmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentDetail_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppointmentDetail_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetail_AppointmentId",
                table: "AppointmentDetail",
                column: "AppointmentId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetail_DoctorId",
                table: "AppointmentDetail",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_AppointmentDetail_PatientId",
                table: "AppointmentDetail",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppointmentDetail");

            migrationBuilder.DropTable(
                name: "Appointment");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
