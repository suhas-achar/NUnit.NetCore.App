using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCore.API.Proj.DBServices;
using NetCore.API.Proj.Models;

namespace NetCore.API.Proj.Services
{
    public class VehicleService : IVehicleService
    {
        private IDatabaseService _dbService;
        public VehicleService(IDatabaseService dbService)
        {
            _dbService = dbService;
        }
       
        public string SaveService()
        {
            return _dbService.Save();
        }

    }
}
