using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    cl_IDataLayer dl = new cl_DataLayer();
    cl_DataTransferObject dto = new cl_DataTransferObject();
    protected void Page_Load(object sender, EventArgs e)
    {
        bool result;
        if (result = dl.CheckUserAccess(cl_ProvideFactory.getMySqlClient(), cl_DBConn.MySqlTrans(), "username", "examplePassword") == true) 
        {
        //insert statement here
        }


    }
}
