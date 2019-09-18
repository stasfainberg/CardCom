using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardCom.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CardCom.Controllers
{
    public class UserController : Controller
    {

        private readonly DatabaseContext _context;

        public UserController(DatabaseContext context)
        {
            _context = context;
        }


        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }



    }
}
