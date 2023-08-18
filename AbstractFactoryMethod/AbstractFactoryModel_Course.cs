using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.AbstractFactoryMethod
{
    class AbstractFactoryModel_Course
    {
        private List<AbstractFactoryModel_DevelopmentCourse> _developmentCourse;
        private List<AbstractFactoryModel_LanguageCourse> _languageCourse;

        public AbstractFactoryModel_Course(ContinentFactory factory)
        {
            _developmentCourse = factory.CreateDevelopmentCourse();
            _languageCourse = factory.CreateLanguageCourse();
        }

        public void GetTypesCourses()
        {
            foreach (var devolopmentCourse in _developmentCourse)
            {
                devolopmentCourse.CourseType(devolopmentCourse);
            }

            foreach (var languageCourse in _developmentCourse)
            {
                languageCourse.CourseType(languageCourse);
            }
        }
    }
}
