using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sistran.Models;
using Microsoft.Data.SqlClient;
using System.Data;

namespace sistran.Controllers
{
    public class AseguradoController : Controller
    {
        private readonly AseguradoContext _context; 

        public AseguradoController(AseguradoContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
