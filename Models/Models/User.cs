using System;
using System.Collections.Generic;

namespace Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }

        public class AddUserR
        {
            public string message { get; set; }
            public int code { get; set; }
        }
    }
}
