using aSIMS.Common;
using aSIMS.Models;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace aSIMS.Repository
{
    public class TransportRepository : Repository<TransportModel>
    {

        Database db = Connection.GetDatabase();

        public override string GetSPName { get { return "GetTransport"; } }
        public override string GetByIDSPName { get { return "GetTransportByID"; } }
        public override string GetByStringSPName { get { return string.Empty; } }
        public override string DeleteSPName { get { return "DeleteTransport"; } }
        public override string DeleteByStringSPName { get { return string.Empty; } }
        public override string CreateSPName { get { return "CreateTransport"; } }
        public override string EditSPName { get { return "UpdateTransport"; } }
        public override string GetByModelSPName { get { return string.Empty; } }

    }
}