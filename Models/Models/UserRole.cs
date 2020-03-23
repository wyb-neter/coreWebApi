using System;
using System.Collections.Generic;

namespace Models
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public int Userid { get; set; }
        public int Roleid { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
