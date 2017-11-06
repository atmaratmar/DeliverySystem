using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeliverySystem.Models
{
    public class Drivers
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool OnDuty  { get; set; }
        public bool Availability { get; set; }
        List<Order> Orders = new List<Order>();

    }
}