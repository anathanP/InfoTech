﻿using System.ComponentModel.DataAnnotations;
using InfoTech.Utilities;

namespace InfoTech.Models
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string? Name { get; set; }
        public Sd.Status Status { get; set; }
    }
}