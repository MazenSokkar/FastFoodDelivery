﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDelivery.Models
{
    public class AppUser : IdentityUser
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Addresses { get; set; }
        public string PostalCode { get; set; }
    }
}