using Lesson21_DesignPatterns.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data
{
    public class ContactRepository : IRepository<Contact>
    {
        private static List<Contact> contacts = new List<Contact>();

        public void Add(Contact item)
        {
            var id = contacts.Any() ? contacts.Last().Id++ : 1;
            item.Id = id;
            contacts.Add(item);
        }

        public void Delete(int id)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == id);
            contacts.Remove(contact);
        }

        public Contact Get(int id)
        {
            return contacts.FirstOrDefault(c => c.Id == id);
        }

        public List<Contact> GetAll()
        {
            return contacts;
        }

        public void Update(Contact item)
        {
            var contact = contacts.FirstOrDefault(c => c.Id == item.Id);
            contacts.Remove(contact);
            contacts.Add(item);
        }
    }
}
