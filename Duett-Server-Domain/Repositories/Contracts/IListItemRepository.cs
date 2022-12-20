using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Duett_Server_Domain.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Duett_Server_Domain.Repositories.Contracts
{
    public interface IListItemRepository
    {
        IEnumerable<ListItem> Index();
    }
}