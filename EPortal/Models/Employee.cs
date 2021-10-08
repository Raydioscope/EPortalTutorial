using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EPortal.Models
{
    public class Employee
    {
        [Display(Name ="ID")]
        
        public int EmployeeID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage ="Please enter Employee name.")]

        public string EmployeeName { get; set; }

        [Required(ErrorMessage = "Please enter Employee city.")]
        [Display(Name = "City")]
        public string EmployeeCity { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string EmployeeSex { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int EmployeeAge { get; set; }

        [Required]
        [Display(Name = "Joining Date")]
        public string JoiningDate { get; set; }

        [Required]
        //[EmailAddress(ErrorMessage ="Please enter valid email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        [Display(Name = "Email")]
        public string EmailID { get; set; }
    }
}