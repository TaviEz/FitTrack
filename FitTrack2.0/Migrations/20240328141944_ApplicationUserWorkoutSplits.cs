using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitTrack2._0.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserWorkoutSplits : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "WorkoutSplit",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "WorkoutSplit",
                keyColumn: "Id",
                keyValue: 1,
                column: "ApplicationUserId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_WorkoutSplit_ApplicationUserId",
                table: "WorkoutSplit",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkoutSplit_AspNetUsers_ApplicationUserId",
                table: "WorkoutSplit",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WorkoutSplit_AspNetUsers_ApplicationUserId",
                table: "WorkoutSplit");

            migrationBuilder.DropIndex(
                name: "IX_WorkoutSplit_ApplicationUserId",
                table: "WorkoutSplit");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "WorkoutSplit");
        }
    }
}
