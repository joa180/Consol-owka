using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the PhoneBook app");

            Console.WriteLine("1 Add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 Display all contacts");
            Console.WriteLine("4 Search contacts");
            Console.WriteLine("To exit insert x");

            var userInput = Console.ReadLine();

            var function = new Funcion();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Insert number");
                        var number = Console.ReadLine();
                        Console.WriteLine("Insert name");
                        var name = Console.ReadLine();

                        var newContact = new Contact(name, number);

                        function.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Insert number");
                        var numberToSearch = Console.ReadLine();

                        function.DisplayContact(numberToSearch);

                        break;
                    case "3":
                        function.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Insert serch phrase");
                        var searchPhone = Console.ReadLine();

                        function.DisplayMatchContacts(searchPhone);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid operacion");
                        break;
                }
                Console.WriteLine("Select operacion");
                userInput = Console.ReadLine();
            }
        }
    }
    //TODO walidacja nazwy i numeru
    //TODO dodanie funkcji np usuwania
}
