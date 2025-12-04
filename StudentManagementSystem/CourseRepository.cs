using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdManagementSys
{
    public class CourseRepository : Irepository<Course>
    {
        private List<Course> courses = new List<Course>();
        public void Add(Course course) => courses.Add(course);
        

        public void Delete(int id)
        {
            var Crs = GetById(id);
            if(Crs != null) courses.Remove(Crs);
        }

        public List<Course> GetAll() => courses;
        

        public Course GetById(int id) => courses.Find(c => c.Id == id);
       

        //here the _Ncourse contain the Id of a course that need to be updated and new values;
        public void Update(Course _Ncourse)
        {
            var Crs = GetById(_Ncourse.Id);

            if(Crs != null)
            {
                Crs.Title = _Ncourse.Title;
                Crs.Duration = _Ncourse.Duration;
            }
        }
    }
}
