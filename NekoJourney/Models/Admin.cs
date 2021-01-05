using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NekoJourney.Models
{
    public partial class Admin
    {
        [Required(ErrorMessage = "ID tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        public int IdAdmin { get; set; }
        [Required(ErrorMessage = "Nama tidak boleh kosong")]
        public string Nama { get; set; }
        [Required(ErrorMessage = "Email tidak boleh kosong")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password tidak boleh kosong")]
        public string Password { get; set; }
        [MinLength(10, ErrorMessage = "No HP minimal 10 digit")]
        [MaxLength(12, ErrorMessage = "No HP maksimal 12 digit")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        [Required(ErrorMessage = "No HP tidak boleh kosong")]
        public string NoHp { get; set; }
    }
}
