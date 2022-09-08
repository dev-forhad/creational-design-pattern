﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class EmployeeType
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
