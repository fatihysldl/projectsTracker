using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_set_role_relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_projects_companyUser_companyUserID",
                table: "projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_companyUser",
                table: "companyUser");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "companyUser",
                newName: "companyUsers");

            migrationBuilder.AddColumn<int>(
                name: "AppRoleId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "companyUserID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "roleID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "roleID",
                table: "companyUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_companyUsers",
                table: "companyUsers",
                column: "companyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AppRoleId",
                table: "AspNetUsers",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_companyUserID",
                table: "AspNetUsers",
                column: "companyUserID");

            migrationBuilder.CreateIndex(
                name: "IX_companyUsers_roleID",
                table: "companyUsers",
                column: "roleID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                table: "AspNetUsers",
                column: "AppRoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_companyUsers_companyUserID",
                table: "AspNetUsers",
                column: "companyUserID",
                principalTable: "companyUsers",
                principalColumn: "companyUserID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_companyUsers_AspNetRoles_roleID",
                table: "companyUsers",
                column: "roleID",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_projects_companyUsers_companyUserID",
                table: "projects",
                column: "companyUserID",
                principalTable: "companyUsers",
                principalColumn: "companyUserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_companyUsers_companyUserID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_companyUsers_AspNetRoles_roleID",
                table: "companyUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_projects_companyUsers_companyUserID",
                table: "projects");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_companyUserID",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_companyUsers",
                table: "companyUsers");

            migrationBuilder.DropIndex(
                name: "IX_companyUsers_roleID",
                table: "companyUsers");

            migrationBuilder.DropColumn(
                name: "AppRoleId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "companyUserID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "roleID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "roleID",
                table: "companyUsers");

            migrationBuilder.RenameTable(
                name: "companyUsers",
                newName: "companyUser");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_companyUser",
                table: "companyUser",
                column: "companyUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_projects_companyUser_companyUserID",
                table: "projects",
                column: "companyUserID",
                principalTable: "companyUser",
                principalColumn: "companyUserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
