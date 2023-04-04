using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//*añadido para XML
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Xml.Linq;

namespace GenteFit.XML
{
    public class ClienteXML
    {
        
        public void GenerarXML()
        {
            //Hace conexion con la BD
            SqlConnection connection = new SqlConnection("connectionString");
            connection.Open();

            //Muestra de la tabla CLIENTE
            SqlCommand command = new SqlCommand("SELECT * FROM Cliente", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            //Genera XML de CLIENTE
            XmlTextWriter writer = new XmlTextWriter("ClienteDatosXML.xml", Encoding.UTF8);
            dataSet.WriteXml(writer);
            writer.Close();

            connection.Close();

        }
            

    }
}
