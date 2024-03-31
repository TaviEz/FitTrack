using FitTrack2._0.Models;
using Microsoft.AspNetCore.Identity;

namespace FitTrack2._0.Data
{
        // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public ICollection<WorkoutSplit>? WorkoutSplits { get; set; } = new List<WorkoutSplit>();
    }
}
