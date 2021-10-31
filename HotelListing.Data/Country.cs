using System.Collections.Generic;

namespace HotelListing.Data
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }

        //Property that facilitates queries, but is not on the database (no need for migration)
        public virtual IList<Hotel> Hotels { get; set; }
    }
}
