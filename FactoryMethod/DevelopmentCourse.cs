using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FactoryMethod
{
    class DevelopmentCourse : CourseType
    {
        public override void CreateCourses()
        {
            Courses.Add(new DotNetCourse());
            Courses.Add(new JavaCourse());
            Courses.Add(new JsCourse());
            Courses.Add(new PythonCourse());
            Courses.Add(new SqlCourse());

        }
    }
}
