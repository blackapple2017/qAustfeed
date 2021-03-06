<%@ WebHandler Language="C#" Class="HandlerBHQUYDINHBIENDONG" %>

using System;
using System.Web;

public class HandlerBHQUYDINHBIENDONG : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        var Start = 0;
        var Limit = 15;
        var SearchKey = string.Empty;
        var Count = 0;
        var MaDonVi ="";
        if (!string.IsNullOrEmpty(context.Request["start"]))
        {
            Start = int.Parse(context.Request["start"]);
        }
        if (!string.IsNullOrEmpty(context.Request["limit"]))
        {
            Limit = int.Parse(context.Request["limit"]);
        }
        if (!string.IsNullOrEmpty(context.Request["MaDonVi"]))
        {
            MaDonVi = context.Request["MaDonVi"];
        }
        if (!string.IsNullOrEmpty(context.Request["SearchKey"]))
        {
            SearchKey = context.Request["SearchKey"];
            SearchKey = "" + SoftCore.Util.GetInstance().GetKeyword(SearchKey) + "";
        }

        var data = new BHQUYDINHBIENDONGController().GetAllRecord(Start, Limit, SearchKey, out Count,"");
        context.Response.Write(string.Format("{{TotalRecords:{1},'Data':{0}}}", Ext.Net.JSON.Serialize(data), Count));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}
