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
            new Reservation(0, "2021-01-18T04:00", "Ryan", 16, false, "", "444", true),
            new Reservation(1, "2021-01-18T04:00", "Ryan", 16, false, "", "444", true)
        };
        public IActionResult Index()
        {
            return View(ReservationList);
        }

        [HttpGet]
        public IActionResult AddReservation()
        {
            return View("ReservationForm");
        }

        [HttpGet]
        public IActionResult EditReservation(int? id)
        {
            Reservation r = new Reservation();
            foreach (var reservation in ReservationList)
            {
                if (reservation.ID == id)
                {
                    r = reservation;
                    break;
                }
            }
            return View("ReservationForm", r);
        }

        [HttpPost]
        public IActionResult AddReservation(Reservation reservation)
        {
            if(ModelState.IsValid)
            {
                if (reservation.ID == -1)
                {
                    int greatestIDValue = 0;
                    foreach (var r in ReservationList)
                    {
                        if (r.ID > greatestIDValue) { greatestIDValue = r.ID; }
                    }
                    reservation.ID = greatestIDValue + 1;
                }
                ReservationList.Add(reservation);
                return Redirect("~/Reservation/Index");
            }
            return View("ReservationForm");
        }
    }
}
