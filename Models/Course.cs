﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchool_2011068957.Models
{
    public class Course
    {
        public int Id { get; set; }
        public bool IsCanceled { get; set; }
        public ApplicationUser Lecturer {get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public String Place { get; set; }
        public DateTime DateTime { get; set; }
        public Category Category { get; set; }
        [Required]
        public byte CategoryId { get; set; }

    }
}