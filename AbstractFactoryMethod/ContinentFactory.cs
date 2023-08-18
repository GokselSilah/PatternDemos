using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.AbstractFactoryMethod
{
    abstract class ContinentFactory
    {
        public abstract List<AbstractFactoryModel_DevelopmentCourse> CreateDevelopmentCourse();
        public abstract List<AbstractFactoryModel_LanguageCourse> CreateLanguageCourse();


    }
}
