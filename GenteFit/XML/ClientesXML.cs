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
using GenteFit.Entidades;


//********* USADO PARA EL PRODUCTO2 *********//
//namespace GenteFit.XML
//{
//    public class ClientesXML
//    {
//        private readonly string fileName;

//        public ClientesXML(string fileName)
//        {
//            this.fileName = fileName;
//        }

//        public List<Cliente> LeerClientes()
//        {
//            var xml = new XmlSerializer(typeof(List<Cliente>), new XmlRootAttribute("Clientes"));
//            using (var file = File.OpenRead(fileName))

//                return (List<Cliente>)xml.Deserialize(file);
//        }
//    }
//}
//USANDO ARRAY
//    public List<Entidades.Cliente> LeerClientes()
//    {
//        //List<Cliente> clientes = new List<Cliente>();
//        List<Entidades.Cliente> clientes = new List<Entidades.Cliente>();

//        XmlSerializer xml = new XmlSerializer(typeof(ArrayOfClientes));
//        using (FileStream file = new FileStream("A:\Program Files\Code\NET\.NET\GenteFit\XML\Clientes.xml", FileMode.Open))
//        {
//            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
//            namespaces.Add("", "http://www.example.com/Clientes");
//            ArrayOfClientes array = (ArrayOfClientes)xml.Deserialize(file);
//            clientes = array.Clientes;
//        }
//        return clientes;
//    }
//}


//PRIMER INTENTO
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

