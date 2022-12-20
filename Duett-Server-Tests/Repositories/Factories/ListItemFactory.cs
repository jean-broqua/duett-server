using Duett_Server_Domain.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duett_Server_Tests.Repositories.Factories
{
    public class ListItemFactory: IFactory<ListItem>
    {
        private readonly Random rnd = new Random();
        public ListItem Create()
        {
            return new ListItem("DescriptionText", rnd.Next(1, 101), rnd.Next(100, 201));
        }
    }
}
