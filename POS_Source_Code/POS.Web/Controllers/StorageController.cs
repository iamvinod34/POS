using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using POS.Business.BusinessComponents;
using POS.Entity.Entities;
using POS.Util.Model;

namespace POS.Web.Controllers
{
    ///Created by Vinod on 16/08/2016
    ///<summary>
    ///Storage Controller
    /// </summary>
    public class StorageController : Controller
    {
        StorageBL StorageBL;
        public StorageController()
        {
            StorageBL = new StorageBL();
        }

        // GET: Storage
        public ActionResult Index()
        {
            LocationStorageModel LocationStorage = new LocationStorageModel();
            LocationStorage = StorageBL.GetStorage();
            return View(LocationStorage);
        }

        //public PartialViewResult GetStorageByID(string locationID)
        //{
        //   List<tbl_Storage> storageGetById = StorageBL.GetByID(locationID);
        //    return PartialView("~/Views/Storage/Partial/_StorageDetailsPartial.cshtml", storageGetById);
        //}

        public string InsertOrUpdateStorage(tbl_Storage storage)
        {
            return StorageBL.InsertOrUpdate(storage);
        }

        public PartialViewResult GetStorageById(string LocationID)
        {
            LocationStorageModel LocationStorage = new LocationStorageModel();
            LocationStorage= StorageBL.GetStorageById(LocationID);
            LocationStorage.Storages= StorageBL.GetByID(LocationID);
            return PartialView("~/Views/Storage/Partial/_StorageDetailsPartial.cshtml", LocationStorage);
        }
        public PartialViewResult GetStorageId(string locationID)
        {
           List<tbl_Storage> locationId = StorageBL.GetByID(locationID.Trim());
            return PartialView("~/Views/Storage/Partial/_StorageDetailsPartial.cshtml", locationId);
        }
    }
}