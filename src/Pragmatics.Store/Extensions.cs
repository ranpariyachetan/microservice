using Pragmatics.Store.Dtos;
using Pragmatics.Store.Entities;

namespace Pragmatics.Store
{
    public static class Extensions
    {
        public static ItemDto AsDto(this Item item)
        {
            return new ItemDto
            {
                ID = item.Id,
                Name = item.Name,
                Description = item.Description,
                Price = item.Price,
                CreatedDate = item.CreatedDate
            };
        }
    }
}