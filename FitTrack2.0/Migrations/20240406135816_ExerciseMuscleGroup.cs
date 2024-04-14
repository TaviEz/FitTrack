using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitTrack2._0.Migrations
{
    /// <inheritdoc />
    public partial class ExerciseMuscleGroup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MuscleGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseMuscleGroup",
                columns: table => new
                {
                    AssociatedExcercisesId = table.Column<int>(type: "int", nullable: false),
                    MuscleGroupsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseMuscleGroup", x => new { x.AssociatedExcercisesId, x.MuscleGroupsId });
                    table.ForeignKey(
                        name: "FK_ExerciseMuscleGroup_Exercises_AssociatedExcercisesId",
                        column: x => x.AssociatedExcercisesId,
                        principalTable: "Exercises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExerciseMuscleGroup_MuscleGroups_MuscleGroupsId",
                        column: x => x.MuscleGroupsId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseMuscleGroup_MuscleGroupsId",
                table: "ExerciseMuscleGroup",
                column: "MuscleGroupsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExerciseMuscleGroup");

            migrationBuilder.DropTable(
                name: "MuscleGroups");
        }
    }
}
