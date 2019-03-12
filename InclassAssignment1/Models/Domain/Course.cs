using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InclassAssignment1.Models.Domain
{
    public class Course
    {
        public virtual ApplicationUser User { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfHours { get; set; }
    }
}