using Controlador;
using Entidades;
using Excepciones;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Logueo
{
    public static class LogDB
    {
        private static SqlConnection conexion;
        private static SqlCommand comando;

        static LogDB()
        {
            conexion = new SqlConnection("Server=DESKTOP-2HKT4SF\\SQLEXPRESS;Database=TP4;Trusted_Connection=True;MultipleActiveResultSets=true;");
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
        /// <summary>
        /// Inserta la informacion de la persona a la base de datos
        /// </summary>
        /// <param name="persona"></param>
        public static void InsertarInfoEnDB(Persona persona)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();

                comando.CommandText = "INSERT INTO dbo.Personas (nombre,apellido,dni,edad,genero,salario,estudioSecundario,pais) VALUES (@Nombre,@Apellido,@Documento,@Edad,@Genero,@Salario,@EstudioSecundario,@Pais)";
                comando.Parameters.AddWithValue("@Nombre", persona.Nombre);
                comando.Parameters.AddWithValue("@Apellido", persona.Apellido);
                comando.Parameters.AddWithValue("@Documento", persona.Dni);
                comando.Parameters.AddWithValue("@Edad", persona.Edad);
                comando.Parameters.AddWithValue("@Genero", persona.Genero);
                comando.Parameters.AddWithValue("@Salario", persona.Salario);
                comando.Parameters.AddWithValue("@EstudioSecundario", persona.EstudioSecundario);
                comando.Parameters.AddWithValue("@Pais", persona.PaisNacido);
                comando.ExecuteNonQuery();

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
        /// <summary>
        /// Lee los datos de los alumnos en la base de datos
        /// </summary>
        /// <returns></returns>
        public static Procesador<Persona> LeerPersona()
        {
            conexion.Open();
            Procesador<Persona> listaPersonasAux = new Procesador<Persona>();
            try
            {

                comando.CommandText = "SELECT * FROM Personas";
                SqlDataReader sqlReader = comando.ExecuteReader();

                if (sqlReader.HasRows)
                {
                    while (sqlReader.Read())
                    {

                        EGenero genero = EGenero.Masculino;
                        if (sqlReader["genero"].ToString() == "1")
                        {
                            genero = EGenero.Femenino;
                        }
                        ESecundario secundario = ESecundario.Incompleto;
                        if (sqlReader["estudioSecundario"].ToString() == "0")
                        {
                            secundario = ESecundario.Completo;
                        }

                        listaPersonasAux.Personas.Add(new Persona(sqlReader["nombre"].ToString(), sqlReader["apellido"].ToString(), sqlReader["dni"].ToString(),
                            (int)sqlReader["edad"], genero, (int)sqlReader["salario"],
                            secundario, VerificarPais(sqlReader["pais"].ToString())));

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
        /// <summary>
        /// Verifica el pais recibido en string
        /// </summary>
        /// <param name="pais">pais a verificar</param>
        /// <returns>el nombre del pais en tipo Enum</returns>
        private static EPais VerificarPais(string pais)
        {
            EPais aux;
            if (pais == "0")
            {
                aux = EPais.Argentina;
            }
            else
            {
                if (pais == "1")
                {
                    aux = EPais.Chile;
                }
                else
                {
                    if (pais == "2")
                    {
                        aux = EPais.Venezuela;
                    }
                    else
                    {
                        if (pais == "3")
                        {
                            aux = EPais.Colombia;
                        }
                        else
                        {
                            aux = EPais.Mexico;
                        }
                    }
                }
            }
            return aux;
        }
       
        /// <summary>
        /// Elimina a la persona pasada por parametro
        /// </summary>
        /// <param name="persona"></param>
        public static void Eliminar(Persona persona)
        {

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM Personas WHERE dni = @documento";
                comando.Parameters.AddWithValue("@documento", persona.Dni);
                comando.ExecuteNonQuery();
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
