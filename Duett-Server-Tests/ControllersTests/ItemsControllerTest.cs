using Duett_Server_Domain.Controllers;
using Duett_Server_Domain.Models.DTOS;
using Duett_Server_Domain.Models.DTOS.DTOMappers;
using Duett_Server_Tests.Repositories;
using Duett_Server_Tests.Repositories.Factories;
using Microsoft.AspNetCore.Mvc;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duett_Server_Tests.ControllersTests
{
    [TestClass]
    public  class ItemsControllerTest
    {
        [TestMethod]
        public void TestDetailsViewData()
        {
            var mapper = new ListItemDTOMapper();
            var listItem = new ListItemFactory().Create();

            var fakeRepository = new FakeListItemRepository();
            fakeRepository.Create(listItem);

            var controller = new ItemsController(mapper);
            var result = controller.Index(fakeRepository);


            result.Should().NotBeNull();
        }
    }
}
