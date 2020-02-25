using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_Rental_System.Models
{
    public class Customer
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsSubToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        public byte MemberShipTypeId { get; set; }

    }
}