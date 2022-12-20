using Duett_Server_Domain.Models.Entities;
using System;

namespace Duett_Server_Tests.EntitiesTests
{
    [TestClass]
    public class ListItemTests
    {
        [TestMethod]
        public void Is_Creating_ListITem()
        {
            var listItem = new ListItem("Some Description", 10, 20);

            Assert.AreEqual(listItem.Description, "Some Description");
            Assert.AreEqual(listItem.AValue, 10);
            Assert.AreEqual(listItem.BValue, 20);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Description should have at least 3 characters")]
        public void ListItem_Description_Lenght_Validation()
        {
            var listItem = new ListItem("a", 10, 20);
        }
    }
}
