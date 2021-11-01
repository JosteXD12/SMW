using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class DALMatricula
{
    public Boolean insertarMatricula(EntidadMatricula laMatricula)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InsertarMatricula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Estudiante_id", laMatricula.Estudiante_id));
        cmd.Parameters.Add(new SqlParameter("@Grupo_id", laMatricula.Grupo_id));
        cmd.Parameters.Add(new SqlParameter("@Curso_id", laMatricula.Curso_id));
        cmd.Parameters.Add(new SqlParameter("@Profesor_id", laMatricula.Profesor_id));
        cmd.Parameters.Add(new SqlParameter("@Horario_id", laMatricula.Horario_id));
        cmd.Parameters.Add(new SqlParameter("@Aula_id", laMatricula.Aula_id));
        cmd.Parameters.Add(new SqlParameter("@Matricula_comprobante", laMatricula.Matricula_comprobante));
        cmd.Parameters.Add(new SqlParameter("@Matricula_estado", 'A'));

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

    public void ModificarMatricula(EntidadMatricula laMatricula)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ModificarMatricula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Matricula_id", laMatricula.Matricula_id));
        cmd.Parameters.Add(new SqlParameter("@Estudiante_id", laMatricula.Estudiante_id));
        cmd.Parameters.Add(new SqlParameter("@Grupo_id", laMatricula.Grupo_id));
        cmd.Parameters.Add(new SqlParameter("@Curso_id", laMatricula.Curso_id));
        cmd.Parameters.Add(new SqlParameter("@Profesor_id", laMatricula.Profesor_id));
        cmd.Parameters.Add(new SqlParameter("@Horario_id", laMatricula.Horario_id));
        cmd.Parameters.Add(new SqlParameter("@Aula_id", laMatricula.Aula_id));
        cmd.Parameters.Add(new SqlParameter("@Matricula_comprobante", laMatricula.Matricula_comprobante));
        cmd.Parameters.Add(new SqlParameter("@Matricula_estado", 'A'));

        int x = cmd.ExecuteNonQuery();
        aux.conectar();
    }
    public Boolean EliminarMatricula(int Matricula_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "EliminarMatricula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Matricula_id", Matricula_id));
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
    public Boolean InactivarMatricula(int Matricula_id)
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "InactivarMatricula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Matricula_id", Matricula_id));
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
    public EntidadMatricula ConsultarMatricula(int Matricula_id)
    {
        EntidadMatricula laMatricula = new EntidadMatricula();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ConsultarMatricula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Matricula_id", Matricula_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            laMatricula.Matricula_id = int.Parse(dr["Matricula_id"].ToString());
            laMatricula.Estudiante_id = int.Parse(dr["Estudiante_id"].ToString());
            laMatricula.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            laMatricula.Curso_id = int.Parse(dr["Curso_id"].ToString());
            laMatricula.Profesor_id = int.Parse(dr["Profesor_id"].ToString());
            laMatricula.Horario_id = int.Parse(dr["Horario_id"].ToString());
            laMatricula.Aula_id = int.Parse(dr["Aula_id"].ToString());
            laMatricula.Matricula_comprobante = dr["Matricula_comprobante"].ToString();
            laMatricula.Matricula_estado = dr["Matricula_estado"].ToString();



        }
        else
        {
            laMatricula = null;
        }
        aux.conectar();
        return laMatricula;
    }
    public EntidadMatricula ActivarMatricula(int Matricula_id)
    {
        EntidadMatricula laMatricula = new EntidadMatricula();
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ActivarMatricula";
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.Add(new SqlParameter("@Matricula_id", Matricula_id));
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.Read())
        {
            laMatricula.Matricula_id = int.Parse(dr["Matricula_id"].ToString());
            laMatricula.Estudiante_id = int.Parse(dr["Estudiante_id"].ToString());
            laMatricula.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            laMatricula.Curso_id = int.Parse(dr["Curso_id"].ToString());
            laMatricula.Profesor_id = int.Parse(dr["Profesor_id"].ToString());
            laMatricula.Horario_id = int.Parse(dr["Horario_id"].ToString());
            laMatricula.Aula_id = int.Parse(dr["Aula_id"].ToString());
            laMatricula.Matricula_comprobante = dr["Matricula_comprobante"].ToString();
            laMatricula.Matricula_estado = dr["Matricula_estado"].ToString();


        }
        else
        {
            laMatricula = null;
        }
        aux.conectar();
        return laMatricula;
    }
    public List<EntidadMatricula> ListarMatricula()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarMatricula";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadMatricula> lista = new List<EntidadMatricula>();

        while (dr.Read())
        {
            EntidadMatricula laMatricula = new EntidadMatricula();

            laMatricula.Matricula_id = int.Parse(dr["Matricula_id"].ToString());
            laMatricula.Estudiante_id = int.Parse(dr["Estudiante_id"].ToString());
            laMatricula.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            laMatricula.Curso_id = int.Parse(dr["Curso_id"].ToString());
            laMatricula.Profesor_id = int.Parse(dr["Profesor_id"].ToString());
            laMatricula.Horario_id = int.Parse(dr["Horario_id"].ToString());
            laMatricula.Aula_id = int.Parse(dr["Aula_id"].ToString());
            laMatricula.Matricula_comprobante = dr["Matricula_comprobante"].ToString();
            laMatricula.Matricula_estado = dr["Matricula_estado"].ToString();
            
            lista.Add(laMatricula);
        }
        aux.conectar();
        return lista;
    }
    public List<EntidadMatricula> ListarIncativoMatricula()
    {
        Conectividad aux = new Conectividad();
        SqlCommand cmd = new SqlCommand();

        cmd.Connection = aux.conectar();

        cmd.CommandText = "ListarInactivoMatricula";
        cmd.CommandType = CommandType.StoredProcedure;

        SqlDataReader dr = cmd.ExecuteReader();

        List<EntidadMatricula> lista = new List<EntidadMatricula>();

        while (dr.Read())
        {
            EntidadMatricula laMatricula = new EntidadMatricula();

            laMatricula.Matricula_id = int.Parse(dr["Matricula_id"].ToString());
            laMatricula.Estudiante_id = int.Parse(dr["Estudiante_id"].ToString());
            laMatricula.Grupo_id = int.Parse(dr["Grupo_id"].ToString());
            laMatricula.Curso_id = int.Parse(dr["Curso_id"].ToString());
            laMatricula.Profesor_id = int.Parse(dr["Profesor_id"].ToString());
            laMatricula.Horario_id = int.Parse(dr["Horario_id"].ToString());
            laMatricula.Aula_id = int.Parse(dr["Aula_id"].ToString());
            laMatricula.Matricula_comprobante = dr["Matricula_comprobante"].ToString();
            laMatricula.Matricula_estado = dr["Matricula_estado"].ToString();

            lista.Add(laMatricula);
        }
        aux.conectar();
        return lista;
    }

}
