using System;
using System.Collections.Generic;

namespace Models
{
    public partial class Permission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Path { get; set; }
        public string Method { get; set; }
    }
}
