using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise_UI_UX.Domain;

namespace Exercise_UI_UX.Models
{
    public class NameSelector
    {
        public NameSelector(int size)
        {
            Students = new Student[size];
        }

        public Student[] Students { get; set; }
    }
}