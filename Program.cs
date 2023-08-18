using PatternDemos.AbstractFactoryMethod;
using PatternDemos.Builder;
using PatternDemos.FactoryMethod;
using PatternDemos.Prototype;
using PatternDemos.Singleton;

namespace PatternDemos
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("------------------------------------ FactoryMethod ------------------------------------");

            CourseType[] courseTypes = new CourseType[2];

            courseTypes[0] = new DevelopmentCourse();
            courseTypes[1] = new LanguageCourse();


            foreach (var courseType in courseTypes)
            {
                Console.WriteLine("----" + courseType.GetType().Name + "----");
                foreach (var course in courseType.Courses)
                {
                    Console.WriteLine(" " + course.GetType().Name);
                }
            }

            Console.WriteLine("------------------------------------ Singleton ------------------------------------");


            List<Singleton.Course> courses = CourseLister.GetCourses();

            foreach (var course in courses)
            {
                Console.WriteLine(course.CourseName + "--" + course.CourseSubject);
            }

            Console.WriteLine("------------------------------------ Builder ------------------------------------");

            Director director = new Director();

            Builder_Builder b1 = new Builder_CourseBuilder();

            director.Construct(b1);
            Builder_Course b_course = b1.GetCoursesTypes();
            b_course.Show();

            Console.WriteLine("------------------------------------ Prototype ------------------------------------");

            CourseManager courseManager = new CourseManager();

            courseManager["SqlCourse"] = new Prototype_Course("SQL Kursu", "SQL Hakkında Herşey");
            courseManager["DotNetCourse"] = new Prototype_Course(". Net Kursu",".Net Öğreniyorum");
            courseManager["EnglishCourse"] = new Prototype_Course("İngilizce Kursu", "0 dan C2 seviyesi ingilizce");
            courseManager["DeutchCourse"] = new Prototype_Course("Almanca Kursu", "B2 Almanca Kursu");
            courseManager["FrenchCourse"] = new Prototype_Course("Fransızca Kursu", "Fransızca günlük konuşma kursu");
            courseManager["PythonCourse"] = new Prototype_Course("Python Kursu", "0 dan Sektörün yükseklerine Python");
            courseManager["JavaCourse"] = new Prototype_Course("Java Kursu", "Java SpringBoot camp");
            courseManager["JsCourse"] = new Prototype_Course("JavaScript Kursu", "Es6+ ve DOM manipülasyonları");

            Prototype_Course course1 = courseManager["SqlCourse"].Clone() as Prototype_Course;
            Prototype_Course course2 = courseManager["DotNetCourse"].Clone() as Prototype_Course;
            Prototype_Course course3 = courseManager["EnglishCourse"].Clone() as Prototype_Course;
            Prototype_Course course4 = courseManager["DeutchCourse"].Clone() as Prototype_Course;
            Prototype_Course course5 = courseManager["FrenchCourse"].Clone() as Prototype_Course;
            Prototype_Course course6 = courseManager["PythonCourse"].Clone() as Prototype_Course;
            Prototype_Course course7 = courseManager["JavaCourse"].Clone() as Prototype_Course;
            Prototype_Course course8 = courseManager["JsCourse"].Clone() as Prototype_Course;


            Console.WriteLine("------------------------------------ AbstractFactoryMethod ------------------------------------");

            ContinentFactory developmentFactory = new DevelopmentCourseFactory();
            AbstractFactoryModel_Course ab_courses = new AbstractFactoryModel_Course(developmentFactory);
            ab_courses.GetTypesCourses();
            ContinentFactory languageFactory = new LanguageCourseFactory();
            AbstractFactoryModel_Course la_courses = new AbstractFactoryModel_Course(languageFactory);
            la_courses.GetTypesCourses();

        }
    }
}