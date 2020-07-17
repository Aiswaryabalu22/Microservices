using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeService.Migrations
{
    public partial class addingrelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectPid",
                table: "Employees",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CompanyProjects",
                columns: table => new
                {
                    Pid = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProjects", x => x.Pid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjectPid",
                table: "Employees",
                column: "ProjectPid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_CompanyProjects_ProjectPid",
                table: "Employees",
                column: "ProjectPid",
                principalTable: "CompanyProjects",
                principalColumn: "Pid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_CompanyProjects_ProjectPid",
                table: "Employees");

            migrationBuilder.DropTable(
                name: "CompanyProjects");

            migrationBuilder.DropIndex(
                name: "IX_Employees_ProjectPid",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "ProjectPid",
                table: "Employees");
        }
    }
}
