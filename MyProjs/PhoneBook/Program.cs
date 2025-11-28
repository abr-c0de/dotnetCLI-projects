
bool exit = false;
Dictionary<string, string> phoneBook = new();

do
{
    Console.WriteLine("\n Enter 1 to Add contact \n Enter 2 to View contact \n Enter 3 to Update contact \n Enter 4 to Delete contact \n Enter 5 to View Phonebook \n Enter 6 to Exit");
    Console.WriteLine("Enter your choice");

    string? choice = Console.ReadLine();

    if(choice == "1")
    {
        Console.WriteLine("Enter the name:");
        string? name = Console.ReadLine();

        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine("Contact not found");
          
        }
        else
        {
            
            Console.WriteLine("Enter phone number:");
            string? phone = Console.ReadLine();

            phoneBook.Add(name, phone);
        }

        
    }
    else if(choice == "2")
    {
        Console.WriteLine("Enter the name");
        string? name = Console.ReadLine();

        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine($" \n Name: {name} Phone Number: {phoneBook[name]}");
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }
    else if(choice == "3")
    {
        Console.WriteLine("Enter the name");
        string? name = Console.ReadLine();

        if (phoneBook.ContainsKey(name))
        {
            Console.WriteLine("Enter new number:");
            string? newNum = Console.ReadLine();

            phoneBook[name] = newNum;
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }
    else if(choice == "4")
    {
        Console.WriteLine("Enter the name");
        string? name = Console.ReadLine();

        if (phoneBook.ContainsKey(name))
        {
            phoneBook.Remove(name);
        }
        else
        {
            Console.WriteLine("Contact not found");
        }

    }
    else if(choice == "5")
    {
        foreach (KeyValuePair<string,string> contact in phoneBook)
        {
            Console.WriteLine($"------------------------------ \n Name: {contact.Key} \n Phone Number: {contact.Value}");
            Console.WriteLine($"------------------------------");
        }
    }
    else if(choice == "6")
    {
        exit = true;
    }
    
}
while (exit == false);