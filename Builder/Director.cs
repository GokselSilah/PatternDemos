using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.Builder
{
    class Director
    {
        public void Construct(Builder_Builder builder)
        {
            builder.BuilderCourseLanguage();
            builder.BuilderCourseDevelopment();
        }
    }
}
