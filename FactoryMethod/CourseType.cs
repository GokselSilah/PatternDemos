using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FactoryMethod
{
    abstract class CourseType
    {
        private List<Course> _courses = new List<Course>();

        public CourseType() 
        {
            this.CreateCourses();
        }

        public List<Course> Courses 
        {
            get { return _courses; }
        }

        // Factory Method

        public abstract void CreateCourses();
    }
}
