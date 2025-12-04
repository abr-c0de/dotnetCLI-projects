using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Library
    {
        List<Book> books = new List<Book>();

        int _id = 1;
        

        public void AddBook(string _title,string _author)
        {
            
            Book newbook = new Book(_id,_title,_author,false);
            books.Add(newbook);
            _id++;
            
            

        }

        public void ListBooks()
        {
            if(books.Count == 0)
            {
                Console.WriteLine("No book available at the moment.");
                
            } 

            foreach(Book book in books)
            {
                Console.WriteLine($" \n -------------------------------------- \n Id : {book.ID} \n Title : {book.Title} \n Author : {book.Author}" +
                    $" \n Status : {(book.IsBorrowed ? "Borrowed" : "Available")} \n -------------------------------------------");
                
            }
        }

        public void RemoveBook(int id)
        {
            Book book = books.FirstOrDefault(b =>  b.ID == id);

            if(book == null)
            {
                Console.WriteLine("Book not found!");
                return;
                
            }
            else
            {
                books.Remove(book);
                Console.WriteLine("Book removed successfully.");
                
            }
        }

        public void BorrowBook(int id)
        {
            Book book = books.FirstOrDefault(b => b.ID == id);

            if (book == null)
            {
                Console.WriteLine("Book not found!");
                return;
                
            }
            else if (book.IsBorrowed)
            {
                Console.WriteLine("Book is already borrowed");
                
            }
            else if (!book.IsBorrowed)
            {
                Console.WriteLine("Book borrowed successfully.");
                book.IsBorrowed = true;
                
            }
        }

        public void ReturnBook(int id)
        {
            Book book = books.FirstOrDefault(b => b.ID == id);

            if (book == null)
            {
                Console.WriteLine("Book not found!");
                return;
               
            }
            else if (book.IsBorrowed)
            {
                book.IsBorrowed = false;
                Console.WriteLine("Book returned successfully");
                
            }
            else if (!book.IsBorrowed)
            {
                Console.WriteLine("Book not borrowed");
                
            }
        }

        public void SearchBook(int id)
        {
            Book book = books.FirstOrDefault(b => b.ID == id);

            if(book == null)
            {
                Console.WriteLine("Book not found!");
                return;
            }
            Console.WriteLine($" \n -------------------------------------- \n Id : {book.ID} \n Title : {book.Title} \n Author : {book.Author}" +
                   $" \n Status : {(book.IsBorrowed ? "Borrowed" : "Available")} \n -------------------------------------------");
            
        }

    }
}
