using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace theSneakerDon.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId
        {
            get; set;
        }
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is a Required Input")]
        public string FirstName
        {
            get; set;
        }
        [Display(Name = "Last Name")]
        public string LastName
        {
            get; set;
        }
        [Display(Name = "Street Name")]
        public string StreetName
        {
            get; set;
        }

        [Display(Name = "City")]
        public string City
        {
            get; set;
        }
        [Display(Name = "State")]
        public string State
        {
            get; set;
        }
        [Display(Name = "Zip Code")]
        public string ZipCode
        {
            get; set;
        }
        [Display(Name = "Phone Number")]
        public string PhoneNumber
        {
            get; set;
        }
        [Display(Name = "Shoe Size")]
        public string ShoeSize
        {
            get; set;
        }
        [ForeignKey("IdentityUser")]
        public string IdentityUserId
        {
            get; set;
        }
        public IdentityUser IdentityUser
        {
            get; set;
        }
    }
}
