using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class cl_DataTransferObject
{
    public string userID { get; set; }
    public bool isActive { get; set; }
    public DateTime dateSubmitted { get; set; }

    #region DISPOSE
    public void Dispose() 
    {
        userID = null;
        isActive = false;
        dateSubmitted = DateTime.Now;
    }
    #endregion
}