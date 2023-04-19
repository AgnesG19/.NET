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
using System.Xml.Serialization;

using GenteFit.BBDD;
using System.IO;

namespace GenteFit.XML
{
    public class ClientesXML
    {
        private readonly string fileName;

        public ClientesXML()
        {
        }

        public ClientesXML(string fileName)
        {
            this.fileName = fileName;
        }

        public List<Cliente> LeerClientes()
        {
            var xml = new XmlSerializer(typeof(List<Cliente>));
            using var file = File.OpenRead(fileName);

            return (List<Cliente>)xml.Deserialize(file);
        }

    }
    //public class ClienteXML
    //{
        
    //    public void GenerarXML()
    //    {
    //        //Hace conexion con la BD
    //        SqlConnection conexion = new SqlConnection("connectionString");
    //        conexion.Open();

    //        //Muestra de la tabla CLIENTE
    //        SqlCommand command = new SqlCommand("SELECT * FROM Cliente", conexion);
    //        SqlDataAdapter adapter = new SqlDataAdapter(command);

    //        DataSet dataSet = new DataSet();
    //        adapter.Fill(dataSet);

    //        //Genera XML de CLIENTE
    //        XmlTextWriter writer = new XmlTextWriter("ClienteDatosXML.xml", Encoding.UTF8);
    //        dataSet.WriteXml(writer);
    //        writer.Close();

    //        conexion.Close();

    //    }

    //}
}
