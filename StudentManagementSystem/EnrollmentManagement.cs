using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdManagementSys
{
    public class EnrollmentManagement
    {
        private Dictionary<int,List<int>> StudentCourseMap = new Dictionary<int,List<int>>();

        public void Enroll(int studentId, int courseId)
        {
            if(!StudentCourseMap.ContainsKey(studentId))
                StudentCourseMap[studentId] = new List<int>();

            if(!StudentCourseMap[studentId].Contains(courseId))
                StudentCourseMap[studentId].Add(courseId);
        }

        public void UnEnroll(int studentId, int courseId)
        {
            if (StudentCourseMap.ContainsKey(studentId) &&
            StudentCourseMap[studentId].Contains(courseId))
            {
                StudentCourseMap[studentId].Remove(courseId);

                if (StudentCourseMap[studentId].Count == 0)
                    StudentCourseMap.Remove(studentId);
            }
        }

        public void RemoveStudentFromAllCourse(int studentId)
        {
            if(StudentCourseMap.ContainsKey(studentId))
                StudentCourseMap.Remove(studentId);
        }

        public List<int> GetCoursesByStudent(int studentId)
        {
            return StudentCourseMap.ContainsKey(studentId) ? StudentCourseMap[studentId] : new List<int>();
            
        }
    }
}
