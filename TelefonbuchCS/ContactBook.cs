using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace TelefonbuchCS
{
    class ContactBook
    {
        private List<Person> contacts;

        public ContactBook()
        {
            this.contacts = new List<Person>();
        }

        public void addEntry(Person p)
        {
            this.contacts.Add(p);
        }

        public void deleteEntryByName(string name)
        {
            foreach (Person person in this.contacts.ToList())
            {
                if (string.Compare(name, person.name) == 0)
                {
                    this.contacts.Remove(person);
                }
            }
        }

        public void printEntries()
        {
            foreach (Person person in this.contacts)
            {
                person.print();
                Console.WriteLine("--------------------");
            }
        }

        public void printEntryByName(string name)
        {
            foreach (Person person in this.contacts)
            {
                if (string.Compare(name, person.name) == 0)
                {
                    person.print();

                }
            } 
        }

        public void createEntry()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Number: ");
            string number = Console.ReadLine();

            Console.Write("Enter Age: ");
            string ageStr = Console.ReadLine();

            int age = 0;
            if(Int32.TryParse(ageStr, out age))
            {
                age = Convert.ToInt32(ageStr);
            }
            else
            {

            }

            Person p = new Person(name, number, age);

            addEntry(p);

            Console.WriteLine($"{name} was successfully created!");
        }

        public void loadContacts()
        {
            var json = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "contacts.json"));
            this.contacts = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Person>>(json);
        }

        public void saveContacts()
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(this.contacts);
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "contacts.json"), json);
        }
    }
}
