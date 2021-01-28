using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

public class cl_Common
{
    public static void FillLOV(RadioButtonList rbl, DataTable dtValue, string valueField, string textField) 
    {
        try 
        {
            if (dtValue.Rows.Count > 0) 
            {
                rbl.DataSource = dtValue;
                rbl.DataTextField = textField;
                rbl.DataValueField = valueField;
                rbl.DataBind();
            }
        }
        catch
        {
        
        }
    }
    public static void FillLOV(DropDownList ddl, DataTable dtValue, string valueField, string textField) 
    {
        try 
        {
            if (dtValue.Rows.Count > 0) 
            {
                ddl.DataSource = dtValue;
                ddl.DataTextField = textField;
                ddl.DataValueField = valueField;
                ddl.DataBind();
            }
        }
        catch 
        {

        }
    }

    //public static void FillLOV(ComboBox cmb, DataTable dtValue, string valueField, string textField) 
    //{
    //    try 
    //    {
    //        if (cmb.Rows.Count > 0) 
    //        {
    //            cmb.DataSource = dtValue;
    //            cmb.DataTextField = textField;
    //            cmb.DataValueField = valueField;
    //            cmb.DataBind();
    //        }
    //    }
    //    catch { }
    //}
}