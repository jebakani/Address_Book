﻿using CsvHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class FileOperation
    {
        string filepath = @"C:\Users\HP1\source\repos\AddressBook\AddressBook\AddressBook.txt";
        string jsonFile = @"C:\Users\HP1\source\repos\AddressBook\AddressBook\ContactDetails.json";
        string csvFile = @"C:\Users\HP1\source\repos\AddressBook\AddressBook\ContactDetai.csv";

        //method to write the data into the file
        public void WriteIntoFile(Dictionary<string, List<ContactDetails>> addressDictionary)
        {
            if (File.Exists(filepath))
            {
                //using streamWriter write the data into the file 
                StreamWriter writer = new StreamWriter(filepath);
                foreach(var l in addressDictionary)
                {
                    //write line method append next dat in the next line
                    writer.WriteLine("AddressBook Name:" + l.Key);
                    foreach(var list in l.Value)
                    {
                        string s = "Name:" + list.firstName + " " + list.lastName + " Address:" + list.address + " City:" + list.city + " State:" + list.state + " Zipcode:" + list.zipCode + " Ph.No:" + list.phoneNumber;
                        writer.WriteLine(s);
                    }
                    writer.WriteLine();
                }
                //close the stream
                writer.Close();
                ReadFromFile(filepath);
            }
            else
            {
                Console.WriteLine("File not exists");
            }

        }
        //method to read the data from the file 
        public void ReadFromFile(string filePath)
        {
            //check if the file exists
            if(File.Exists(filePath))
            {
                //get all the data in single text and print the data
                string text = File.ReadAllText(filePath);
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("File not exist");
            }
        }

        public Dictionary<string, List<ContactDetails>> ReadFromJsonFile()
        {
            Dictionary<string,List<ContactDetails>> details= JsonConvert.DeserializeObject<Dictionary<string,List<ContactDetails>>>(File.ReadAllText(jsonFile));
            return details;
        }

        public void WriteIntoJsonFile(Dictionary<string, List<ContactDetails>> contactList)
        {
            File.WriteAllText(jsonFile, JsonConvert.SerializeObject(contactList));
            WriteIntoCSVFile(contactList);
        }

        public void WriteIntoCSVFile(Dictionary<string, List<ContactDetails>> contactList)
        {
            
            using (StreamWriter writer = new StreamWriter(csvFile))
            {
                using (var csvWriter=new CsvWriter(writer,CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteHeader<ContactDetails>();
                    csvWriter.NextRecord();
                    foreach (var l in contactList)
                    {
                        
                        csvWriter.WriteRecords(l.Value);
                      
                    }

                }
            }
        }
    }
}
