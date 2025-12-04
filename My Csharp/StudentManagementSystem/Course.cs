using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdManagementSys
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Duration { get; set; }


        public Course(int _Id, string _Title, string _Duration)
        {
            Id = _Id;
            Title = _Title;
            Duration = _Duration;
        }

        public override string ToString()
        {
            return $"CourseId : {Id}, Title : {Title} Duration : {Duration}";
        }
    }
}
