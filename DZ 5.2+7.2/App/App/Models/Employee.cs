﻿using System;
using System.Collections.Generic;

#nullable disable

namespace App.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Sex { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public short Zip { get; set; }
        public string Country { get; set; }
        public string Emailaddress { get; set; }
        public string Telephoneno { get; set; }
        public decimal? Salary { get; set; }
        public string Department { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
