using Microsoft.AspNetCore.Mvc;
using RestaurantReservationTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReservationTracker.Controllers
{
    public class ReservationController : Controller
    {
        private static List<Reservation> ReservationList = new List<Reservation>
        {
            new Reservation(1, "2021-01-18T04:00", "Ryan", 16, false, "", "444", true)
        };
        public IActionResult Index()
        {
            return View(ReservationList);
        }
    }
}
