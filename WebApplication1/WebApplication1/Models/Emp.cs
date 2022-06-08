using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class Emp
    {
        public int? Id { get; set; }
        public string Empname { get; set; }
        public string Gender { get; set; }
        public string Salary { get; set; }
        public string Department { get; set; }
    }
}
