using POS.Business.BusinessComponents;
using POS.Entity.Entities;
using POS.Util.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace POS.Web.Controllers
{
    ///Created by Srikanth Kotnala on 8/13/2016
    ///<summary>
    ///Location Controller
    /// </summary>
    public class LocationController : Controller
    {
        LocationBL LocationBL;
        public LocationController()
        {
            LocationBL = new LocationBL();
        }
        // GET: Location
        public ActionResult Index()
        {
            List<tbl_Location> lstLocations=  LocationBL.GetAll();
            return View(lstLocations);
        }

        /// <summary>
        /// Get Location details By ID -Srikanth
        /// </summary>
        /// <param name="locationID"></param>
        /// <returns></returns>
        public PartialViewResult GetLocationByID(string locationID)
        {
            tbl_Location location = LocationBL.GetByID(locationID.Trim());
            return PartialView("~/Views/Location/Partial/_LocationDetailsPartial.cshtml", location);
        }

        public string InsertOrUpdateLocation(tbl_Location location)
        {
            LocationModel LM = new LocationModel();
            location.LocationID = LM.LocationID;
            return LocationBL.InsertOrUpdate(location);
        }
    }
}