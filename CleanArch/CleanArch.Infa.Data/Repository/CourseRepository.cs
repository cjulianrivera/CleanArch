using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infa.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infa.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
