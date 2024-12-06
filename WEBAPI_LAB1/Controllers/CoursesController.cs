using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI_LAB1.Models;

namespace WEBAPI_LAB1.Controllers
{
    [Route("api/courses")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        static List<Course> courses = new List<Course>() { 
            new Course() {ID = 1, Name = ".Net", Duration = 64},
            new Course() {ID = 2, Name = "HTML", Duration = 96},
            new Course() {ID = 3, Name = "C#", Duration = 144},
        };

        [HttpGet]
        public List<Course> GetAll()
        {
            return courses;
        }

        [HttpGet("{name}")]
        public Course GetByName(string name)
        {
            return courses.Find(c => c.Name == name);
        }

        [HttpPost]
        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
    }
}
