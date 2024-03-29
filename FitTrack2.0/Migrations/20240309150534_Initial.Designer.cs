﻿// <auto-generated />
using FitTrack2._0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitTrack2._0.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240309150534_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FitTrack2._0.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "description bench press",
                            Name = "Bench Press",
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "description Overhead Press",
                            Name = "Overhead Press",
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 3,
                            Description = "description Triceps extensions",
                            Name = "Triceps extensions",
                            WorkoutId = 2
                        });
                });

            modelBuilder.Entity("FitTrack2._0.Models.ExerciseSet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("Repetitions")
                        .HasColumnType("int");

                    b.Property<int>("Weight")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExerciseId");

                    b.ToTable("ExerciseSets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ExerciseId = 1,
                            Repetitions = 10,
                            Weight = 80
                        },
                        new
                        {
                            Id = 2,
                            ExerciseId = 1,
                            Repetitions = 6,
                            Weight = 90
                        },
                        new
                        {
                            Id = 3,
                            ExerciseId = 2,
                            Repetitions = 10,
                            Weight = 20
                        },
                        new
                        {
                            Id = 4,
                            ExerciseId = 2,
                            Repetitions = 8,
                            Weight = 25
                        },
                        new
                        {
                            Id = 5,
                            ExerciseId = 3,
                            Repetitions = 10,
                            Weight = 15
                        },
                        new
                        {
                            Id = 6,
                            ExerciseId = 3,
                            Repetitions = 8,
                            Weight = 18
                        });
                });

            modelBuilder.Entity("FitTrack2._0.Models.Workout", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkoutSplitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutSplitId");

                    b.ToTable("Workouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "piept si triceps",
                            Name = "Push day",
                            WorkoutSplitId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "spate si biceps",
                            Name = "Pull day",
                            WorkoutSplitId = 1
                        });
                });

            modelBuilder.Entity("FitTrack2._0.Models.WorkoutSplit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkoutSplit");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Push Pull Legs"
                        });
                });

            modelBuilder.Entity("FitTrack2._0.Models.Exercise", b =>
                {
                    b.HasOne("FitTrack2._0.Models.Workout", "Workout")
                        .WithMany("ExerciseList")
                        .HasForeignKey("WorkoutId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("FitTrack2._0.Models.ExerciseSet", b =>
                {
                    b.HasOne("FitTrack2._0.Models.Exercise", "Exercise")
                        .WithMany("ExerciseSets")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");
                });

            modelBuilder.Entity("FitTrack2._0.Models.Workout", b =>
                {
                    b.HasOne("FitTrack2._0.Models.WorkoutSplit", "WorkoutSplit")
                        .WithMany("Workouts")
                        .HasForeignKey("WorkoutSplitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkoutSplit");
                });

            modelBuilder.Entity("FitTrack2._0.Models.Exercise", b =>
                {
                    b.Navigation("ExerciseSets");
                });

            modelBuilder.Entity("FitTrack2._0.Models.Workout", b =>
                {
                    b.Navigation("ExerciseList");
                });

            modelBuilder.Entity("FitTrack2._0.Models.WorkoutSplit", b =>
                {
                    b.Navigation("Workouts");
                });
#pragma warning restore 612, 618
        }
    }
}
