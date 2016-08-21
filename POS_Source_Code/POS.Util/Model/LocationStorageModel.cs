using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using POS.Entity.Entities;

namespace POS.Util.Model
{
  public  class LocationStorageModel
    {
        public string LocationID{ get; set; }
        public string LocationDesc{ get; set; }

        public List<Proc_LoadGetLocationStorage_Result> StorageLocation;
        public List<tbl_Storage> Storages;
        public List<Proc_LoadStorageGetById_Result> GetStorageById;


    }
}
