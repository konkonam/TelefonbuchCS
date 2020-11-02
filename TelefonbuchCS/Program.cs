using System;

namespace TelefonbuchCS
{
    class Program
    {
        static void Main(string[] args)
        {
            ContactBook cb = new ContactBook();

            cb.loadContacts();

            while(true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to your Contact Book");
                Console.WriteLine("1 - Show all Contacts");
                Console.WriteLine("2 - Delete a Person by Name");
                Console.WriteLine("3 - Select a person by Name");
                Console.WriteLine("4 - Create a new Person");
                Console.WriteLine("5 - Exit the Application\n");

                Console.Write("Your choice: ");
                int selection = Convert.ToInt32(Console.ReadLine());
                
                string name = "";

                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Print all:");
                        cb.printEntries();
                        break;
                    case 2:
                        Console.WriteLine("Delete:");
                        Console.Write("Please enter the name of the person you want to delete: ");
                        name = Console.ReadLine();
                        cb.deleteEntryByName(name);
                        cb.saveContacts();
                        break;
                    case 3:
                        Console.WriteLine("Select:");
                        name = Console.ReadLine();
                        cb.printEntryByName(name);
                        break;
                    case 4:
                        Console.WriteLine("Create:");
                        cb.createEntry();
                        cb.saveContacts();
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        cb.saveContacts();
                        return;
                    default:
                        Console.WriteLine("This is not a valid Option!");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();

                System.Threading.Thread.Sleep(50);
                
            }
        }
    }
}
