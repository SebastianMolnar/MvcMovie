﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Cars
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Marca { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        [Display(Name = "An Fabricatie")]
        [StringLength(4, MinimumLength = 4)]
        public string AnFabricatie { get; set; }
        [Display(Name = "Cod Motor")]
        [Required]
        public string CodMotor { get; set; }
        public string Culoare { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]+[A-Z0123456789\s]*$")]
        [StringLength(17,MinimumLength =17)]
        public string VIN { get; set; }
        [Required]
        [RegularExpression(@"[0-9]*$")]
        [Display(Name = "Kilometraj actual")]
        public string km { get; set; }
        [Required]
        [RegularExpression(@"[0-9]*$")]
        [StringLength(15, MinimumLength = 1)]
        public string Pret { get; set; }
        [Required]
        [Display(Name = "Lucrari efectuate")]
        public string Modificari { get; set; }

    }
}
