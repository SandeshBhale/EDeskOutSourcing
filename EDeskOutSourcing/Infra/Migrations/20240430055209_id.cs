using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ProjectStageId1",
                table: "ProjectStagesTable",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProjectStagesTable_ProjectStageId1",
                table: "ProjectStagesTable",
                column: "ProjectStageId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectStagesTable_ProjectStagesTable_ProjectStageId1",
                table: "ProjectStagesTable",
                column: "ProjectStageId1",
                principalTable: "ProjectStagesTable",
                principalColumn: "ProjectStageId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProjectStagesTable_ProjectStagesTable_ProjectStageId1",
                table: "ProjectStagesTable");

            migrationBuilder.DropIndex(
                name: "IX_ProjectStagesTable_ProjectStageId1",
                table: "ProjectStagesTable");

            migrationBuilder.DropColumn(
                name: "ProjectStageId1",
                table: "ProjectStagesTable");
        }
    }
}
