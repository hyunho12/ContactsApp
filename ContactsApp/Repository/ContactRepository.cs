using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contact = ContactsApp.Models.Contact;

namespace ContactsApp.Repository
{
    public class ContactRepository
    {

        public List<Contact> contacts = new List<Contact>()
        {
            new Contact { Id = 1, Name="John Doe", Email="JohnDoe@gmail.com", Phone="010-2648-2584", Address="seoul"},
            new Contact { Id = 2,  Name="Jane Doe", Email="JaneDoe@gmail.com", Phone="010-3694-4685", Address="tokyo"},
            new Contact {  Id = 3, Name="Tom Hanks", Email="TomHanks@gmail.com", Phone="010-2687-6548", Address="paris"},
            new Contact {  Id = 4, Name="Frank Liu", Email="frankliu@gmail.com", Phone="010-7126-9851", Address="berlin"},
        };

    }
}
