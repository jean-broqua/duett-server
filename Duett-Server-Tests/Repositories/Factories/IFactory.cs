using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duett_Server_Tests.Repositories.Factories
{
    internal interface IFactory<TEntity>
    {
        public TEntity Create();
    }
}
