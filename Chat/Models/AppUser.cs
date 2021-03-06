﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Chat.Models
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string WebSite { get; set; }
        public string Address { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string Linkedin { get; set; }
        public bool IsActivated { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}