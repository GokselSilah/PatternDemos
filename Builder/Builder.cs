using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.Builder
{
    abstract class Builder_Builder
    {
        public abstract void BuilderCourseLanguage();
        public abstract void BuilderCourseDevelopment();
        public abstract Builder_Course GetCoursesTypes();
    }
}
