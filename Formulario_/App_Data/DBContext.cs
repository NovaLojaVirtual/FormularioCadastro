using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;





namespace Formulario_
{
    public class DBContext
    {
        public void Executar(string Sql)
        {
            //Abrir conexão
            string conn = @"Data Source=DESKTOP-HLCT50P\SQLEXPRESS;Initial Catalog=dbcomercio;Integrated Security=True";
            SqlConnection sc = new SqlConnection(conn);//sc objeto da conexão
            sc.Open();

            //fechar conexão

            SqlCommand sqc = new SqlCommand();
            sqc.Connection = sc;
            sqc.CommandText = Sql;
            sqc.ExecuteNonQuery();

            sc.Close();

        }


        public DataTable Consultar(string Sql)
        {
            //Abrir conexão
            string conn = @"Data Source=DESKTOP-HLCT50P\SQLEXPRESS;Initial Catalog=dbcomercio;Integrated Security=True";
            SqlConnection sc = new SqlConnection(conn);
            sc.Open();

            //fechar conexão

            SqlCommand sqc = new SqlCommand();
            sqc.Connection = sc;
            sqc.CommandText = Sql;
            SqlDataReader sr = sqc.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(sr);

            sc.Close();
            return dt;


        }
    }
}