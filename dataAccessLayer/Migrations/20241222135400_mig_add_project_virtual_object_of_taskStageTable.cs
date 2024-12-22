using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_project_virtual_object_of_taskStageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_taskStages_projectID",
                table: "taskStages",
                column: "projectID");

            migrationBuilder.AddForeignKey(
                name: "FK_taskStages_projects_projectID",
                table: "taskStages",
                column: "projectID",
                principalTable: "projects",
                principalColumn: "projectID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_taskStages_projects_projectID",
                table: "taskStages");

            migrationBuilder.DropIndex(
                name: "IX_taskStages_projectID",
                table: "taskStages");
        }
    }
}
