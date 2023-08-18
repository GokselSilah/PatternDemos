using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.Builder
{
    class Builder_Course
    {
        private List<string> _courses = new List<string>();

        public void Add(string course)
        {
            _courses.Add(course);
        }

        public void Show()
        {
            Console.WriteLine("Kurslar --------");
            foreach (string course in _courses)
            {
                Console.WriteLine(course);
            }
        }
    }
}
