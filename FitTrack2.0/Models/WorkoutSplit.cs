using FitTrack2._0.Data;

namespace FitTrack2._0.Models
{
    public class WorkoutSplit
    {
        public int? Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();

        public string? ApplicationUserId { get; set; }

        public ApplicationUser? ApplicationUser { get; set; }

        public WorkoutSplit()
        {

        }

        public WorkoutSplit(string userId)
        {
            Name = "New workout Split";
            ApplicationUserId = userId;
            Workouts.Add(new Workout(workoutSplitId: Id));
        }


    }
}
