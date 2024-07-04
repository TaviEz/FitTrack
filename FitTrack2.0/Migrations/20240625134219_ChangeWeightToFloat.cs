using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitTrack2._0.Migrations
{
    /// <inheritdoc />
    public partial class ChangeWeightToFloat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "ExerciseSets",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Weight",
                table: "ExerciseRecords",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 80f);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Weight",
                value: 90f);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Weight",
                value: 20f);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Weight",
                value: 25f);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Weight",
                value: 15f);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Weight",
                value: 18f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "ExerciseSets",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "ExerciseRecords",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Weight",
                value: 80);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Weight",
                value: 90);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Weight",
                value: 20);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Weight",
                value: 25);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Weight",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ExerciseSets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Weight",
                value: 18);
        }
    }
}
