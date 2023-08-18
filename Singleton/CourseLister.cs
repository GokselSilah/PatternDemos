using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternDemos.Singleton
{
    public sealed class CourseLister
    {

        private static readonly CourseLister _courseLister = new CourseLister();

        private readonly List<Course> _courses;

        private CourseLister()
        {
            _courses = new List<Course>
            {
                new Course() {CourseName = "SqlCourse", CourseSubject="SQL Hakkında Herşey"},
                new Course() {CourseName = "DotNetCourse", CourseSubject=".Net Öğreniyorum"},
                new Course() {CourseName = "EnglishCourse", CourseSubject="0 dan C2 seviyesi ingilizce"},
                new Course() {CourseName = "DeutchCourse", CourseSubject="B2 Almanca Kursu"},
                new Course() {CourseName = "FrenchCourse", CourseSubject="Fransızca günlük konuşma kursu"},
                new Course() {CourseName = "PythonCourse", CourseSubject="0 dan Sektörün yükseklerine Python"},
                new Course() {CourseName = "JavaCourse", CourseSubject="Java SpringBoot camp"},
                new Course() {CourseName = "JsCourse", CourseSubject="Es6+ ve DOM manipülasyonları"}

            };
            
        }

        public static List<Course> GetCourses()
        {
            return _courseLister._courses;
        }

    }
}
