using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBook;
using System.Collections.Generic;
using System;

namespace AddressBookRetrivalTest
{
    [TestClass]
    public class AddressBookTest
    {
        OperationManagement operation;
        [TestInitialize]
        public void TestSetUp()
        {
            operation = new OperationManagement();
        }
        //UC16-Retrive all data from database
        [TestMethod]
        public void RetrivingtheDataFromDataBaseTest()
        {
            int expected = 3;
            List<ContactDetails> list = operation.RetrivingDataFromDataBase();
            Assert.AreEqual(expected, list.Count);
        }
        //UC17-Update contact data from database
        [TestMethod]
        public void UpdateDataTest()
        {
            int expected = 1;
           int actual=operation.updateContact(3,"Stephan",9845625362);
            Assert.AreEqual(expected, actual);
        }
        //UC18-Retrival based on date range
        [TestMethod]
        public void DateRangeRetrivalTest()
        {
            int expected = 2;
            DateTime startDate = new DateTime(2017, 01, 01);
            DateTime enddate = new DateTime(2019, 01, 01);
            List<ContactDetails> actual = operation.RetrivingDataBasedOnDate(startDate, enddate);
            Assert.AreEqual(expected, actual.Count);
        }

    }
}
