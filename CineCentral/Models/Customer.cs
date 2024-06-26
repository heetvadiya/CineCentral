﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CineCentral.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; } // Navigation property
        // it helps navigate from one to another
        // useful , when we want to load an object and its related object from Dbase
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } // Foreign Key
        // for optimisation, we sometimes dont want to include entire object,
        // We just want to include foreignkey , we can do that by this property
        // EF automatically recognises it by the convention
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}