using Duett_Server_Domain.Models.DTOS;
using Duett_Server_Domain.Models.DTOS.DTOMappers;
using Duett_Server_Domain.Models.Entities;
using System;
using System.Text.Json.Serialization;

namespace Duett_Server_Tests.EntitiesTests
{
    [TestClass]
    public class ListItemDTOTests
    {
        [TestMethod]
        public void Convert_ListItem_Entity_to_View ()
        {
            var ListItem = new ListItem("Some description", 10, 20);
            var mapper = new ListItemDTOMapper();

            var convertedListItem = mapper.ToView(ListItem);
            var expectedListItem = new ListItemDTO(ListItem.Id.ToString(), "Some description", 10, 20);

            Assert.AreEqual(convertedListItem.id, expectedListItem.id);
            Assert.AreEqual(convertedListItem.description, expectedListItem.description);
            Assert.AreEqual(convertedListItem.a, expectedListItem.a);
            Assert.AreEqual(convertedListItem.b, expectedListItem.b);
        }
    }
}
