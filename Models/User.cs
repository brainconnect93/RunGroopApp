﻿using System.ComponentModel.DataAnnotations;

namespace RunGroopApp.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public Address? Address { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}
