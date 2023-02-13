using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD_SixD.Models
{
    public class GestorUsuario
    {
        public List<Usuario> getUsuario()
        {
            List<Usuario> lista = new List<Usuario>();
            string strCon = ConfigurationManager.ConnectionStrings["BDlocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "UsuarioAll";
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //int id = dr.GetInt32(0);
                    string nombre = dr.GetString(0).Trim();
                    string apellido = dr.GetString(1).Trim();

                    Usuario usuario = new Usuario(nombre,apellido);


                    lista.Add(usuario);
                }

                dr.Close();
                conn.Close();

                
            }


            return lista;
        }

        public bool AddUsuario(int id,Usuario usuario)
        {
            bool rta = false;

            string strCon = ConfigurationManager.ConnectionStrings["BDlocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                cmd.CommandText = "UsuarioAdd";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    rta = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    rta = false;
                    throw;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }

                return rta;
            }
        }

        public bool UpdateUsuario(int id,Usuario usuario)
        {
            bool rta = false;

            string strCon = ConfigurationManager.ConnectionStrings["BDlocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                cmd.CommandText = "UsuarioUpdate";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@apellido", usuario.Apellido);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    rta = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    rta = false;
                    throw;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }

                return rta;
            }
        }

        public bool DeleteUsuario(int id)
        {
            bool rta = false;

            string strCon = ConfigurationManager.ConnectionStrings["BDlocal"].ToString();

            using (SqlConnection conn = new SqlConnection(strCon))
            {
                SqlCommand cmd = conn.CreateCommand();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                cmd.CommandText = "UsuarioDelete";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id", id);


                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    rta = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    rta = false;
                    throw;
                    throw;
                }
                finally
                {
                    cmd.Parameters.Clear();
                    conn.Close();
                }

                return rta;
            }
        }
    }
}