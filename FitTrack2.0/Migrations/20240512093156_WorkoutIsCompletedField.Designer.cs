﻿// <auto-generated />
using System;
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
    [Migration("20240512093156_WorkoutIsCompletedField")]
    partial class WorkoutIsCompletedField
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExerciseMuscleGroup", b =>
                {
                    b.Property<int>("AssociatedExcercisesId")
                        .HasColumnType("int");

                    b.Property<int>("MuscleGroupsId")
                        .HasColumnType("int");

                    b.HasKey("AssociatedExcercisesId", "MuscleGroupsId");

                    b.HasIndex("MuscleGroupsId");

                    b.ToTable("ExerciseMuscleGroup");
                });

            modelBuilder.Entity("FitTrack2._0.Data.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("FitTrack2._0.Models.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkoutId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateOnly(1, 1, 1),
                            Description = "description bench press",
                            Name = "Bench Press",
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateOnly(1, 1, 1),
                            Description = "description Overhead Press",
                            Name = "Overhead Press",
                            WorkoutId = 1
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateOnly(1, 1, 1),
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

            modelBuilder.Entity("FitTrack2._0.Models.MuscleGroup", b =>
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

                    b.HasKey("Id");

                    b.ToTable("MuscleGroups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Chest muscle group",
                            Name = "Chest"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Front shoulder muscle group",
                            Name = "Front Shoulders"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Biceps muscle group",
                            Name = "Biceps"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Abdominal muscle group",
                            Name = "Abs"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Posterior shoulder muscle group",
                            Name = "Posterior Shoulders"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Quadriceps muscle group",
                            Name = "Quads"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Hamstrings muscle group",
                            Name = "Back"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Calf muscle group",
                            Name = "Traps"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Triceps muscle group",
                            Name = "Triceps"
                        },
                        new
                        {
                            Id = 10,
                            Description = "Hams muscle group",
                            Name = "Hams"
                        },
                        new
                        {
                            Id = 11,
                            Description = "Calves muscle group",
                            Name = "Calves"
                        });
                });

            modelBuilder.Entity("FitTrack2._0.Models.Workout", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WorkoutSplitId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("WorkoutSplitId");

                    b.ToTable("Workouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "piept si triceps",
                            IsCompleted = false,
                            Name = "Push day",
                            WorkoutSplitId = 1
                        },
                        new
                        {
                            Id = 2,
                            Description = "spate si biceps",
                            IsCompleted = false,
                            Name = "Pull day",
                            WorkoutSplitId = 1
                        });
                });

            modelBuilder.Entity("FitTrack2._0.Models.WorkoutSplit", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"));

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("WorkoutSplits");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApplicationUserId = "39c94707-a386-437c-8e09-b607d42d2a8f",
                            Name = "Push Pull Legs"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ExerciseMuscleGroup", b =>
                {
                    b.HasOne("FitTrack2._0.Models.Exercise", null)
                        .WithMany()
                        .HasForeignKey("AssociatedExcercisesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitTrack2._0.Models.MuscleGroup", null)
                        .WithMany()
                        .HasForeignKey("MuscleGroupsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitTrack2._0.Models.Exercise", b =>
                {
                    b.HasOne("FitTrack2._0.Models.Workout", "Workout")
                        .WithMany("ExerciseList")
                        .HasForeignKey("WorkoutId");

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
                        .HasForeignKey("WorkoutSplitId");

                    b.Navigation("WorkoutSplit");
                });

            modelBuilder.Entity("FitTrack2._0.Models.WorkoutSplit", b =>
                {
                    b.HasOne("FitTrack2._0.Data.ApplicationUser", "ApplicationUser")
                        .WithMany("WorkoutSplits")
                        .HasForeignKey("ApplicationUserId");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FitTrack2._0.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FitTrack2._0.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitTrack2._0.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FitTrack2._0.Data.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitTrack2._0.Data.ApplicationUser", b =>
                {
                    b.Navigation("WorkoutSplits");
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
