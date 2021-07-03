﻿using System;

namespace AddressBook
{
    class Program
    {
        /// <summary>
        /// Welcome to Address Book Management System
        /// UC1 - Gets the contact detail
        /// UC2- Get and stores multiple contacts
        /// UC3- Edit the contacts
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address book");
            //calling operation management class that contains operation
            OperationManagement.ReadInput();
            Console.Read();
        }
    }
}
