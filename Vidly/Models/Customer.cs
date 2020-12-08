using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vidly.Models
{
    public class Customer
    {
        public int? Id { get; set; }
        
        [Required(ErrorMessage = "Please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Date of Birth")]
        [Min18YearsIfAMember]
        public DateTime? DateOfBirth { get; set; }

        public bool isSubscripedToNewsLietter { get; set; }

        public MembershipType MembershipType { get; set; }
        [Required(ErrorMessage = "Please select a membership type.")]
        [Display(Name = "Membership Type")]
        public byte? MembershipTypeId { get; set; }

    }
}
