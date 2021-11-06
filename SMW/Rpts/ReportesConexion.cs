using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMW.Rpts
{
    public class ReportesConexion
    {

        public static CrystalDecisions.Shared.ConnectionInfo getConexion()
        {
            CrystalDecisions.Shared.ConnectionInfo infocon = new CrystalDecisions.Shared.ConnectionInfo();

            infocon.ServerName = @"(local)";
            infocon.DatabaseName = "Registro_de_Matricula";
            infocon.IntegratedSecurity = true;

            return infocon;

        }
        


    }

}