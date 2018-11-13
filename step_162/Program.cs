using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step_162
{
    class Program
    {
        static void Main(string[] args)
        {
            //example of const variable
            const string schoolName = "The Tech Academy";
            Console.WriteLine(schoolName);
            //example of variable created using var keyword
            var age = 23;
            Console.WriteLine(age);
            //example of new student object created byt just entering student name, and taking default Id value 0
            Student student1 = new Student("Liam");
            Console.WriteLine("{0} {1}", student1.Name, student1.ID);
            Console.ReadLine();
        }
    }
}
