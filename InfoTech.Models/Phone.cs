﻿using System.ComponentModel.DataAnnotations;
using InfoTech.Utilities;

namespace InfoTech.Models
{
    public class Phone
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(13)]
        public string? Number { get; set; }
        public Sd.Status Status { get; set; }
    }
}
