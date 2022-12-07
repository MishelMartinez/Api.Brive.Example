using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Brive.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }

        public List<Subject> ListSubjects { get; set; }


        public int Semester { get; set; }
    }
}
