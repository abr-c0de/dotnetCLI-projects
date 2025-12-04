using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StdManagementSys
{
    public class Student
    {
        public int Id { get;  set; }
        public string Name { get; set; }

        public int Age { get; set; }

        
        public Student(int _Id, string _Name, int _Age)
        {
            Id = _Id;
            Name = _Name;
            Age = _Age;
            
        }

        public override string ToString()
        {
            return $"StdId : {Id}, Name : {Name}, Age : {Age}";
        }
    }
}
