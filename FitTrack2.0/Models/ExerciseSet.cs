using Microsoft.EntityFrameworkCore;

namespace FitTrack2._0.Models
{
    public class ExerciseSet
    {
        public int Id { get; set; }
        public int Repetitions { get; set; }

        public int Weight { get; set; }

        public int ExerciseId { get; set; }

        public Exercise? Exercise { get; set; }

        public ExerciseSet() { }

        public ExerciseSet(int exerciseId)
        {
            ExerciseId = exerciseId;
        }

    }

}
