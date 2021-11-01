using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class DALUsuario
{
    public Boolean login(string nick, string contrasenia)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand("UsuarioLogin");

        cmd.Connection = aux.conectar();

        cmd.CommandType = CommandType.StoredProcedure;
        cmd.Parameters.AddWithValue("@nick", nick);
        cmd.Parameters.AddWithValue("@contrasenia", contrasenia);

        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            aux.conectar();
            return true;
        }
        else
        {
            return false;
        }
        
        
    }
}
