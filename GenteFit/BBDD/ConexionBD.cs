﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GenteFit.BBDD
{
    internal class ConexionBD{

        private SqlConnection BD;
        private string connectionString;

        public ConexionBD()
        {
            this.BD = new SqlConnection("Data Source=Franky-PC\\NET;Initial Catalog=GenteFITBD;Integrated Security=True");
        }

        public ConexionBD(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool Conectar()
        {
            try
            {
                this.BD.Open();
                return true;
            }catch(SqlException ex)
            {
                return false;
            }
        }

        public void Desconectar()
        {
            this.BD.Close();
            
        }

        //public SqlConnection GetConnection()
        //{
        //    return BD;
        //}

    }

}
