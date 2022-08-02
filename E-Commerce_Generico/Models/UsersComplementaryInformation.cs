using System;
using System.Collections.Generic;

namespace E_Commerce_Generico.Models
{
    public partial class UsersComplementaryInformation
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; } = null!;
        public string UserSurname { get; set; } = null!;
        public string? UserAddress { get; set; }
        public string? UserPhone { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
