using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitTrack2._0.Migrations
{
    /// <inheritdoc />
    public partial class UserWorkoutSplitFinal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_WorkoutSplits_WorkoutSplitId",
                table: "Workouts");

            migrationBuilder.AlterColumn<int>(
                name: "WorkoutSplitId",
                table: "Workouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_WorkoutSplits_WorkoutSplitId",
                table: "Workouts",
                column: "WorkoutSplitId",
                principalTable: "WorkoutSplits",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Workouts_WorkoutSplits_WorkoutSplitId",
                table: "Workouts");

            migrationBuilder.AlterColumn<int>(
                name: "WorkoutSplitId",
                table: "Workouts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Workouts_WorkoutSplits_WorkoutSplitId",
                table: "Workouts",
                column: "WorkoutSplitId",
                principalTable: "WorkoutSplits",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
