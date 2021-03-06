﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] //Makes column Name no longer nullable
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSuscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; } //Treated as a foreign key (so we don't load entire object)
        public DateTime? Birthdate { get; set; }
    }
}