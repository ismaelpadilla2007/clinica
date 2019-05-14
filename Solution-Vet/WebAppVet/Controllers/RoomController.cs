using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppVet.Data;

namespace WebAppVet.Controllers
{
    public class RoomController : Controller
    {
        private ClinicaDbContext db = new ClinicaDbContext();
        // GET: Room
        public ActionResult Index()
        {
            var room = db.Rooms.ToList();
            return View(room);
        }
    }
}