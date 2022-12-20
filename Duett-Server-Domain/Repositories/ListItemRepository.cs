using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duett_Server_Domain.Data;
using Duett_Server_Domain.Models.Entities;
using Duett_Server_Domain.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Duett_Server_Domain.Repositories
{
    public class ListItemRepository : IListItemRepository
    {
        public ListItemRepository(ItemContext context)
        {
            _context = context;
        }

        public ItemContext _context { get; set; }

        public IEnumerable<ListItem> Index()
        {
            return _context.ListItems.ToList();
        }
    }
}