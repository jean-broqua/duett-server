using Duett_Server_Domain.Models.Entities;
using Duett_Server_Domain.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duett_Server_Tests.Repositories
{
    public class FakeListItemRepository : IListItemRepository
    {
        public List<ListItem> ListItems = new List<ListItem>();

        public IEnumerable<ListItem> Index()
        {
            return ListItems;
        }

        public void Create(ListItem item)
        {
            ListItems.Add(item);
        }
    }
}
