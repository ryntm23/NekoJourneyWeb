using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NekoJourney.Models
{
    public partial class Review
    {
        [Required(ErrorMessage = "ID tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        public int IdReview { get; set; }
        [Required(ErrorMessage = "Nama tidak boleh kosong")]
        public string Nama { get; set; }
        [Required(ErrorMessage = "Review tidak boleh kosong")]
        public string Review1 { get; set; }
    }
}
