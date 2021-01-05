using System;
using System.Collections.Generic;

namespace NekoJourney.Models
{
    public partial class User
    {
        public int IdUser { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
