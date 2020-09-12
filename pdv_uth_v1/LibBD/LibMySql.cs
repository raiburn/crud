using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace LibBD
{
    public  class LibMySql
    {
        //objs de BD
        MySqlConnection con;
        //command
        MySqlCommand com;
        //data reader
        MySqlDataReader dr;
        MySqlDataAdapter da;

        //vars de conectionString
        string server = "localhost";
        string us = "root";
        string pwd = "123123";
        string bd = "pdv_uth_bd_v1";

        //var para msg de error
        public static string msgError = "";

        //constructores

        //default
        /// <summary>
        /// Conexión por default a server neubox en Desarrollo de PDV UTH. 
        /// BORRAR al terminar desarrollo
        /// </summary>
        public LibMySql()
        {
            //generamos el ConnectionString
            string connectionString = "SERVER=" + server +
                                    "; UID=" + us +
                                    "; PWD=" + pwd +
                                    "; DATABASE=" + bd + ";";
            //instanciamos la conexion
            con = new MySqlConnection(connectionString);

        }
        /// <summary>
        /// Constructor detallado, permite establecer conexión a Servidor MySql diferente al base
        /// </summary>
        /// <param name="server">Servidor MySql al que queremos conectarnos (localhost 0 127.0.0.1 si es tu PC)</param>
        /// <param name="us">Usuario que tiene permiso de conexión. 'root' comúnmente.</param>
        /// <param name="pwd">Tu constraseña para el usuario especificado</param>
        /// <param name="bd">La BASE DE DATOS a la que nos conectaremos.</param>
        public LibMySql(string server, string us, string pwd, string bd)
        {
            //encapsular los vars
            this.server = server;
            this.us = us;
            this.pwd = pwd;
            this.bd = bd;
            //generamos el ConnectionString
            string connectionString = "SERVER=" + server + 
                                    "; UID=" + us + 
                                    "; PWD=" + pwd + 
                                    "; DATABASE=" + bd + ";";
            //instanciamos la conexion
            con = new MySqlConnection(connectionString);
        }

        //metodos de acciones
        //inseetar
        public bool insertar(string tabla, string campos, string valores)
        {
            bool res = false;
            try
            {
                abrirConexion();
                //crear el query
                //ejecutar el query
                string query = "INSERT INTO " + tabla +" (" + campos + ") VALUES " + "(" + valores + ")";
                //instanciar el commando
                com = new MySqlCommand(query, con);
                //ejecutar el command...
                com.ExecuteNonQuery();
                //cambiamos el resultado
                res = true;
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error SQL al insertar. " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                msgError = "Error al insertar. " + ex.Message;
            }
            finally
            {
                cerrarConexion();
            }
            //devoler el res
            return res;
        } //insertar


        public bool actualizar(string tabla, string camposValores, string where)
        {
            bool res = false;
            ///////////////
            //try cathc
            try
            {
                // conectar
                abrirConexion();
                //crear el query
                string query = "UPDATE " + tabla + " SET " + camposValores + "  WHERE " + where;
                //instanciar el command
                com = new MySqlCommand(query, con);
                //ejecutar el query
                int resQuery =com.ExecuteNonQuery();
                //devolver resultados
                if (resQuery > 0)
                    res = true;
                else msgError = "NO HAY REGISTRO CON   ESTOS DATOS QUE SE ACTUALICE";
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error SQL al actualizar. " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                msgError = "Error  al actualizar. " + ex.Message;
            }
            finally {
                cerrarConexion();
            }
            //desconectar
            ////////////////////
            return res;
        }

        public bool eliminar(string tabla,  string where)
        {
            bool res = false;
            ///////////////
            //try cathc
            try
            {
                // conectar
                abrirConexion();
                //crear el query
                string query = "DELETE FROM " + tabla + "  WHERE " + where;
                //instanciar el command
                com = new MySqlCommand(query, con);
                //ejecutar el query
                int resQuery = com.ExecuteNonQuery();
                //devolver resultados
                if (resQuery > 0)
                    res = true;
                else msgError = "NO HAY REGISTRO CON   ESTOS DATOS QUE SE ELIMINE";
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error SQL al Eliminar. " + mysqlex.Message;
            }
            catch (Exception ex)
            {
                msgError = "Error  al Eliminar. " + ex.Message;
            }
            finally
            {
                cerrarConexion();
            }
            //desconectar
            ////////////////////
            return res;
        }


        public List<object> consultar(string campos, string tabla, string where)
        {
            //resultado es una lista de objexcts
            List<object> res = new List<object>();
            //try catch
            try
            {
                //abrir conex
                abrirConexion();
                //crear query
                string query = "SELECT " + campos + " FROM " + tabla + " WHERE " + where;
                //instanciar el commando
                com = new MySqlCommand(query, con);
                //ejecutamos el query
                dr = com.ExecuteReader();
                //procesar los resultado de la consulta
                if (dr.HasRows)
                {
                    //por cada registro resultante, leemos
                    while (dr.Read())
                    {
                        //creamos arreglo temporal, donde vaciamos el dr,
                        //y lo agregamos a la lista resultado
                        object[] temp = new object[dr.FieldCount];
                        
                        //por cada valor de cada campo, rellenamos cada elemento del arrelo
                        for (int i = 0; i < temp.Length; i++)
                        {
                            temp[i] = dr[i];
                        }
                        //pasamos el arreglo a la lista 
                        res.Add(temp);
                    }
                }
                else
                {
                    msgError = "NO HAY REGISTROS QUE CUMPLAN CON LOS CRITERIOS DE LA CONSULTA";
                }
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error SQL al consultar." + mysqlex.Message;
            }
            catch (Exception ex)
            {
                msgError = "Error al consultar." + ex.Message;
            }
            finally { cerrarConexion(); }
            //regresamos la lista
            return res;

        }

        public object[] consultarUnRegistro(string campos, string tabla, string where)
        {
            //resultado es un SOLO objexcts, que dentro tiene un arrayyy
            object[] res =null;
            //try catch
            try
            {
                //abrir conex
                abrirConexion();
                //crear query
                string query = "SELECT " + campos + " FROM " + tabla + " WHERE " + where;
                //instanciar el commando
                com = new MySqlCommand(query, con);
                //ejecutamos el query
                dr = com.ExecuteReader();
                //procesar los resultado de la consulta
                if (dr.HasRows)
                {
                    //por cada registro resultante, leemos
                    if (dr.Read())
                    {
                        //creamos arreglo temporal, donde vaciamos el dr,
                        //y lo agregamos a la lista resultado
                        object[] temp = new object[dr.FieldCount];

                        //por cada valor de cada campo, rellenamos cada elemento del arrelo
                        for (int i = 0; i < temp.Length; i++)
                        {
                            temp[i] = dr[i];
                        }
                        //pasamos el arreglo al OBJETO RESULTANTE 
                        res=temp;
                    }
                }
                else
                {
                    msgError = "NO HAY REGISTROS QUE CUMPLAN CON LOS CRITERIOS DE LA CONSULTA";
                }
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error SQL al consultar 1 registro." + mysqlex.Message;
            }
            catch (Exception ex)
            {
                msgError = "Error al consultar 1 registro." + ex.Message;
            }
            finally { cerrarConexion(); }
            //regresamos la lista
            return res;

        }



        /// <summary>
        /// Devuelve un SOLO dstos establecido en la CONSULTA. Este dato es Object, y despues se PARSE a cualqueir tipo deseado
        /// </summary>
        /// <param name="campos">El dato que se quieres objtener, SOLO UNO</param>
        /// <param name="tabla">Tabla para hacer la consulta</param>
        /// <param name="where">Criterio de b{usqueda cuando se requiera, cuando no pasar 1 o 1=1.</param>
        /// <returns>El object con el valor obtenido de la consulta. NULL si hay error o no hay datos.</returns>
        public object consultarUnSoloDato(string campos, string tabla, string where)
        {
            object res = null;
            //try ctahc
            try
            {
                //abrir conex
                abrirConexion();
                //crear query
                string query = "SELECT " + campos + " FROM " + tabla + " WHERE " + where;
                //instanciar el commando
                com = new MySqlCommand(query, con);
                //ejecutamos el query
                res = com.ExecuteScalar();
                //procesar los resultado de la consulta
                if (res==null)
                {
                    msgError = "NO HAY REGISTROS QUE CUMPLAN CON LOS CRITERIOS DE LA CONSULTA";
                }
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error SQL al consultar UN SOLO DATO." + mysqlex.Message;
            }
            catch (Exception ex)
            {
                msgError = "Error al consultar UN SOLO DATO." + ex.Message;
            }
            finally { cerrarConexion(); }
            //
            return res;
        }

        /// <summary>
        /// Abrir conexión
        /// </summary>
        /// <returns>true si se abre, false si no se puede abrir</returns>
        private bool abrirConexion()
        {
            bool res = false;
            try
            {
                //verificar la conex
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                //abrir la conex
                res = true;
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error abriendo la conexion. " + mysqlex.Message;
            }
            return res;
        }//abrirr conexion

        /// <summary>
        /// Cerramos la conexión
        /// </summary>
        /// <returns>true si se cierra la conexion, false, si no se puede cerrar</returns>
        private bool cerrarConexion()
        {
            bool res = false;
            try
            {
                //verificar la conex
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
                //abrir la conex
                res = true;
            }
            catch (MySqlException mysqlex)
            {
                msgError = "Error cerrando la conexion. " + mysqlex.Message;
            }
            return res;
        }//abrirr conexion

    }
}
