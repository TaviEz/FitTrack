namespace FitTrack2._0.Models
{
    public class ExerciseRecord
    {
        public int Id { get; set; }

        public DateOnly Date { get; set; }

        public int Repetitions { get; set; }

        public int Weight { get; set; }

        public int ExerciseId { get; set; }

        public Exercise? Exercise { get; set; }

        public ExerciseRecord()
        {
        }

        public ExerciseRecord(DateOnly date, int reps,  int weight, int exerciseId)
        {
            Date = date;
            Repetitions = reps;
            Weight = weight;
            ExerciseId = exerciseId;
        }
    }
}
