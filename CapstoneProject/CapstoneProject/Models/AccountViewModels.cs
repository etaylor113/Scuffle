﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CapstoneProject.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "*Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "*First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "*Last Name")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "*Address Line 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Required]
        [Display(Name = "*State Example: WI")]
        public string State { get; set; }

        [Required]
        [Display(Name = "*City")]
        public string City { get; set; }

        [Required]
        [Display(Name = "*Contact Number")]
        public string ContactNumber { get; set; }

        [Required]
        [Display(Name = "*Zip Code")]
        public string ZipCode { get; set; }


        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "*Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "*Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Registration Status")]
        public bool RegistrationStatus { get; set; }

        [Display(Name = "Monday")]
        [DataType(DataType.MultilineText)]
        public string MondayPlan { get; set; }

        [Display(Name = "Tuesday")]
        public string TuesdayPlan { get; set; }

        [Display(Name = "Wednesday")]
        public string WednesdayPlan { get; set; }

        [Display(Name = "Thursday")]
        public string ThursdayPlan { get; set; }

        [Display(Name = "Friday")]
        public string FridayPlan { get; set; }

        [Display(Name = "Saturday")]
        public string SaturdayPlan { get; set; }

        [Display(Name = "Sunday")]
        public string SundayPlan { get; set; }

        public string ChallengeId { get; set; }      

        [Display(Name = "Challenge Name")]
        public string ChallengeName { get; set; }

        [Display(Name = "Start Date")]
        public string StartDate { get; set; }

        [Display(Name = "End Date")]
        public string EndDate { get; set; }

        [Display(Name = "Goal #1")]
        public string GoalOne { get; set; }

        [Display(Name = "Goal #2")]
        public string GoalTwo { get; set; }

        [Display(Name = "Goal #3")]
        public string GoalThree { get; set; }

        [Display(Name = "Goal #4")]
        public string GoalFour { get; set; }

        [Display(Name = "Goal #5")]
        public string GoalFive { get; set; }

        [Display(Name = "Description ")]
        public string DescOne { get; set; }

        [Display(Name = "Description")]
        public string DescTwo { get; set; }

        [Display(Name = "Description")]
        public string DescThree { get; set; }

        [Display(Name = "Description")]
        public string DescFour { get; set; }

        [Display(Name = "Description")]
        public string DescFive { get; set; }

        [Display(Name = "Difficulty Level")]
        public string DiffOne { get; set; }

        [Display(Name = "Difficulty Level")]
        public string DiffTwo { get; set; }

        [Display(Name = "Difficulty Level")]
        public string DiffThree { get; set; }

        [Display(Name = "Difficulty Level")]
        public string DiffFour { get; set; }

        [Display(Name = "Difficulty Level")]
        public string DiffFive { get; set; }

        [Display(Name = "Chart Shared/Private")]
        public bool ChartShared { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
