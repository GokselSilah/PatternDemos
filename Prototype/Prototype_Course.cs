using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.Prototype
{
    internal class Prototype_Course : CoursePrototype
    {
        string name;
        string subject;
        public Prototype_Course(string name, string subject)
        {
            this.name = name;

            this.subject = subject;
        }

        public override CoursePrototype Clone()
        {
            Console.WriteLine("Klonlanan Kurs: {0,2} - {1,2}",name,subject);

            return this.MemberwiseClone() as CoursePrototype;
        }


    }
}
