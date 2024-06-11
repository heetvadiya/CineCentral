using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CineCentral.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; } // Navigation property
        // it helps navigate from one to another
        // useful , when we want to load an object and its related object from Dbase
        public byte MembershipTypeId { get; set; } // Foreign Key
        // for optimisation, we sometimes dont want to include entire object,
        // We just want to include foreignkey , we can do that by this property
        // EF automatically recognises it by the convention

    }
}