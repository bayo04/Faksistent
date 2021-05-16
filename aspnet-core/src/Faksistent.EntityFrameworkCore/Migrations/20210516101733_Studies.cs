using Microsoft.EntityFrameworkCore.Migrations;

namespace Faksistent.Migrations
{
    public partial class Studies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Faculties",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DurationInSemesters",
                table: "AbpTenants",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "FacultyId",
                table: "AbpTenants",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_FacultyId",
                table: "AbpTenants",
                column: "FacultyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpTenants_Faculties_FacultyId",
                table: "AbpTenants",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpTenants_Faculties_FacultyId",
                table: "AbpTenants");

            migrationBuilder.DropIndex(
                name: "IX_AbpTenants_FacultyId",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "University",
                table: "Faculties");

            migrationBuilder.DropColumn(
                name: "DurationInSemesters",
                table: "AbpTenants");

            migrationBuilder.DropColumn(
                name: "FacultyId",
                table: "AbpTenants");
        }
    }
}
