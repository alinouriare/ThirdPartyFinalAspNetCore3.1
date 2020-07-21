using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactApi.Models
{
    public class Contact
    {

        public int ContactId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid OwnerId { get; set; }


    }

    public class ContactDB : DbContext
    {

        public DbSet<Contact> Contacts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;initial catalog=ContactDB;integrated security=true;");
        }
    }

    public interface IContactRepository
    {
        List<Contact> GetContacts();


    }

    public class ContactRepository : IContactRepository
    {
        private readonly ContactDB contactDB;

        public ContactRepository(ContactDB contactDB)
        {
            this.contactDB = contactDB;
        }
        public List<Contact> GetContacts()
        {
            return contactDB.Contacts.ToList();
        }
    }
}
