
using LibraryManagementSystem;

Library library = new Library();

string choice;

do
{
    Console.WriteLine("\n----------------------------WELCOME TO WINNERS LIBRARY --------------------------------\n");

    Console.WriteLine("\n-------------------------Disclaimer-------------------------\n To Access the book you must know the book id." +
                          "\n To get the book id and List Press 3\n------------------------------------------------------\n");

    Console.WriteLine("\n Press 1 to Add Book \n Press 2 to Remove Book \n Press 3 to List all Books" +
                      "\n Press 4 to Search Book \n Press 5 to Return Book \n Press 6 to Borrow Book " +
                      "\n Press 7 to Exit\n");

    

    Console.WriteLine("\n----------------------------WELCOME TO WINNERS LIBRARY --------------------------------\n");

    Console.WriteLine("Please enter your choice");
    choice = Console.ReadLine();



    if (choice == "1")
    {
        Console.WriteLine("Enter book name : ");
        string title = Console.ReadLine();

        Console.WriteLine("Enter author name : ");
        string author = Console.ReadLine();

        library.AddBook(title, author);
        Console.WriteLine("Book added to inventory successfully");
        
    }
    else if(choice == "2")
    {
        Console.WriteLine("Enter the book id");
        library.RemoveBook(int.Parse(Console.ReadLine()));
        
    }
    else if(choice == "3")
    {
        library.ListBooks();
        
    }
    else if(choice == "4")
    {
        Console.WriteLine("Enter the book id : ");

        library.SearchBook(int.Parse(Console.ReadLine()));
        
    }
    else if(choice == "5")
    {
        Console.WriteLine("Enter the book id : ");

        library.ReturnBook(int.Parse(Console.ReadLine()));
        
    }
    else if (choice == "6")
    {
        Console.WriteLine("Enter the book id : ");

        library.BorrowBook(int.Parse(Console.ReadLine()));
       
    }

} while(choice != "7");
