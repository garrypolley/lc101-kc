using System.Collections.Generic;

namespace UserAddress.Models
{
    public class User : BaseModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }

        public ICollection<AddressUser> AddressUsers { get; set; }

        public User DoSomething()
        {
            return this;
        }
    }
}