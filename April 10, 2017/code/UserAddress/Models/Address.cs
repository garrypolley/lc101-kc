using System.Collections.Generic;

namespace UserAddress.Models
{
    public class Address : BaseModel
    {
        public int Id { get; set; }
        // To Better support localized addresses (e.g. any country) storing the entire
        // address as a string is safer and less likely to cause user errors.
        // Use ViewModels to validate different types of addresses based on Country.
        public string Value { get; set; }
        public string Country { get; set; }

        public ICollection<AddressUser> AddressUsers { get; set; }
    }
}