using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class DLACurso
{
    public Boolean insertarCuro(EntidadCurso elCurso)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InsertarCurso";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Curso_nombre", elCurso.Curso_nombre));
        cmd.Parameters.Add(new SqlParameter("@Curso_creditos", elCurso.Curso_creditos));
        cmd.Parameters.Add(new SqlParameter("@Curso_cupo", elCurso.Curso_cupo));
        cmd.Parameters.Add(new SqlParameter("@Curso_estado", 'A'));

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
    public void ModificarCurso(EntidadCurso elCurso)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ModificarCurso";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Curso_id", elCurso.Curso_id));
        cmd.Parameters.Add(new SqlParameter("@Curso_nombre", elCurso.Curso_nombre));
        cmd.Parameters.Add(new SqlParameter("@Curso_creditos", elCurso.Curso_creditos));
        cmd.Parameters.Add(new SqlParameter("@Curso_cupo", elCurso.Curso_cupo));
        cmd.Parameters.Add(new SqlParameter("@Curso_estado", 'A'));

        int x =cmd.ExecuteNonQuery();
        aux.conectar();
    }
    public Boolean EliminarCurso(int Curso_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "EliminarCurso";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Curso_id", Curso_id));
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
    public Boolean InactivarCurso(int Curso_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InactivarProfesor";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Curso_id", Curso_id));
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
    public EntidadCurso ConsultarCurso(int Curso_id)
    {
        EntidadCurso elCurso = new EntidadCurso();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ConsultarCurso";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Curso_id", Curso_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elCurso.Curso_id = int.Parse(dr["Curso_id"].ToString());
            elCurso.Curso_nombre = dr["Curso_nombre"].ToString();
            elCurso.Curso_creditos = dr["Curso_creditos"].ToString();
            elCurso.Curso_cupo = dr["Curso_cupo"].ToString();
            elCurso.Curso_Estado = dr["Curso_estado"].ToString();


        }
        else
        {
            elCurso = null;
        }
        aux.conectar();
        return elCurso;
    }
    public EntidadCurso ActivarCurso(int Curso_id)
    {
        EntidadCurso elCurso = new EntidadCurso();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ActivarCurso";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Curso_id", Curso_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elCurso.Curso_id = int.Parse(dr["Curso_id"].ToString());
            elCurso.Curso_nombre = dr["Curso_nombre"].ToString();
            elCurso.Curso_creditos = dr["Curso_creditos"].ToString();
            elCurso.Curso_cupo = dr["Curso_cupo"].ToString();
            elCurso.Curso_Estado = dr["Curso_estado"].ToString();


        }
        else
        {
            elCurso = null;
        }
        aux.conectar();
        return elCurso;
    }
    public List<EntidadCurso> ListarCurso()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarCurso";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadCurso> lista = new List<EntidadCurso>();

        while (dr.Read())
        {
            EntidadCurso elCurso = new EntidadCurso();

            elCurso.Curso_id = int.Parse(dr["Curso_id"].ToString());
            elCurso.Curso_nombre = dr["Curso_nombre"].ToString();
            elCurso.Curso_creditos = dr["Curso_creditos"].ToString();
            elCurso.Curso_cupo = dr["Curso_cupo"].ToString();
            elCurso.Curso_Estado = dr["Curso_estado"].ToString();

            lista.Add(elCurso);
        }
        aux.conectar();
        return lista;
    }

    public List<EntidadCurso> ListarIncativoCurso()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarInactivoCurso";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadCurso> lista = new List<EntidadCurso>();

        while (dr.Read())
        {
            EntidadCurso elCurso = new EntidadCurso();

            elCurso.Curso_id = int.Parse(dr["Curso_id"].ToString());
            elCurso.Curso_nombre = dr["Curso_nombre"].ToString();
            elCurso.Curso_creditos = dr["Curso_creditos"].ToString();
            elCurso.Curso_cupo = dr["Curso_cupo"].ToString();
            elCurso.Curso_Estado = dr["Curso_estado"].ToString();

            lista.Add(elCurso);
        }
        aux.conectar();
        return lista;
    }

}
