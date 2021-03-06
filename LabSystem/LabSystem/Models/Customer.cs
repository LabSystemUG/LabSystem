﻿using LabSystem.Abstracts;
using LabSystem.Interfaces;

namespace LabSystem.Models
{
    public class Customer : A_User, IContact
    {
        public bool IsActive { get; set; }

        public string Voivodeship { get; set; }
        public string Commune { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string Phone { get; set; }

        public Customer()
        {
            IsActive = false;
        }
    }
}