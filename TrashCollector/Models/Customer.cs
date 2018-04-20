using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Display(Name = "Email Address: ")]
        public string emailAddress{ get; set; }
        [Display(Name = "Password: ")]
        public string password { get; set; }
        [Display(Name = "First Name: ")]
        public string firstName { get; set; }
        [Display(Name = "Last Name: ")]
        public string lastName { get; set; }
        [Display(Name = "Street Address: ")]
        public string address { get; set; }
        [Display(Name = "Customer ID: ")]
        public int id { get; set; }
        [Display(Name = "Name: ")]
        public string Name
        {
            get
            {
                return string.Format("{0} {1} {2}", this.firstName, this.lastName);
            }
        }
        
        public void Register()
        {

        }

        public void Login()
        {

        }
        public void SetPickUpDay()
        {

        }

        public void EditPickUpDay()
        {

        }
        public void ChooseFrequency()
        {

        }
        public void PausePickup()
        {

        }
        public void ViewTrashSchedule()
        {

        }
        public void ViewPayments()
        {

        }

    }
}