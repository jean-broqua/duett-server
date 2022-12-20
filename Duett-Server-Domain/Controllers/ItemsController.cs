using System;
using Microsoft.AspNetCore.Mvc;

using Duett_Server_Domain.Repositories;
using Duett_Server_Domain.Models.DTOS.DTOMappers;
using Duett_Server_Domain.Models.DTOS;
using Duett_Server_Domain.Models.DTOs.DTOMappers.Contracts;
using Duett_Server_Domain.Models.Entities;
using Duett_Server_Domain.Repositories.Contracts;

namespace Duett_Server_Domain.Controllers
{
    [Route("[controller]")]
    public class ItemsController : Controller
    {
        public IDTOMapper<ListItem, ListItemDTO> _dtoMapper { get; set; }

        public ItemsController(IDTOMapper<ListItem, ListItemDTO> dtoMapper)
        {
            _dtoMapper = dtoMapper;
        }

        [HttpGet()]
        public ActionResult<ListItemDTO[]> Index([FromServices] IListItemRepository repo)
        {
            var items = repo.Index();
            var itemsDto = new List<ListItemDTO>();

            foreach (var item in items)
            {
                itemsDto.Add(_dtoMapper.ToView(item));
            }

            return Ok(itemsDto);
        }
    }
}