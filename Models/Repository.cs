using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MVCBasic.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();
        static Repository()
        {
            _courses = new List<Course>()
            {
                new Course() {
                     CourseId = 1,
                     Title = "Full Stack",
                     Description = "Güzel",
                     Image = "1.jpg" ,
                     Tags = new string[] {"full stack","web geliştirme"},
                     isActive = true,
                     isHome = true
                     },
                new Course() {
                    CourseId = 2,
                    Title = "Python",
                    Description = "Güzel",
                    Image = "2.jpg",
                    Tags = new string[] {"Python","web geliştirme"},
                    isActive = false,
                    isHome = true
                    },
                new Course() {
                    CourseId = 3,
                    Title = "JavaScript",
                    Description = "Güzel",
                    Image = "3.jpg",
                    Tags = new string[] {"JavaScript","web geliştirme"},
                    isActive = true,
                    isHome = false
                    },
                new Course() {
                    CourseId = 4,
                    Title = "Node.js",
                    Description = "Güzel",
                    Image = "4.jpg",
                    Tags = new string[] {"Node.js","web geliştirme"},
                    isActive = true,
                    isHome = true
                    }
            };
        }
        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.CourseId == id);
        }
    }
}