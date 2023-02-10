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
            new ItemDto {ID = Guid.NewGuid(), Name = "Cold Drink", Price = 2.0},
            new ItemDto {ID = Guid.NewGuid(), Name = "Ice Cream", Price = 1.80},
            new ItemDto {ID = Guid.NewGuid(), Name = "Chocolate", Price = 1.20},
            new ItemDto {ID = Guid.NewGuid(), Name = "Fruit Juice", Price = 2.0}
        };

        [HttpGet]
        [Route("")]
        public IEnumerable<ItemDto> Get()
        {
            return dataStore;
        }

        [HttpGet]
        [Route("{id}")]
        public ItemDto GetById(Guid id)
        {
            return dataStore.SingleOrDefault(item => item.ID == id);
        }
    }
}