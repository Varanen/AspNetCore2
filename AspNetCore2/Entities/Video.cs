using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore2.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore2.Entities
{
    public class Video
    {
        public int Id
        {
            get; set;
        }
        [Required, MinLength(3), MaxLength(20)]
        public string Title
        {
            get; set;
        }
        [Display(Name = "Film Genre")]
        public Genres Genre
        {
            get; set;
        }
    }
}
