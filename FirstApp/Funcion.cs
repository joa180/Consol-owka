using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    internal class Funcion
    {
        public List<Contact> Contacts {  get; set; } = new List<Contact>();

        public void AddContact(Contact contact) {  Contacts.Add(contact); }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        public void DisplayContact(string number)
        {
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if (contact == null)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                DisplayContactDetails(contact);
            }
        }
        public void DisplayAllContacts()
        {
            DisplayContactDetails(Contacts);
        }

        public void DisplayMatchContacts(string searchPhone)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhone)).ToList();
            DisplayContactDetails(matchingContacts);
        }
    }
}
