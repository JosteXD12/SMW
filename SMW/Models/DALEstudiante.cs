using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class DALEstudiante
{
    public Boolean insertarEstudiante(EntidadEstudiante elEstudiante)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InsertarEstudiante";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Grupo_id", elEstudiante.Grupo_id));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_cedula", elEstudiante.Estudiante_cedula));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_nombre", elEstudiante.Estudiante_nombre));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_primerApellido", elEstudiante.Estudiante_primerApellido));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_segundoApellido", elEstudiante.Estudiante_segundoApellido));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_telefono", elEstudiante.Estudiante_telefono));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_correoElectronico", elEstudiante.Estudiante_correoElectronico));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_direccion", elEstudiante.Estudiante_dirreccion));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_estado", 'A'));

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
    public void ModificarEstudiante(EntidadEstudiante elEstudiante)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ModificarEstudiante";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Estudiante_id", elEstudiante.Estudiante_id));
        cmd.Parameters.Add(new SqlParameter("@Grupo_id", elEstudiante.Grupo_id));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_cedula", elEstudiante.Estudiante_cedula));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_nombre", elEstudiante.Estudiante_nombre));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_primerApellido", elEstudiante.Estudiante_primerApellido));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_segundoApellido", elEstudiante.Estudiante_segundoApellido));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_telefono", elEstudiante.Estudiante_telefono));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_correoElectronico", elEstudiante.Estudiante_correoElectronico));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_direccion", elEstudiante.Estudiante_dirreccion));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_estado", 'A'));

        int x =cmd.ExecuteNonQuery();
        aux.conectar();
    }
    public Boolean EliminarEstudiante(int Estudiante_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "EliminarEstudiante";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Estudiante_id", Estudiante_id));
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
    public Boolean InactivarEstudiante(int Estudiante_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InactivarEstudiante";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Estudiante_id", Estudiante_id));
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
    public EntidadEstudiante ConsultarEstudiante(int Estudiante_id)
    {
        EntidadEstudiante elEstudiante = new EntidadEstudiante();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ConsultarEstudiante";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Estudiante_id", Estudiante_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elEstudiante.Estudiante_id = int.Parse(dr["Estudiante_id"].ToString());
            elEstudiante.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            elEstudiante.Estudiante_cedula = dr["Estudiante_cedula"].ToString();
            elEstudiante.Estudiante_nombre = dr["Estudiante_nombre"].ToString();
            elEstudiante.Estudiante_primerApellido = dr["Estudiante_primerApellido"].ToString();
            elEstudiante.Estudiante_segundoApellido = dr["Estudiante_segundoApellido"].ToString();
            elEstudiante.Estudiante_telefono = dr["Estudiante_telefono"].ToString();
            elEstudiante.Estudiante_correoElectronico = dr["Estudiante_correoElectronico"].ToString();
            elEstudiante.Estudiante_dirreccion = dr["Estudiante_dirreccion"].ToString();
            elEstudiante.Estudiante_estado = dr["Estudiante_estado"].ToString();


        }
        else
        {
            elEstudiante = null;
        }
        aux.conectar();
        return elEstudiante;
    }

    public EntidadEstudiante ActivarEstudiante(int Estudiante_id)
    {
        EntidadEstudiante elEstudiante = new EntidadEstudiante();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ActivarEstudiante";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Estudiante_id", Estudiante_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            elEstudiante.Estudiante_id = int.Parse(dr["Estudiante_id"].ToString());
            elEstudiante.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            elEstudiante.Estudiante_cedula = dr["Estudiante_cedula"].ToString();
            elEstudiante.Estudiante_nombre = dr["Estudiante_nombre"].ToString();
            elEstudiante.Estudiante_primerApellido = dr["Estudiante_primerApellido"].ToString();
            elEstudiante.Estudiante_segundoApellido = dr["Estudiante_segundoApellido"].ToString();
            elEstudiante.Estudiante_telefono = dr["Estudiante_telefono"].ToString();
            elEstudiante.Estudiante_correoElectronico = dr["Estudiante_correoElectronico"].ToString();
            elEstudiante.Estudiante_dirreccion = dr["Estudiante_dirreccion"].ToString();
            elEstudiante.Estudiante_estado = dr["Estudiante_estado"].ToString();


        }
        else
        {
            elEstudiante = null;
        }
        aux.conectar();
        return elEstudiante;
    }
    public List<EntidadEstudiante> ListarEstudiante()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarEstudiantes";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadEstudiante> lista = new List<EntidadEstudiante>();

        while (dr.Read())
        {
            EntidadEstudiante elEstudiante = new EntidadEstudiante();

            elEstudiante.Estudiante_id = int.Parse(dr["Estudiante_id"].ToString());
            elEstudiante.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            elEstudiante.Estudiante_cedula = dr["Estudiante_cedula"].ToString();
            elEstudiante.Estudiante_nombre = dr["Estudiante_nombre"].ToString();
            elEstudiante.Estudiante_primerApellido = dr["Estudiante_primerApellido"].ToString();
            elEstudiante.Estudiante_segundoApellido = dr["Estudiante_segundoApellido"].ToString();
            elEstudiante.Estudiante_telefono = dr["Estudiante_telefono"].ToString();
            elEstudiante.Estudiante_correoElectronico = dr["Estudiante_correoElectronico"].ToString();
            elEstudiante.Estudiante_dirreccion = dr["Estudiante_direccion"].ToString();
            elEstudiante.Estudiante_estado = dr["Estudiante_estado"].ToString();

            lista.Add(elEstudiante);
        }
        aux.conectar();
        return lista;
    }
    public List<EntidadEstudiante> ListarIncativoEstudiante()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarInactivoEstudiantes";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadEstudiante> lista = new List<EntidadEstudiante>();

        while (dr.Read())
        {
            EntidadEstudiante elEstudiante = new EntidadEstudiante();

            elEstudiante.Estudiante_id = int.Parse(dr["Estudiante_id"].ToString());
            elEstudiante.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            elEstudiante.Estudiante_cedula = dr["Estudiante_cedula"].ToString();
            elEstudiante.Estudiante_nombre = dr["Estudiante_nombre"].ToString();
            elEstudiante.Estudiante_primerApellido = dr["Estudiante_primerApellido"].ToString();
            elEstudiante.Estudiante_segundoApellido = dr["Estudiante_segundoApellido"].ToString();
            elEstudiante.Estudiante_telefono = dr["Estudiante_telefono"].ToString();
            elEstudiante.Estudiante_correoElectronico = dr["Estudiante_correoElectronico"].ToString();
            elEstudiante.Estudiante_dirreccion = dr["Estudiante_direccion"].ToString();
            elEstudiante.Estudiante_estado = dr["Estudiante_estado"].ToString();

            lista.Add(elEstudiante);
        }
        aux.conectar();
        return lista;
    }
}
