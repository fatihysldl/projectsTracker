using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_relation_appUser_with_project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CreatedByUserId",
                table: "projects",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_projects_CreatedByUserId",
                table: "projects",
                column: "CreatedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_AspNetUsers_CreatedByUserId",
                table: "projects",
                column: "CreatedByUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_AspNetUsers_CreatedByUserId",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_projects_CreatedByUserId",
                table: "projects");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedByUserId",
                table: "projects",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
