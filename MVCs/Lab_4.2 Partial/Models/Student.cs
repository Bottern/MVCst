using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab_4._2_Partial.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string  LastName { get; set; }
        public string Personnumber { get; set; }
        public string Address { get; set; }
        public List<Grade> Grades { get; set; }
    }
}