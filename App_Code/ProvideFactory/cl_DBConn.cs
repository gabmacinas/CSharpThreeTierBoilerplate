using System;
using System.Web;
using System.Configuration;

public class cl_DBConn
{
    public static string MySqlTrans()
        {
            return ConfigurationManager.ConnectionStrings["mySqlClient"].ToString();
        }
    //you can add more multiple db connectionstrings
}