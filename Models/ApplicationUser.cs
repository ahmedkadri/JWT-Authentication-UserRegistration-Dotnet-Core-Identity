using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using System.Linq;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserRegistration.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Column(TypeName ="nvarchar(150)")]
        public string FullName { get; set; }
    }
}