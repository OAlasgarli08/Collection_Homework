using Collection_Homework.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Homework.Datas
{
    internal static class AppDbContext
    {
        public static List<PhoneBook> PhoneBooks()
        {
            return new List<PhoneBook>()
            {
                new PhoneBook() {Name = "Name 1", LastName = "Surname 1", PhoneNumber = "050 777 99 97"},
                new PhoneBook() {Name = "Name 2", LastName = "Surname 2", PhoneNumber = "055 789 91 96"},
                new PhoneBook() {Name = "Name 3", LastName = "Surname 3", PhoneNumber = "070 550 10 89"},
                new PhoneBook() {Name = "Name 4", LastName = "Surname 4", PhoneNumber = "070 333 89 97"},
                new PhoneBook() {Name = "Name 5", LastName = "Surname 5", PhoneNumber = "050 899 11 11"}
            };
        }
    }
}
