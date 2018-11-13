using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_162
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public Student(string name) : this(name, 0)
        {

        }
        public Student(string name, int Id)
        {
            Name = name;
            ID = Id;
        }
    }
}
