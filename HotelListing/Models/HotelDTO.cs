using System.Collections.Generic;

namespace HotelListing.Models
{
    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO CountryDTO { get; set; }
        public  IList<HotelDTO> HotelDTOs { get; set; }

    }
}
