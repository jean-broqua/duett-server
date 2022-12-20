using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Duett_Server_Domain.Models.DTOs.DTOMappers.Contracts
{
    public interface IDTOMapper<TEntity, TDTO>
    {
        TDTO ToView(TEntity entity);

        TEntity ToEntity(TDTO dto);
    }
}