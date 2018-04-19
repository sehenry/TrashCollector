using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        public string emailAddress{ get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string middleInitial { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public int id { get; set; }


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