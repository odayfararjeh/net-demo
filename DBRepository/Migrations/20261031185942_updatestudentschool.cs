using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBRepository.Migrations
{
    /// <inheritdoc />
    public partial class updatestudentschool : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolId",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "School",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_School", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Student_SchoolId",
                table: "Student",
                column: "SchoolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_School_SchoolId",
                table: "Student",
                column: "SchoolId",
                principalTable: "School",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_School_SchoolId",
                table: "Student");

            migrationBuilder.DropTable(
                name: "School");

            migrationBuilder.DropIndex(
                name: "IX_Student_SchoolId",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "SchoolId",
                table: "Student");
        }
    }
}
