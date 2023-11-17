using Collection_Homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Homework.Services.Interfaces
{
    internal interface IPhoneBookInterface
    {
        List<PhoneBook> SavePhoneNumber(string name,string lastName ,string phoneNumber);
        List<PhoneBook> DeletePhoneNumber(string name, string lastName);

        List<PhoneBook> UpdatePhoneNumber(ref string name, ref string lastName, ref string phoneNumber);
        List<PhoneBook> DirectoryList();
        List<PhoneBook> DirectorySearch();
    }
}
