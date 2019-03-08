using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using AspNetCore2.Models;

namespace AspNetCore2.ViewModels
{
    public class VideoEditViewModel
    {
        public int id
        {
            get; set;
        }
        [Required, MinLength(3), MaxLength(20)]
        public string Title
        {
            get; set;
        }
        public Genres Genre
        {
            get; set;
        }
    }
}
