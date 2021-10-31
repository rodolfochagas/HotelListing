using System.Collections.Generic;

namespace HotelListing.Core.DTOs
{
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<HotelDTO> Hotels { get; set; }
    }
}
