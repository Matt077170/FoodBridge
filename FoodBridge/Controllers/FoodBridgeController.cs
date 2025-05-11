using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoodBridge.Controllers
{
    public class FoodBridgeController : Controller
    {
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult AdminSignup()
        {
           
            return View();
        }

        public ActionResult DonorSignup()
        {

            return View();
        }

        public ActionResult RecipientSignup()
        {

            return View();
        }

        public ActionResult OrgRegister()
        {
            return View();
        }

        public ActionResult OrgInfo()
        {
            return View();
        }

        public ActionResult OrgUpload()
        {
            return View();
        }

        public ActionResult SoupKitchen()
        {
            return View();
        }

 
        public ActionResult Login()
        {
          
            return View();
        }

        public ActionResult RecipientDashboard()
        {

            return View();
        }

        public ActionResult AdminDashboard()
        {

            return View();
        }

        public ActionResult DonorDashboard()
        {

            return View();
        }

 
    }
}