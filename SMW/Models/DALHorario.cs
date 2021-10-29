using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class DALHorario
{
    public Boolean InsertarHorario(EntidadHorario elHorario)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InsertaHorario";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Horario_descripcion", elHorario.Horario_descripcion));
        cmd.Parameters.Add(new SqlParameter("@Horario_dia", elHorario.Horario_dia));
        cmd.Parameters.Add(new SqlParameter("@Horario_horainicio", elHorario.Horario_horainicio));
        cmd.Parameters.Add(new SqlParameter("@Horario_horafin", elHorario.Horario_horafin));
        cmd.Parameters.Add(new SqlParameter("@Horario_estado", 'A'));

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

    public void ModificarHorario(EntidadHorario elHorario)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ModificarHorario";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Horario_id", elHorario.Horario_id));
        cmd.Parameters.Add(new SqlParameter("@Horario_descripcion", elHorario.Horario_descripcion));
        cmd.Parameters.Add(new SqlParameter("@Horario_dia", elHorario.Horario_dia));
        cmd.Parameters.Add(new SqlParameter("@Horario_horainicio", elHorario.Horario_horainicio));
        cmd.Parameters.Add(new SqlParameter("@Horario_horafin", elHorario.Horario_horafin));
        cmd.Parameters.Add(new SqlParameter("@Horario_estado", 'A'));      

        cmd.ExecuteNonQuery();
        aux.conectar();
    }
    public Boolean EliminarHorario(int Horario_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "EliminarHorario";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Horario_id", Horario_id));
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
    public Boolean InactivarHorario(int Horario_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InactivarHorario";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Horario_id", Horario_id));
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
    public EntidadHorario ConsultarHorario(int Horario_id)
    {
        EntidadHorario elHorario= new EntidadHorario();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ConsultarHorario";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Horario_id", Horario_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elHorario.Horario_id = int.Parse(dr["Horario_id"].ToString());
            elHorario.Horario_descripcion = dr["Horario_descripcion"].ToString();
            elHorario.Horario_dia = dr["Horario_dia"].ToString();
            elHorario.Horario_horainicio = dr["Horario_horaInicio"].ToString();
            elHorario.Horario_horafin = dr["Horario_horaFin"].ToString();
            elHorario.Horario_estado = dr["Horario_estado"].ToString();


        }
        else
        {
            elHorario = null;
        }
        aux.conectar();
        return elHorario;
    }
    public EntidadHorario ActivarHorario(int Horario_id)
    {
        EntidadHorario elHorario = new EntidadHorario();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ActivarHorario";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Horario_id", Horario_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elHorario.Horario_id = int.Parse(dr["Horario_id"].ToString());
            elHorario.Horario_descripcion = dr["Horario_descripcion"].ToString();
            elHorario.Horario_dia = dr["Horario_dia"].ToString();
            elHorario.Horario_horainicio = dr["Horario_horaInicio"].ToString();
            elHorario.Horario_horafin = dr["Horario_horaFin"].ToString();
            elHorario.Horario_estado = dr["Horario_estado"].ToString();


        }
        else
        {
            elHorario = null;
        }
        aux.conectar();
        return elHorario;
    }
    public List<EntidadHorario> ListarHorario()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarHorario";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadHorario> lista = new List<EntidadHorario>();

        while (dr.Read())
        {
            EntidadHorario elHorario = new EntidadHorario();

            elHorario.Horario_id = int.Parse(dr["Horario_id"].ToString());
            elHorario.Horario_descripcion = dr["Horario_descripcion"].ToString();
            elHorario.Horario_dia = dr["Horario_dia"].ToString();
            elHorario.Horario_horainicio = dr["Horario_horaInicio"].ToString();
            elHorario.Horario_horafin = dr["Horario_horaFin"].ToString();
            elHorario.Horario_estado = dr["Horario_estado"].ToString();

            lista.Add(elHorario);
        }
        aux.conectar();
        return lista;
    }
    public List<EntidadHorario> ListarInactivosHorario()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarInactivoHorario";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadHorario> lista = new List<EntidadHorario>();

        while (dr.Read())
        {
            EntidadHorario elHorario = new EntidadHorario();

            elHorario.Horario_id = int.Parse(dr["Horario_id"].ToString());
            elHorario.Horario_descripcion = dr["Horario_descripcion"].ToString();
            elHorario.Horario_dia = dr["Horario_dia"].ToString();
            elHorario.Horario_horainicio = dr["Horario_horaInicio"].ToString();
            elHorario.Horario_horafin = dr["Horario_horaFin"].ToString();
            elHorario.Horario_estado = dr["Horario_estado"].ToString();

            lista.Add(elHorario);
        }
        aux.conectar();
        return lista;
    }

}
