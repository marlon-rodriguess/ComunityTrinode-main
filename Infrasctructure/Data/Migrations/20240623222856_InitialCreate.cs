using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Trinode.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    ImageUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    CategoryId = table.Column<int>(type: "INT", nullable: false),
                    Price = table.Column<double>(type: "FLOAT", nullable: false),
                    Technology = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    TotalHours = table.Column<double>(type: "FLOAT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    ModuleGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VideoUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    GithubUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Salt = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    CEP = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    ImageUrl = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    Salt = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    CPF = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    Phone = table.Column<string>(type: "VARCHAR(11)", maxLength: 11, nullable: false),
                    Endereco = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    CEP = table.Column<string>(type: "VARCHAR(8)", maxLength: 8, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "VARCHAR(255)", maxLength: 255, nullable: false),
                    FK_Courses_Modules = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Lectures = table.Column<int>(type: "INT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modules_Courses_FK_Courses_Modules",
                        column: x => x.FK_Courses_Modules,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCourse",
                columns: table => new
                {
                    Courses = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCourse", x => new { x.Courses, x.UserId });
                    table.ForeignKey(
                        name: "FK_Course_TeacherId",
                        column: x => x.UserId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Teacher_CourseId",
                        column: x => x.Courses,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Courses = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.Courses, x.UserId });
                    table.ForeignKey(
                        name: "FK_UserRole_CourseId",
                        column: x => x.Courses,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Modules_FK_Courses_Modules",
                table: "Modules",
                column: "FK_Courses_Modules");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourse_UserId",
                table: "TeacherCourse",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UserId",
                table: "UserRole",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "TeacherCourse");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
