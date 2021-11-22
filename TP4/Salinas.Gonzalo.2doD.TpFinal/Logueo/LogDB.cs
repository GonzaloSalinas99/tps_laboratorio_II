using Controlador;
using Entidades;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Logueo
{
    public class LogDB
    {
        private SqlConnection conexion;

        public LogDB(string stringConnection)
        {
            conexion = new SqlConnection(stringConnection);
        }

        public void InsertarInfoEnDB(Persona persona)
        {
            try
            {
                conexion.Open();
                SqlCommand sqlCommand;

                if (persona is Alumno)
                {
                    Alumno alumnoAux = (Alumno)persona;
                    sqlCommand = new SqlCommand("INSERT INTO dbo.Alumnoss (nombre,apellido,documento,edad,legajo,cuatrimestreCursando,FechaIngreso) VALUES (@Nombre,@Apellido,@Documento,@Edad,@Legajo,@CuatrimestreCursando,@FechaIngreso)", conexion);
                    sqlCommand.Parameters.AddWithValue("@Nombre", alumnoAux.Nombre);
                    sqlCommand.Parameters.AddWithValue("@Apellido", alumnoAux.Apellido);
                    sqlCommand.Parameters.AddWithValue("@Documento", alumnoAux.Dni);
                    sqlCommand.Parameters.AddWithValue("@Edad", alumnoAux.Edad);
                    sqlCommand.Parameters.AddWithValue("@Legajo", alumnoAux.Legajo);
                    sqlCommand.Parameters.AddWithValue("@CuatrimestreCursando", alumnoAux.CuatrimestreActual);
                    sqlCommand.Parameters.AddWithValue("@FechaIngreso", alumnoAux.FechaIngreso);
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    if (persona is Profesor)
                    {
                        Profesor profesorAux = (Profesor)persona;
                        sqlCommand = new SqlCommand("INSERT INTO dbo.Profesores (nombre,apellido,documento,edad,salario,FechaIngreso) VALUES (@Nombre,@Apellido,@Documento,@Edad,@Salario,@FechaIngreso)", conexion);
                        sqlCommand.Parameters.AddWithValue("@Nombre", profesorAux.Nombre);
                        sqlCommand.Parameters.AddWithValue("@Apellido", profesorAux.Apellido);
                        sqlCommand.Parameters.AddWithValue("@Documento", profesorAux.Dni);
                        sqlCommand.Parameters.AddWithValue("@Edad", profesorAux.Edad);
                        sqlCommand.Parameters.AddWithValue("@Salario", profesorAux.Salario);
                        sqlCommand.Parameters.AddWithValue("@FechaIngreso", profesorAux.FechaIngreso);
                        sqlCommand.ExecuteNonQuery();
                    }
                }

            }
            catch (Excepciones.Excepciones ex)
            {

                throw new Excepciones.Excepciones(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public Procesador<Alumno> LeerAlumnos()
        {
            conexion.Open();
            SqlCommand sqlCommandAlumnos;
            Procesador<Alumno> listaPersonasAux = new Procesador<Alumno>();

            try
            {
                sqlCommandAlumnos = new SqlCommand();
                sqlCommandAlumnos.Connection = conexion;
                sqlCommandAlumnos.CommandText = "SELECT * FROM Alumnoss";
                SqlDataReader sqlDataReaderAlumnos = sqlCommandAlumnos.ExecuteReader();

                if (sqlDataReaderAlumnos.HasRows)
                {
                    while (sqlDataReaderAlumnos.Read())
                    {
                        listaPersonasAux.Personas.Add(new Alumno(sqlDataReaderAlumnos["nombre"].ToString(), sqlDataReaderAlumnos["apellido"].ToString(), sqlDataReaderAlumnos["documento"].ToString(),
                            (int)sqlDataReaderAlumnos["edad"], sqlDataReaderAlumnos["legajo"].ToString(), (int)sqlDataReaderAlumnos["cuatrimestreCursando"],
                            Convert.ToDateTime(sqlDataReaderAlumnos["fechaIngreso"])));


                    }
                }
            }
            catch (Excepciones.Excepciones ex)
            {

                throw new Excepciones.Excepciones(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return listaPersonasAux;
        }

        public Procesador<Profesor> LeerProfesores()
        {
            conexion.Open();
            SqlCommand sqlCommandProfesores;
            Procesador<Profesor> listaPersonasAux = new Procesador<Profesor>();

            try
            {

                sqlCommandProfesores = new SqlCommand();
                sqlCommandProfesores.Connection = conexion;
                sqlCommandProfesores.CommandText = "SELECT * FROM Profesores";
                SqlDataReader sqlDataReaderProfesores = sqlCommandProfesores.ExecuteReader();
                
                if (sqlDataReaderProfesores.HasRows)
                {
                    while (sqlDataReaderProfesores.Read())
                    {
                        listaPersonasAux.Personas.Add(new Profesor(sqlDataReaderProfesores["nombre"].ToString(), sqlDataReaderProfesores["apellido"].ToString(), sqlDataReaderProfesores["documento"].ToString(),
                            (int)sqlDataReaderProfesores["edad"], Convert.ToSingle(sqlDataReaderProfesores["salario"]), Convert.ToDateTime(sqlDataReaderProfesores["fechaIngreso"])));
                    }
                }
            }
            catch (Excepciones.Excepciones ex)
            {

                throw new Excepciones.Excepciones(ex.Message);
            }
            finally
            {
                conexion.Close();
            }

            return listaPersonasAux;
        }

        public void Eliminar(Persona persona)
        {

            try
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = conexion;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                conexion.Open();

                if (persona is Alumno)
                {
                    sqlCommand.CommandText = $"DELETE FROM Alumnoss WHERE documento = @documento";

                }
                else
                {
                    if (persona is Profesor)
                    {
                        sqlCommand.CommandText = $"DELETE FROM Profesores WHERE documento = @documento";
                    }
                }
                sqlCommand.Parameters.AddWithValue("@documento", persona.Dni);
                sqlCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw new Excepciones.Excepciones(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }
    }


}
