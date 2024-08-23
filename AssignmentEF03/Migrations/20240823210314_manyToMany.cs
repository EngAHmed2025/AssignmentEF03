using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentEF03.Migrations
{
    /// <inheritdoc />
    public partial class manyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentsId",
                table: "Students");

            migrationBuilder.RenameColumn(
                name: "DepartmentsId",
                table: "Students",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DepartmentsId",
                table: "Students",
                newName: "IX_Students_DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_Stud_ID",
                table: "Stud_Courses",
                column: "Stud_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_inst_ID",
                table: "Course_Insts",
                column: "inst_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_Course_ID",
                table: "Course_Insts",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructors_inst_ID",
                table: "Course_Insts",
                column: "inst_ID",
                principalTable: "Instructors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses",
                column: "Course_ID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_Stud_ID",
                table: "Stud_Courses",
                column: "Stud_ID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_Course_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructors_inst_ID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_Course_ID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_Stud_ID",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_Stud_ID",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_inst_ID",
                table: "Course_Insts");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Students",
                newName: "DepartmentsId");

            migrationBuilder.RenameIndex(
                name: "IX_Students_DepartmentId",
                table: "Students",
                newName: "IX_Students_DepartmentsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentsId",
                table: "Students",
                column: "DepartmentsId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
