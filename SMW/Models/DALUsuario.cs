using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class DALUsuario
{
    public EntidadUsuario login(string nick, string contrasenia)
    {
        EntidadUsuario elUsuario = new EntidadUsuario();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "UsuarioLogin";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@nick", nick));
        cmd.Parameters.Add(new SqlParameter("@contrasenia", contrasenia));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elUsuario.Usuario_nick = dr["Usuario_nombre"].ToString();
            elUsuario.Usuario_Area =dr["Usuario_area"].ToString();
        

        }
        else
        {
            elUsuario = null;
        }
        aux.conectar();
        return elUsuario;

    }
}
