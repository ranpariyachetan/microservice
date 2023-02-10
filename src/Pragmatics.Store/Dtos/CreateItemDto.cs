using System.ComponentModel.DataAnnotations;

namespace Pragmatics.Store.Dtos
{
    public class CreateItemDto
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Range(0, 1000)]
        public double Price { get; set; }
    }
}