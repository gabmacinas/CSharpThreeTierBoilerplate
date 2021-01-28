using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Common;
using System.Web.UI.WebControls;

public interface cl_IDataLayer
{
    bool CheckUserAccess(DbProviderFactory factory, string ConStr, string transType, string keyword);
    DataTable getLOV(DbProviderFactory factory, string ConStr, string transType, string type, string item);
    string Insert_Record(DbProviderFactory factory, string ConStr, cl_DataTransferObject dto, string transType);


}