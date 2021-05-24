using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.API.Proj.DBServices
{
    public class OracleDbService : IDatabaseService
    {
        public string Save()
        {
            return "Saved to Oracle database";
        }
    }
}
