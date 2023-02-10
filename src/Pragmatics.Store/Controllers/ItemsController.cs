using System;
using System.Linq;
using System.Collections.Generic;
using Pragmatics.Store.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Pragmatics.Store.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase
    {
        private static List<ItemDto> dataStore = new List<ItemDto>
        {
            new ItemDto {ID = Guid.NewGuid(), Name = "Cold Drink", Description = "Cold drink", Price = 2.0, CreatedDate = DateTime.UtcNow},
            new ItemDto {ID = Guid.NewGuid(), Name = "Ice Cream", Description = "Havemor Icecream", Price = 1.80, CreatedDate = DateTime.UtcNow},
            new ItemDto {ID = Guid.NewGuid(), Name = "Chocolate", Description="Lindt Chocolate", Price = 1.20, CreatedDate = DateTime.UtcNow},
            new ItemDto {ID = Guid.NewGuid(), Name = "Fruit Juice", Price = 2.0, CreatedDate = DateTime.UtcNow}
        };

        [HttpGet]
        [Route("")]
        public IEnumerable<ItemDto> Get()
        {
            return dataStore;
        }

        [HttpGet("{id}")]
        public ItemDto GetById(Guid id)
        {
            return dataStore.SingleOrDefault(item => item.ID == id);
        }

        [HttpPost]
        public ActionResult Create(CreateItemDto item)
        {
            var itemDto = new ItemDto
            {
                ID = Guid.NewGuid(),
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                CreatedDate = DateTime.UtcNow
            };

            dataStore.Add(itemDto);

            return CreatedAtAction(nameof(GetById), new {id = itemDto.ID}, item);
        }

        [HttpPut("{id}")]

        public ActionResult Update(Guid id, UpdateItemDto item)
        {
            var itemDto = dataStore.SingleOrDefault(itm => itm.ID == id);

            itemDto.Name = item.Name;
            itemDto.Description = item.Description;
            itemDto.Price = item.Price;

            var idx = dataStore.FindIndex(itm => itm.ID == id);
            dataStore[idx] = itemDto;

            return NoContent();
        }
    }
}