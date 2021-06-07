using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace theSneakerDon.Models
{
    public class CustomerOrder
    {
        [Key]
        public int OrderId
        {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Your First Name")]
        [Display(Name="First Name")]
        public string FirstName
        {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Your Last Name")]
        [Display(Name = "Last Name")]
        public string LastName
        {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Your Address")]
        [Display(Name = " Street Address")]
        public string Address
        {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Your City")]
        public string City
        {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Your State")]
        public string State
        {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Your Zip Code")]
        [Display(Name = "Zip Code")]
        public string ZipCode
        {
            get; set;
        }
        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber
        {
            get; set;
        }

        public List<OrderDetail> OrderDetails
        {
            get; set;
        }
        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal
        {
            get; set;
        }
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced
        {
            get; set;
        }
    }
}
