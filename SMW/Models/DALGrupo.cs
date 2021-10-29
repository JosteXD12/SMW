using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class DALGrupo
{
    public Boolean insertarGrupo(EntidadGrupo elGrupo)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InsertarGrupo";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Grupo_descripcion", elGrupo.Grupo_descripcion));
        cmd.Parameters.Add(new SqlParameter("@Grupo_estado", 'A'));

        int x = cmd.ExecuteNonQuery();
        aux.conectar();

        if (x >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public void ModificarGrupo(EntidadGrupo elGrupo)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ModificarGrupo";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Grupo_id", elGrupo.Grupo_id));
        cmd.Parameters.Add(new SqlParameter("@Grupo_descripcion", elGrupo.Grupo_descripcion));
        cmd.Parameters.Add(new SqlParameter("@Grupo_estado",'A'));

        int x =cmd.ExecuteNonQuery();
        aux.conectar();
    }
    public Boolean EliminarGrupo(int Grupo_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "EliminarGrupo";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Grupo_id", Grupo_id));
        int x = cmd.ExecuteNonQuery();
        aux.conectar();

        if (x >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public Boolean InactivarGrupo(int Grupo_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InactivarGrupo";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Grupo_id", Grupo_id));
        int x = cmd.ExecuteNonQuery();
        aux.conectar();

        if (x >= 1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    public EntidadGrupo ConsultarGrupo(int Grupo_id)
    {
        EntidadGrupo elGrupo = new EntidadGrupo();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ConsultarGrupo";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Grupo_id", Grupo_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elGrupo.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            elGrupo.Grupo_descripcion = dr["Grupo_descripcion"].ToString();
            elGrupo.Grupo_estado = dr["Grupo_estado"].ToString();


        }
        else
        {
            elGrupo = null;
        }
        aux.conectar();
        return elGrupo;
    }
    public EntidadGrupo ActivarGrupo(int Grupo_id)
    {
        EntidadGrupo elGrupo = new EntidadGrupo();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ActivarGrupo";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Grupo_id", Grupo_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elGrupo.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            elGrupo.Grupo_descripcion = dr["Grupo_descripcion"].ToString();
            elGrupo.Grupo_estado = dr["Grupo_estado"].ToString();


        }
        else
        {
            elGrupo = null;
        }
        aux.conectar();
        return elGrupo;
    }
    public List<EntidadGrupo> ListarGrupo()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarGrupo";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadGrupo> lista = new List<EntidadGrupo>();

        while (dr.Read())
        {
            EntidadGrupo elGrupo = new EntidadGrupo();

            elGrupo.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            elGrupo.Grupo_descripcion = dr["Grupo_descripcion"].ToString();
            elGrupo.Grupo_estado = dr["Grupo_estado"].ToString();

            lista.Add(elGrupo);
        }
        aux.conectar();
        return lista;
    }
    public List<EntidadGrupo> ListarIncativoGrupo()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarInactivoGrupo";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadGrupo> lista = new List<EntidadGrupo>();

        while (dr.Read())
        {
            EntidadGrupo elGrupo = new EntidadGrupo();

            elGrupo.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            elGrupo.Grupo_descripcion = dr["Grupo_descripcion"].ToString();
            elGrupo.Grupo_estado = dr["Grupo_estado"].ToString();

            lista.Add(elGrupo);
        }
        aux.conectar();
        return lista;
    }

}
