using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class Conectividad
{
    string strCnn;

    public SqlConnection conectar()
    {
        strCnn = (@" server=(local); integrated security = true;
              DataBase = Registro_de_Matricula;connection timeout=2");

        SqlConnection conn = new SqlConnection(strCnn);

        try
        {
            if (conn.State.Equals(ConnectionState.Closed))
            {
                conn.Open();
            }

            else
            {
                conn.Close();
            }
        }
        catch (Exception ex)
        {



        }
        return conn;
    }
}
