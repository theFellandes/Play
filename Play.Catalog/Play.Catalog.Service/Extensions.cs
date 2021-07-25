using Play.Catalog.Service.Dtos;
using Play.Catalog.Service.Entities;

namespace Play.Catalog.Service
{
    //All extensions need to be static
    public static class Extensions
    {
        //Simple method that translates item to ItemDto
        public static ItemDto AsDto(this Item item)
        {
            return new(item.Id, item.Name, item.Description, item.Price, item.CreatedDate);
        }
    }
}