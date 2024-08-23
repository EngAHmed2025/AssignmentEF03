using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF03.Entites
{
    public class Course
    {
        public int ID { get; set; }

        public DateTime Duration { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public Topic? Top_ID { get; set; }

        public ICollection<Stud_Course> Stud_Courses { get; set; } = new HashSet<Stud_Course>();

        public ICollection<Course_Inst> Course_Insts { get; set; } = new HashSet<Course_Inst>();
    }
}
