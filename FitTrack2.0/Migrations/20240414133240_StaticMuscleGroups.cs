using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitTrack2._0.Migrations
{
    /// <inheritdoc />
    public partial class StaticMuscleGroups : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MuscleGroups",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Chest muscle group", "Chest" },
                    { 2, "Front shoulder muscle group", "Front Shoulders" },
                    { 3, "Biceps muscle group", "Biceps" },
                    { 4, "Abdominal muscle group", "Abs" },
                    { 5, "Posterior shoulder muscle group", "Posterior Shoulders" },
                    { 6, "Quadriceps muscle group", "Quads" },
                    { 7, "Hamstrings muscle group", "Back" },
                    { 8, "Calf muscle group", "Traps" },
                    { 9, "Triceps muscle group", "Triceps" },
                    { 10, "Hams muscle group", "Hams" },
                    { 11, "Calves muscle group", "Calves" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MuscleGroups",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
