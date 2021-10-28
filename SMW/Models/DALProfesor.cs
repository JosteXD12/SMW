using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class DALProfesor
{
    public Boolean insertarProfesor(EntidadProfesor elProfesor)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InsertarProfesor";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Profesor_cedula", elProfesor.Profesor_cedula));
        cmd.Parameters.Add(new SqlParameter("@Profesor_nombre", elProfesor.Profesor_nombre));
        cmd.Parameters.Add(new SqlParameter("@Profesor_primerApellido", elProfesor.Profesor_primerApellido));
        cmd.Parameters.Add(new SqlParameter("@Profesor_segundoApellido", elProfesor.Profesor_segundoApellido));
        cmd.Parameters.Add(new SqlParameter("@Profesor_telefono", elProfesor.Profesor_telefono));
        cmd.Parameters.Add(new SqlParameter("@Profesor_correoElectronico", elProfesor.Profesor_correoElectronico));
        cmd.Parameters.Add(new SqlParameter("@Profesor_direccion", elProfesor.Profesor_dirreccion));
        cmd.Parameters.Add(new SqlParameter("@Profesor_estado", 'A'));

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

    public void ModificarProfesor(EntidadProfesor elProfesor)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ModificarProfesor";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Profesor_id", elProfesor.Profesor_id));
        cmd.Parameters.Add(new SqlParameter("@Profesor_cedula", elProfesor.Profesor_cedula));
        cmd.Parameters.Add(new SqlParameter("@Profesor_nombre", elProfesor.Profesor_nombre));
        cmd.Parameters.Add(new SqlParameter("@Profesor_primerApellido", elProfesor.Profesor_primerApellido));
        cmd.Parameters.Add(new SqlParameter("@Profesor_segundoApellido", elProfesor.Profesor_segundoApellido));
        cmd.Parameters.Add(new SqlParameter("@Profesor_telefono", elProfesor.Profesor_telefono));
        cmd.Parameters.Add(new SqlParameter("@Profesor_correoElectronico", elProfesor.Profesor_correoElectronico));
        cmd.Parameters.Add(new SqlParameter("@Profesor_direccion", elProfesor.Profesor_dirreccion));
        cmd.Parameters.Add(new SqlParameter("@Profesor_estado", 'A'));

        int x = cmd.ExecuteNonQuery();
        aux.conectar();
    }

    public Boolean EliminarProfesor(int Profesor_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "EliminarProfesor";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Profesor_id", Profesor_id));
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

    public Boolean InactivarProfesor(int Profesor_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InactivarProfesor";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Profesor_id", Profesor_id));
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
 
    public EntidadProfesor ConsultarProfesor(int Profesor_id)
    {
        EntidadProfesor elProfesor = new EntidadProfesor();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ConsultarProfesor";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Profesor_id", Profesor_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elProfesor.Profesor_id = int.Parse(dr["Profesor_id"].ToString());
            elProfesor.Profesor_cedula = dr["Profesor_cedula"].ToString();
            elProfesor.Profesor_nombre = dr["Profesor_nombre"].ToString();
            elProfesor.Profesor_primerApellido = dr["Profesor_primerApellido"].ToString();
            elProfesor.Profesor_segundoApellido = dr["Profesor_segundoApellido"].ToString();
            elProfesor.Profesor_telefono = dr["Profesor_telefono"].ToString();
            elProfesor.Profesor_correoElectronico = dr["Profesor_correoElectronico"].ToString();
            elProfesor.Profesor_dirreccion = dr["Profesor_dirreccion"].ToString();
            elProfesor.Profesor_estado = dr["Profesor_estado"].ToString();


        }
        else
        {
            elProfesor = null;
        }
        aux.conectar();
        return elProfesor;
    }
    public EntidadProfesor ActivarProfesor(int Profesor_id)
    {
        EntidadProfesor elProfesor = new EntidadProfesor();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ActivarProfesor";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Profesor_id", Profesor_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elProfesor.Profesor_id = int.Parse(dr["Profesor_id"].ToString());
            elProfesor.Profesor_cedula = dr["Profesor_cedula"].ToString();
            elProfesor.Profesor_nombre = dr["Profesor_nombre"].ToString();
            elProfesor.Profesor_primerApellido = dr["Profesor_primerApellido"].ToString();
            elProfesor.Profesor_segundoApellido = dr["Profesor_segundoApellido"].ToString();
            elProfesor.Profesor_telefono = dr["Profesor_telefono"].ToString();
            elProfesor.Profesor_correoElectronico = dr["Profesor_correoElectronico"].ToString();
            elProfesor.Profesor_dirreccion = dr["Profesor_dirreccion"].ToString();
            elProfesor.Profesor_estado = dr["Profesor_estado"].ToString();


        }
        else
        {
            elProfesor = null;
        }
        aux.conectar();
        return elProfesor;
    }

    public List<EntidadProfesor> ListarProfesor()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarProfesor";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadProfesor> lista = new List<EntidadProfesor>();

        while (dr.Read())
        {
            EntidadProfesor elProfesor = new EntidadProfesor();

            elProfesor.Profesor_id = int.Parse(dr["Profesor_id"].ToString());
            elProfesor.Profesor_cedula = dr["Profesor_cedula"].ToString();
            elProfesor.Profesor_nombre = dr["Profesor_nombre"].ToString();
            elProfesor.Profesor_primerApellido = dr["Profesor_primerApellido"].ToString();
            elProfesor.Profesor_segundoApellido = dr["Profesor_segundoApellido"].ToString();
            elProfesor.Profesor_telefono = dr["Profesor_telefono"].ToString();
            elProfesor.Profesor_correoElectronico = dr["Profesor_correoElectronico"].ToString();
            elProfesor.Profesor_dirreccion = dr["Profesor_direccion"].ToString();
            elProfesor.Profesor_estado = dr["Profesor_estado"].ToString();

            lista.Add(elProfesor);
        }
        aux.conectar();
        return lista;
    }
    public List<EntidadProfesor> ListarIncativoProfesor()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarInactivoProfesor";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadProfesor> lista = new List<EntidadProfesor>();

        while (dr.Read())
        {
            EntidadProfesor elProfesor = new EntidadProfesor();

            elProfesor.Profesor_id = int.Parse(dr["Profesor_id"].ToString());
            elProfesor.Profesor_cedula = dr["Profesor_cedula"].ToString();
            elProfesor.Profesor_nombre = dr["Profesor_nombre"].ToString();
            elProfesor.Profesor_primerApellido = dr["Profesor_primerApellido"].ToString();
            elProfesor.Profesor_segundoApellido = dr["Profesor_segundoApellido"].ToString();
            elProfesor.Profesor_telefono = dr["Profesor_telefono"].ToString();
            elProfesor.Profesor_correoElectronico = dr["Profesor_correoElectronico"].ToString();
            elProfesor.Profesor_dirreccion = dr["Profesor_direccion"].ToString();
            elProfesor.Profesor_estado = dr["Profesor_estado"].ToString();

            lista.Add(elProfesor);
        }
        aux.conectar();
        return lista;
    }
}
