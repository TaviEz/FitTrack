namespace FitTrack2._0.Models
{
    public class WorkoutSplit
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Workout> Workouts { get; set; } = new List<Workout>();

        public WorkoutSplit()
        {
            
        }


    }
}
