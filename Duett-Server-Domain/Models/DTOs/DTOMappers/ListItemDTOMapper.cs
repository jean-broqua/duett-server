using System;
using Duett_Server_Domain.Models.DTOs.DTOMappers.Contracts;
using Duett_Server_Domain.Models.Entities;

namespace Duett_Server_Domain.Models.DTOS.DTOMappers
{
    public class ListItemDTOMapper : IDTOMapper<ListItem, ListItemDTO>
    {
        public ListItemDTO ToView(ListItem listItem)
        {
            return new ListItemDTO(listItem.Id.ToString(), listItem.Description, listItem.AValue, listItem.BValue);
        }

        public ListItem ToEntity(ListItemDTO listItemDto)
        {
            var listItem = new ListItem(listItemDto.description, listItemDto.a, listItemDto.b);
            listItem.setId(new Guid(listItemDto.id));
            return listItem;
        }
    }
}