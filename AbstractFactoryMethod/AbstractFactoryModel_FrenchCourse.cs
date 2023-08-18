using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.AbstractFactoryMethod
{
    class AbstractFactoryModel_FrenchCourse : AbstractFactoryModel_LanguageCourse
    {
        public override void CourseType(AbstractFactoryModel_LanguageCourse course)
        {
            Console.WriteLine(this.GetType().Name + " Bir " + course.GetType().Name + " Kursudur.");
        }
    }
}
