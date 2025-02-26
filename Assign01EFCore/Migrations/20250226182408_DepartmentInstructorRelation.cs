using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assign01EFCore.Migrations
{
    /// <inheritdoc />
    public partial class DepartmentInstructorRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "HiringDate",
                table: "Departments",
                newName: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InstructorId",
                table: "Departments",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InstructorId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Departments",
                newName: "HiringDate");
        }
    }
}
