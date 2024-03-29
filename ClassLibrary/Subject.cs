﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Subject
    {
        public string SubjectName { get; set; }
        public int Semester { get; set; }
        public string CurrentType { get; set; }
        public int Credit { get; set; }
        public bool Pass { get; set; }
        public int Grade { get; set; }
        private enum Types { required, specialist, optional }

    }
}
