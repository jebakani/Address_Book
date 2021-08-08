﻿using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookJSONServer
    {
        RestClient client;
        public AddressBookJSONServer()
        {
            client = new RestClient("http://localhost:3000");
        }
        public IRestResponse GetAllEmployee()
        {
            RestRequest request = new RestRequest("/Contacts");
            IRestResponse response = client.Execute(request);
            return response;
        }
        public List<ContactDetails> ReadFromServer()
        {
            IRestResponse response = GetAllEmployee();
            var res = JsonConvert.DeserializeObject<List<ContactDetails>>(response.Content);
            return res;
        }
    }
}
