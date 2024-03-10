namespace FitTrack2._0.Models
{
    public class MuscleGroup
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<Exercise> AssociatedExcercises { get; set; } = new();
    }
}
