using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FiiiEx.Models
{
    public class UserModel
    {
        public class UserProfile
        {
            [Key]
            public string UserId { get; set; }
            public string Username { get; set; }
            [MaxLength(50)]
            public string FirstName { get; set; }
            [MaxLength(50)]
            public string LastName { get; set; }
            public string Gender { get; set; }
            public DateTime? DOB { get; set; }
            public string Nationality { get; set; }
            public string IdentityDoc { get; set; }
            public string ResidentialAdd1 { get; set; }
            public string ResidentialAdd2 { get; set; }
            public int PostCode { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string Country { get; set; }
            public DateTime LastLoginTimeStamp { get; set; }
            public string MobileModel { get; set; }
            public string OS { get; set; }
            public string IPAddress { get; set; }

        }
    }
}