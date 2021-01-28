using System.Data.Common;
public class cl_ProvideFactory
{
    public static DbProviderFactory getSqlFactory() 
    {
        return DbProviderFactories.GetFactory("System.Data.SqlClient");
    }

    public static DbProviderFactory getOracleFactory()
    {
        return DbProviderFactories.GetFactory("System.Data.OracleClient");
    }

    public static DbProviderFactory getMySqlClient()
    {
        return DbProviderFactories.GetFactory("MySql.Data.MySqlClient");
    }

}   