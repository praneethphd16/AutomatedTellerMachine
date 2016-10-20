using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AutomatedTellerMachine.Models
{
    public class CheckingAccount
    {

        public int Id { get; set; }
        [Display(Name="Account #")]
        public string AccountNumber { get; set; }

        [Display(Name = "First Name")]

        public string FirstName { get; set; }

        
        [Display(Name = "Name")]
        public string Name { get {

                return string.Format("{0},{1}",this.FirstName,this.LastName);

            } }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [DataType(DataType.Currency)]
        public decimal Balance { get; set; }
    }
}