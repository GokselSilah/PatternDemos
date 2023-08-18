using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.Prototype
{
    public class CourseManager
    {
        private Dictionary<string, CoursePrototype> courses = new Dictionary<string, CoursePrototype>();

        public CoursePrototype this[string key]
        {
            get { return courses[key];}
            set { courses.Add(key, value);}
        }
    }
}
