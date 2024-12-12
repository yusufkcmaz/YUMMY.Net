using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YUMMY.Net.Models
{
    public class ContactInfo
    {
        public int ContactInfoID { get; set; }
        public string ADDRESS { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string MapUrld { get; set; }
        public string OpenHours { get; set; }
    }
}