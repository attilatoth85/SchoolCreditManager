using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Text;

namespace ClassLibrary
{
    [Table]
    class Subjects
    {
        [Column]
        public string SubjectName;
        [Column]
        public int Semester;
        [Column]
        public string CurrentType;
        [Column]
        public int Credit;
        [Column]
        public string Pass;
        [Column]
        public int UserID;
        [Column]
        public int SubjectID;

    }
}
