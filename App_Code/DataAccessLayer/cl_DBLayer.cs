using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Common;
using System.Data;

public class cl_DBLayer
{
    DbConnection CreateConnection(DbProviderFactory factory, string ConStr) 
    {
        var connection = factory.CreateConnection();
        connection.ConnectionString = ConStr;
        connection.Open();
        return connection;
    }
    DbCommand CreateCommand(DbProviderFactory factory, DbConnection connection, string sql, CommandType commandtype, params object[] parms) 
    {
        var command = factory.CreateCommand();
        command.Connection = connection;
        command.CommandText = sql;
        command.CommandType = commandtype;
        command.Parameters.AddRange(parms);
        command.CommandTimeout = 0;
        return command;
    }
    DbDataAdapter CreateAdapter(DbProviderFactory factory, DbCommand command) 
    {
        var adapter = factory.CreateDataAdapter();
        adapter.SelectCommand = command;
        return adapter;
    }

    //this will return scalar value depending on your stored proceedures
    public object Scalar(DbProviderFactory factory, string ConStr, string sql, CommandType commandtype, params object[] parms) 
    {
        using (var connection = CreateConnection(factory, ConStr)) 
        {
            using (var command = CreateCommand(factory, connection, sql, commandtype, parms)) 
            {
                return command.ExecuteScalar();
            }
        }
    }

    public DataTable getDataTable(DbProviderFactory factory, string ConStr, string sql, CommandType commandtype, params object[] parms) 
    {
        using (var connection = CreateConnection(factory, ConStr)) 
        {
            using (var command = CreateCommand(factory,connection,sql,commandtype,parms))
            {
                using (var adapter = CreateAdapter(factory,command))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }

}