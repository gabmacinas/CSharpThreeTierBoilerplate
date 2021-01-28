using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Web.UI.WebControls;

public class cl_DataLayer : cl_IDataLayer
{
    cl_DBLayer dbLayer = new cl_DBLayer();
    public bool CheckUserAccess(DbProviderFactory factory, string ConStr, string transType, string keyword) 
    {
        SqlParameter[] parms = new SqlParameter[] 
        {
            new SqlParameter("@TransType",transType), //stored proceedure parameters
            new SqlParameter("@Keyword",keyword)
        };
        try
        {
            return Convert.ToBoolean(dbLayer.Scalar(factory,ConStr,"Stored proceedure name",CommandType.StoredProcedure,parms));
        }
        catch {return false;}
    }

    public DataTable getLOV(DbProviderFactory factory, string ConStr, string transType, string type, string item) 
    {
        SqlParameter[] parms = new SqlParameter[]
        {
            new SqlParameter("@TransType",transType) ,
            new SqlParameter("@Type",type),
            new SqlParameter("@Item",item)
        };
        try 
        {
            return dbLayer.getDataTable(factory, ConStr, "SP Name Here", CommandType.StoredProcedure, parms);
        }
        catch { return null; }
    }

    public string Insert_Record(DbProviderFactory factory, string ConStr, cl_DataTransferObject dto, string transType) 
    {
        try 
        {
            return dbLayer.Scalar(factory,ConStr,"sp_InsertRecord",CommandType.StoredProcedure,FillRecordsParameter(dto,transType)).ToString();
        }
        catch 
        {
            return null;
        }
    }
    SqlParameter[] FillRecordsParameter(cl_DataTransferObject dto,string transType) 
    {
        return new SqlParameter[] 
        {
            new SqlParameter("@TransType",transType),
            new SqlParameter("@UserID",dto.userID),
            new SqlParameter("@IsActive",dto.isActive),
            new SqlParameter("@DateSubmitted",dto.dateSubmitted)
        };
    }

}