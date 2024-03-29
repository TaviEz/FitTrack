﻿namespace FitTrack2._0.Models
{
    public class Exercise
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public ICollection<ExerciseSet> ExerciseSets { get; set; } = new List<ExerciseSet>();

        public int? WorkoutId { get; set; }

        public Workout? Workout { get; set; }

        public Exercise() 
        {
        }

        public Exercise(int? workoutId)
        {
            WorkoutId = workoutId;
            ExerciseSets.Add(new ExerciseSet(exerciseId: Id));
        }

    }
}
