using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF03.Entites
{
    public class Stud_Course
    {

        public int Stud_ID { get; set; }
        public Students Student { get; set; }
        public int Course_ID { get; set; }
        public Course Course { get; set; }

        public int Grade { get; set; }

    }
}
