using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        public string email { get; set; }

        [Required]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required]
        [Display(Name = "Street Address")]
        public string address { get; set; }

        [Display(Name = "Name: ")]
        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.firstName, this.lastName);
            }
        }
        [Required]
        [Display(Name= "Choose a pickup day")]
        public string trashDay { get; set; }
        
        [Required]
        [Display(Name="Weekly or Bi-Weekly")]
        public bool frequencyOfPickUp { get; set; }


        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserId { get; set; }

    }
}