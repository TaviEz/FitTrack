namespace FitTrack2._0.Models
{
    public class Workout
    {
        public int? Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<Exercise> ExerciseList { get; set; } = new List<Exercise>();

        public int WorkoutSplitId { get; set; }

        public WorkoutSplit? WorkoutSplit { get; set;}

        public Workout()
        {
            
        }

        public Workout(int workoutSplitId)
        {
            Name = "New Workout";
            WorkoutSplitId = workoutSplitId;
        }
    }
}
