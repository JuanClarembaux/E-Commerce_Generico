using System;
using System.Collections.Generic;

namespace E_Commerce_Generico.Models.DatabaseModels
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserMail { get; set; } = null!;
        public string UserName { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public string? UserRole { get; set; }

        public virtual UsersComplementaryInformation UsersComplementaryInformation { get; set; } = null!;
    }
}
