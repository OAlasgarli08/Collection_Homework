using Collection_Homework.Datas;
using Collection_Homework.Models;
using Collection_Homework.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Homework.Services
{
    internal class PhoneBookService : IPhoneBookInterface
    {

        public List<PhoneBook> DeletePhoneNumber(string name, string lastName)
        {
            return AppDbContext.PhoneBooks().Except(new PhoneBook { Name = name, LastName = lastName });
        }

        public List<PhoneBook> DirectoryList()
        {
            throw new NotImplementedException();
        }

        public List<PhoneBook> DirectorySearch()
        {
            throw new NotImplementedException();
        }

        public List<PhoneBook> SavePhoneNumber(string name, string lastName, string phoneNumber)
        {
            return null;
            // add eleyende deyirki cannot turn void to generics
        }

        public List<PhoneBook> UpdatePhoneNumber(ref string name, ref string lastName, ref string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
