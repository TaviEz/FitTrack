using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitTrack2._0.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkoutSplit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutSplit", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutSplitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_WorkoutSplit_WorkoutSplitId",
                        column: x => x.WorkoutSplitId,
                        principalTable: "WorkoutSplit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkoutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercises_Workouts_WorkoutId",
                        column: x => x.WorkoutId,
                        principalTable: "Workouts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Repetitions = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    ExerciseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseSets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExerciseSets_Exercises_ExerciseId",
                        column: x => x.ExerciseId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WorkoutSplit",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Push Pull Legs" });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "Description", "Name", "WorkoutSplitId" },
                values: new object[,]
                {
                    { 1, "piept si triceps", "Push day", 1 },
                    { 2, "spate si biceps", "Pull day", 1 }
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Description", "Name", "WorkoutId" },
                values: new object[,]
                {
                    { 1, "description bench press", "Bench Press", 1 },
                    { 2, "description Overhead Press", "Overhead Press", 1 },
                    { 3, "description Triceps extensions", "Triceps extensions", 2 }
                });

            migrationBuilder.InsertData(
                table: "ExerciseSets",
                columns: new[] { "Id", "ExerciseId", "Repetitions", "Weight" },
                values: new object[,]
                {
                    { 1, 1, 10, 80 },
                    { 2, 1, 6, 90 },
                    { 3, 2, 10, 20 },
                    { 4, 2, 8, 25 },
                    { 5, 3, 10, 15 },
                    { 6, 3, 8, 18 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_WorkoutId",
                table: "Exercises",
                column: "WorkoutId");

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSets_ExerciseId",
                table: "ExerciseSets",
                column: "ExerciseId");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_WorkoutSplitId",
                table: "Workouts",
                column: "WorkoutSplitId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseSets");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "WorkoutSplit");
        }
    }
}
