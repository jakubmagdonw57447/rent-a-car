﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class UserDetails
    {
        public UserDetails() { }

        [Key, ForeignKey("User")]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual MyUser User { get; set; }

        public bool Create(int userId)
        {
            this.UserId = userId;
            try
            {
                var db = new ApplicationDbContext();
                db.UserDetails.Add(this);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}