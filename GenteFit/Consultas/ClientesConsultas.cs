using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*Librerias añadidas
using GenteFit.Entidades;
using System.Data;
using System.Data.SqlClient;
using GenteFit.BBDD;
using System.Windows.Forms;

namespace GenteFit.Consultas
{
    internal class ClientesConsultas
    {
        private string cadenaConexion = "Data Source = Franky - PC\\NET;Initial Catalog = GenteFITBD; Integrated Security = True";

        public List<string> ObtenerClientes()
        {
            List<string> clientes = new List<string>();

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                string consulta = "SELECT IDCliente, NombreCli, ApellidoCli, TelefonoCli, MailCli FROM Clientes";
                SqlCommand comando = new SqlCommand(consulta, conexion);

                try
                {
                    conexion.Open();
                    SqlDataReader datos = comando.ExecuteReader();

                    while (datos.Read())
                    {
                        string cliente = datos["IDCliente"].ToString() + " - " + datos["NombreCli"].ToString() + " " + datos["ApellidoCli"].ToString() + " - " + datos["TelefonoCli"].ToString() + " - " + datos["MailCli"].ToString();
                        clientes.Add(cliente);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al obtener los clientes: " + ex.Message);
                }
            }

            return clientes;
        }
    }
}
