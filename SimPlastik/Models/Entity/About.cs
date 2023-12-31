﻿using System.ComponentModel.DataAnnotations;

namespace SimPlastik.Models.Entity
{
    public class About
    {
        [Key]
        public int about_id { get; set; }
        public string? about_text { get; set; }
        public string? about_title { get; set; }
        public string? about_eng_text { get; set; }
        public string? about_ar_text { get; set; }
    }
}
