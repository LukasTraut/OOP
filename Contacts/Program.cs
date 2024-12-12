using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Contact> contacts = new List<Contact>();

            Console.WriteLine("Wolllen sie einen Kontakt hinzufkügen? [j/n]");
            string jein = Console.ReadLine();
            if (jein == "J" || jein == "j")
            {
                Contact contact = new Contact();

                Console.Write("Was ist dein Vorname: ");
                contact.Firstname = Console.ReadLine();

                Console.Write("Was ist dein Nachname: ");
                contact.Lastname = Console.ReadLine();

                Console.Write("Was ist dein Email: ");
                contact.Email = Console.ReadLine();

                contacts.Add(contact);
            }
            if (contacts.Count > 0)
            {
                Console.Clear();
                Console.Write("Möchtest du zuerst Vor oder nachnamen ausgeben? [v/n]");
                string answer = Console.ReadLine();
                if (answer == "v" || answer == "V")
                {
                    foreach (Contact contact in contacts)
                    {
                        Console.WriteLine(contact.Firstname);
                        Console.WriteLine(contact.Lastname);
                        Console.WriteLine(contact.Email);
                    }
                }
                if (answer == "n" || answer == "N")
                {
                    foreach (Contact contact in contacts)
                    {
                        Console.WriteLine(contact.Lastname);
                        Console.WriteLine(contact.Firstname);
                        Console.WriteLine(contact.Email);
                    }
                }


            }
        }
    }
}