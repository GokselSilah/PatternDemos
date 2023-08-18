using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.AbstractFactoryMethod
{
    class LanguageCourseFactory : ContinentFactory
    {


        public override List<AbstractFactoryModel_LanguageCourse> CreateLanguageCourse()
        {
            List<AbstractFactoryModel_LanguageCourse> courses = new List<AbstractFactoryModel_LanguageCourse>()
            {
                new AbstractFactoryModel_DeutchCourse(),
                new AbstractFactoryModel_EnglishCourse(),
                new AbstractFactoryModel_FrenchCourse()
            };

            return courses;
        }

        public override List<AbstractFactoryModel_DevelopmentCourse> CreateDevelopmentCourse()
        {
            List<AbstractFactoryModel_DevelopmentCourse> courses = new List<AbstractFactoryModel_DevelopmentCourse>()
            {
                new AbstractFactoryModel_DotNetCourse(),
                new AbstractFactoryModel_JavaCourse(),
                new AbstractFactoryModel_PythonCourse(),
                new AbstractFactoryModel_JsCourse(),
                new AbstractFactoryModel_SqlCourse()
            };

            return courses;
        }

    }
}

