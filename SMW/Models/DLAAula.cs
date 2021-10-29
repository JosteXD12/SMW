using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class DLAAula
{
    public Boolean insertarAula(EntidadAula laAula)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InsertarAula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Aula_descripcion", laAula.Aula_descripcion));
        cmd.Parameters.Add(new SqlParameter("@Aula_capacidad", laAula.Aula_capacidad));
        cmd.Parameters.Add(new SqlParameter("@Aula_estado", 'A'));

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
    public void ModificarAula(EntidadAula laAula)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ModificarAula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Aula_id", laAula.Aula_id));
        cmd.Parameters.Add(new SqlParameter("@Aula_descripcion", laAula.Aula_descripcion));
        cmd.Parameters.Add(new SqlParameter("@Aula_capacidad", laAula.Aula_capacidad));
        cmd.Parameters.Add(new SqlParameter("@Aula_estado", 'A'));

        int x = cmd.ExecuteNonQuery();
        aux.conectar();
    }
    public Boolean EliminarAula(int Aula_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "EliminarAula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Aula_id", Aula_id));
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

    public Boolean InactivarAula(int Aula_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InactivarAula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Aula_id", Aula_id));
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
    public EntidadAula ConsultarAula(int Aula_id)
    {
        EntidadAula laAula = new EntidadAula();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ConsultarAula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Aula_id", Aula_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            laAula.Aula_id = int.Parse(dr["Aula_id"].ToString());
            laAula.Aula_descripcion = dr["Aula_descripcion"].ToString();
            laAula.Aula_capacidad = dr["Profesor_capacidad"].ToString();
            laAula.Aula_Estado = dr["Aula_estado"].ToString();


        }
        else
        {
            laAula = null;
        }
        aux.conectar();
        return laAula;
    }
    public EntidadAula ActivarAula(int Aula_id)
    {
        EntidadAula laAula = new EntidadAula();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ActivarAula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Aula_id", Aula_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            laAula.Aula_id = int.Parse(dr["Aula_id"].ToString());
            laAula.Aula_descripcion = dr["Aula_descripcion"].ToString();
            laAula.Aula_capacidad = dr["Profesor_capacidad"].ToString();
            laAula.Aula_Estado = dr["Aula_estado"].ToString();

        }
        else
        {
            laAula = null;
        }
        aux.conectar();
        return laAula;
    }
    public List<EntidadAula> ListarAula()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarAula";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadAula> lista = new List<EntidadAula>();

        while (dr.Read())
        {
            EntidadAula laAula = new EntidadAula();

            laAula.Aula_id = int.Parse(dr["Aula_id"].ToString());
            laAula.Aula_descripcion = dr["Aula_descripcion"].ToString();
            laAula.Aula_capacidad = dr["Aula_capacidad"].ToString();
            laAula.Aula_Estado = dr["Aula_estado"].ToString();

            lista.Add(laAula);
        }
        aux.conectar();
        return lista;
    }
    public List<EntidadAula> ListarIncativoAula()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarInactivoAula";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadAula> lista = new List<EntidadAula>();

        while (dr.Read())
        {
            EntidadAula laAula = new EntidadAula();

            laAula.Aula_id = int.Parse(dr["Aula_id"].ToString());
            laAula.Aula_descripcion = dr["Aula_descripcion"].ToString();
            laAula.Aula_capacidad = dr["Aula_capacidad"].ToString();
            laAula.Aula_Estado = dr["Aula_estado"].ToString();

            lista.Add(laAula);
        }
        aux.conectar();
        return lista;
    }
}
