using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.Builder
{
    class Builder_CourseBuilder : Builder_Builder
    {
        private Builder_Course _course = new Builder_Course();

        public override void BuilderCourseLanguage()
        {
            _course.Add("Language");
        }

        public override void BuilderCourseDevelopment()
        {
            _course.Add("Development");
        }

        public override Builder_Course GetCoursesTypes()
        {
            return _course;
        }
       
    }
}
