using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NekoJourney.Models
{
    public partial class User
    {

        [Required(ErrorMessage = "ID tidak boleh kosong")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Hanya boleh diisi dengan angka")]
        public int IdUser { get; set; }
        [Required(ErrorMessage = "Nama tidak boleh kosong")]
        public string Nama { get; set; }
        [Required(ErrorMessage = "Email tidak boleh kosong")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password tidak boleh kosong")]
        public string Password { get; set; }
    }
}
