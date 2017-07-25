using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CapstoneProject.Models
{
    public class ChallengesModel
    {
        [Key]
        [ForeignKey("Id")]
        [Display(Name = "Creator Id")]
        public string CreatorId { get; set; }

        [Display(Name = "Creator Username")]
        public string CreatorUserName { get; set; }

        [Display(Name = "Challenge Name")]
        public string ChallengeName { get; set; }

        [Display(Name = "Start Date")]
        public string StartDate { get; set; }

        [Display(Name = "End Date")]
        public string EndDate { get; set; }

        [Display(Name = "Goal One")]
        public string GoalOne { get; set; }

        [Display(Name = "Goal Two")]
        public string GoalTwo { get; set; }

        [Display(Name = "Goal Three")]
        public string GoalThree { get; set; }

        [Display(Name = "Goal Four")]
        public string GoalFour { get; set; }

        [Display(Name = "Goal Five")]
        public string GoalFive { get; set; }

        [Display(Name = "Description One")]
        public string DescOne { get; set; }

        [Display(Name = "Description Two")]
        public string DescTwo { get; set; }

        [Display(Name = "Description Three")]
        public string DescThree { get; set; }

        [Display(Name = "Description Four")]
        public string DescFour { get; set; }

        [Display(Name = "Description Five")]
        public string DescFive { get; set; }

        [Display(Name = "Difficulty One")]
        public string DiffOne { get; set; }

        [Display(Name = "Difficulty Two")]
        public string DiffTwo { get; set; }

        [Display(Name = "Difficulty Three")]
        public string DiffThree { get; set; }

        [Display(Name = "Difficulty Four")]
        public string DiffFour { get; set; }

        [Display(Name = "Difficulty Five")]
        public string DiffFive { get; set; }


    }
}