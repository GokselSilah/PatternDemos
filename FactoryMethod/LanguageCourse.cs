using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.FactoryMethod
{
    class LanguageCourse : CourseType
    {
        public override void CreateCourses()
        {
            Courses.Add(new EnglishCourse());
            Courses.Add(new FrenchCourse());
            Courses.Add(new DeutchCourse());

        }
    }
}
