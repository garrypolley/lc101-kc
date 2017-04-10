using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;

using UserAddress.Models;
using UserAddress.Data;

namespace UserAddress.Controllers
{
    public class UserController : Controller
    {

        private readonly UserAddressDbContext _dbContext;

        public UserController(UserAddressDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            IList<User> users;
            return View();
        }
    }
}
