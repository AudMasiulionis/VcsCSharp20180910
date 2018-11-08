using Data;
using Lesson21_DesignPatterns.Repositories;
using System;
using System.Collections.Generic;

namespace Business
{
    public class ContactService
    {
        private readonly IRepository<Contact> _repository;

        public ContactService(IRepository<Contact> contactRepository)
        {
            _repository = contactRepository;
        }

        public List<Contact> GetContacts()
        {
            return _repository.GetAll();
        }

        public void AddContact(Contact contact)
        {
            if (contact == null)
            {
                throw new ArgumentNullException(nameof(contact));
            }
            //check for duplicate
            _repository.Add(contact);
        }

        public void DeleteContact(int id)
        {
            //check for duplicate
            _repository.Delete(id);
        }

        //todo update
    }
}
