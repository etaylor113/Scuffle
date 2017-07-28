using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace CapstoneProject.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    { 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string ContactNumber { get; set; }
        public string ZipCode { get; set; }
        public string Password { get; set; }   
        public string ConfirmPassword { get; set; }
        public bool RegistrationStatus { get; set; }
        public string MondayPlan { get; set; }
        public string TuesdayPlan { get; set; }
        public string WednesdayPlan { get; set; }
        public string ThursdayPlan { get; set; }
        public string FridayPlan { get; set; }
        public string SaturdayPlan { get; set; }
        public string SundayPlan { get; set; }
        public string ChallengeName { get; set; }
        public string ChallengeId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string GoalOne { get; set; }
        public string GoalTwo { get; set; }
        public string GoalThree { get; set; }
        public string GoalFour { get; set; }
        public string GoalFive { get; set; }
        public string DescOne { get; set; }
        public string DescTwo { get; set; }
        public string DescThree { get; set; }
        public string DescFour { get; set; }
        public string DescFive { get; set; }
        public string DiffOne { get; set; }
        public string DiffTwo { get; set; }
        public string DiffThree { get; set; }
        public string DiffFour { get; set; }
        public string DiffFive { get; set; }
        public bool ChartShared { get; set; }



        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
        public virtual ICollection<FriendTable> CustomTable { get; set; }
    }

    public class FriendTable
    {
        public int id { get; set; }
        public virtual ICollection<ApplicationUser> friendsList { get; set; }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {    

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<FriendTable> FriendTables { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}