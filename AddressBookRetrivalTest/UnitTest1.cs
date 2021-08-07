using Microsoft.VisualStudio.TestTools.UnitTesting;
using AddressBook;
using System.Collections.Generic;

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
    }
}
