using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GenteFit.XML
{
    public class ClienteXML
    {
        
        public void GenerarXML()
        {
            //Falta paquete para sqlCommand
            SqlConnection connection = new SqlConnection("connectionString");
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Cliente", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            XmlTextWriter writer = new XmlTextWriter("archivo.xml", Encoding.UTF8);
            dataSet.WriteXml(writer);
            writer.Close();

            connection.Close();

        }
            

    }
}
