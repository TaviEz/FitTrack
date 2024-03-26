using FitTrack2._0.Models;
using Microsoft.EntityFrameworkCore;

namespace FitTrack2._0.Data
{
    public class DataContext: DbContext 
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Exercise>()
                .HasMany(e => e.ExerciseSets)
                .WithOne(es => es.Exercise)
                .HasForeignKey(es => es.ExerciseId);

            modelBuilder.Entity<Workout>()
                .HasMany(e => e.ExerciseList)
                .WithOne(es => es.Workout)
                .HasForeignKey(es => es.WorkoutId);

            modelBuilder.Entity<WorkoutSplit>()
                .HasMany(e => e.Workouts)
                .WithOne(es => es.WorkoutSplit)
                .HasForeignKey(es => es.WorkoutSplitId);

            modelBuilder.Entity<ExerciseSet>().HasData(
                new ExerciseSet { Id = 1, Repetitions = 10, Weight = 80, ExerciseId = 1 },
                new ExerciseSet { Id = 2, Repetitions = 6, Weight = 90, ExerciseId = 1 },
                new ExerciseSet { Id = 3, Repetitions = 10, Weight = 20, ExerciseId = 2 },
                new ExerciseSet { Id = 4, Repetitions = 8, Weight = 25, ExerciseId = 2 },
                new ExerciseSet { Id = 5, Repetitions = 10, Weight = 15, ExerciseId = 3 },
                new ExerciseSet { Id = 6, Repetitions = 8, Weight = 18, ExerciseId = 3 }
            );

            modelBuilder.Entity<Exercise>().HasData(
                new Exercise { Id = 1, Name = "Bench Press", Description = "description bench press", WorkoutId = 1 },
                new Exercise { Id = 2, Name = "Overhead Press", Description = "description Overhead Press", WorkoutId = 1 },
                new Exercise { Id = 3, Name = "Triceps extensions", Description = "description Triceps extensions", WorkoutId = 2 }
            );

            modelBuilder.Entity<Workout>().HasData(
                new Workout { Id = 1, Name = "Push day", Description = "piept si triceps",  WorkoutSplitId = 1},
                new Workout { Id = 2, Name = "Pull day", Description = "spate si biceps", WorkoutSplitId = 1}
                );

            modelBuilder.Entity<WorkoutSplit>().HasData(
                new WorkoutSplit { Id = 1, Name = "Push Pull Legs"});

            
        }


        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Exercise> Exercises { get; set; }
        public DbSet<ExerciseSet> ExerciseSets { get; set; }
        public DbSet<UserDetails> UserDetails { get; set; }
    }
}
