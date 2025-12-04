using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsBorrowed { get; set; }


        public  Book (int id, string title, string author, bool isborrowed)
        {
            ID = id;
            Title = title;
            Author = author;
            IsBorrowed = isborrowed;
        }

    }

    
}

