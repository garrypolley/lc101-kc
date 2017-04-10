using System.Collections.Generic;

using UserAddress.Models;

namespace UserAddress.ViewModels
{
    class UserViewModel {
        IList<User> Users { get; set; }

        public UserViewModel(IList<User> users)
        {
            Users = users;
        }
    }
}