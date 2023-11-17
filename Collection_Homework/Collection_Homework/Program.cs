using Collection_Homework.Datas;
using Collection_Homework.Models;
using Collection_Homework.Services;
using Collection_Homework.Services.Interfaces;

IPhoneBookInterface phoneBookInterface = new PhoneBookService();



string option;


do
{
    Console.WriteLine("   Please select the action you want to do \r\n    (1) Registering a New Number ( 2) Delete Existing Number (3) Update Existing Number (4) List Directory (5) Search Directory﻿");

    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Please enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Please eneter surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Please eneter phone number");
            string phoneNumber = Console.ReadLine();

            phoneBookInterface.SavePhoneNumber(name, surname, phoneNumber);
            break;

        case "2":
            Console.WriteLine("Please enter the name and surname of the person whose number you want to delete");
            Console.WriteLine("Person name:");
            string name1 = Console.ReadLine();
            Console.WriteLine("Person surname");
            string surname1 = Console.ReadLine();


        default:
            Console.WriteLine("Your choice isn't correct!");
            break;
    }







} while (option != "");