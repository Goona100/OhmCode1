using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ohm.Models;

namespace Ohm.Controllers
{
    public class OhmController : Controller
    {
        // GET: Ohm
        public ActionResult Index()
        {
            //Ohm.Models.Interface.IOhmValueCalculator _ohmRepository = new Ohm.Models.Repository.OhmValueCalculator();
            //string ohmValue = _ohmRepository.CalculateOhmValue("Brown", "Red", "Orange", "Black").ToString();
            //@ViewBag.Ohm = ohmValue + " OHMS";
            return View();
        }

        [HttpPost]
        public ActionResult GetOhm(string BandA, string BandB, string BandC, string BandD) 
        {
            Ohm.Models.Interface.IOhmValueCalculator _ohmRepository = new Ohm.Models.Repository.OhmValueCalculator();
            string ohmValue = _ohmRepository.CalculateOhmValue(BandA, BandB, BandC, "Black").ToString();
            @ViewBag.Ohm = ohmValue + " OHMS";
            return View("Index");
        }


    }
}