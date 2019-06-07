using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Titlu")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Data Lansari")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [Display(Name = "Gen")]
        public String Genre { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name = "Pret")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
