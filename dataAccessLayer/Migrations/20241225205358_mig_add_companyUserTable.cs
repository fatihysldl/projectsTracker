using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_companyUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "companyUserID",
                table: "projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "companyUser",
                columns: table => new
                {
                    companyUserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    companyUserEmail = table.Column<int>(type: "int", nullable: false),
                    companyUserPassword = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companyUser", x => x.companyUserID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_projects_companyUserID",
                table: "projects",
                column: "companyUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_companyUser_companyUserID",
                table: "projects",
                column: "companyUserID",
                principalTable: "companyUser",
                principalColumn: "companyUserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_companyUser_companyUserID",
                table: "projects");

            migrationBuilder.DropTable(
                name: "companyUser");

            migrationBuilder.DropIndex(
                name: "IX_projects_companyUserID",
                table: "projects");

            migrationBuilder.DropColumn(
                name: "companyUserID",
                table: "projects");
        }
    }
}
