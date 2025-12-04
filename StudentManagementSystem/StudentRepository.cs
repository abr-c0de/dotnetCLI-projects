using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StdManagementSys
{
    public class StudentRepository : Irepository<Student>
    {
        
        private List<Student> students = new List<Student>();

        public void Add( Student student) => students.Add(student);
        

        public void Delete(int id)
        {
            var obj = GetById(id);
            
            if(obj != null) students.Remove(obj);

        }

        public void Update(Student _Nstudent)
        {
            var Std = GetById(_Nstudent.Id);

            if(Std != null)
            {
                Std.Name = _Nstudent.Name; 
                Std.Age = _Nstudent.Age;
            }

        }

        public Student GetById(int id)=> students.Find(s => s.Id == id);

        public List<Student> GetAll()
        {
            return students;
        }

    }
}
