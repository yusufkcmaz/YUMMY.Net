﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace YUMMY.Net.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BookingDate { get; set; }
        public int  PersonCount { get; set; }
        public string MessageContent { get; set; }
        public bool ISapproved  { get; set; }
    }
}