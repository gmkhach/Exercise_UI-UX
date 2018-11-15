using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise_UI_UX.Domain;

namespace Exercise_UI_UX.Models
{
    public class NameSelector
    {
        public NameSelector(string fName, string lName)
        {
            Student = new Student(fName, lName);
        }

        public Student Student { get; set; }
    }
}