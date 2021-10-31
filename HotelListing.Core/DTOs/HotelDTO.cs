using System.Collections.Generic;

namespace HotelListing.Core.DTOs
{
    public class HotelDTO : CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }

    }
}
