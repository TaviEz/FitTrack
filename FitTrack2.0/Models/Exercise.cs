using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace FitTrack2._0.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<ExerciseSet> ExerciseSets { get; set; } = new List<ExerciseSet>();

        public int? WorkoutId { get; set; }

        public Workout? Workout { get; set; }

        public List<MuscleGroup> MuscleGroups { get; set; } = new();

        public ICollection<ExerciseRecord> ExerciseRecords { get; set; } = new List<ExerciseRecord>();

        public Exercise() 
        {
            Name = "Exercise";
        }

        public Exercise(int? workoutId)
        {
            WorkoutId = workoutId;
            ExerciseSets.Add(new ExerciseSet(exerciseId: Id));
        }

    }
}
