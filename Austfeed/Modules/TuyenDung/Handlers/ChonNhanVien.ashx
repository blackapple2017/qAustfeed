<%@ WebHandler Language="C#" Class="ChonNhanVien" %>

using System;
using System.Web;

public class ChonNhanVien : IHttpHandler {


    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/json";
        var start = 0;
        var limit = 4;
        var sort = string.Empty;
        var dir = string.Empty;
        var query = string.Empty;
        int Count = 0;             
        if (!string.IsNullOrEmpty(context.Request["start"]))
        {
            start = int.Parse(context.Request["start"]);
        }
        if (!string.IsNullOrEmpty(context.Request["limit"]))
        {
            limit = int.Parse(context.Request["limit"]);
        }
        if (!string.IsNullOrEmpty(context.Request["query"]))
        {
            query = context.Request["query"];
        } 
        if (!string.IsNullOrEmpty(context.Request["query"]))
        {
            query = context.Request["query"];
            query = SoftCore.Util.GetInstance().GetKeyword(query);
        }        
        var data = DataController.DataHandler.GetInstance().ExecuteDataTable("sp_GetDSCanBo_ComBoBox", "@start", "@limit", "@searchKey", start, limit, query);
        var count = DataController.DataHandler.GetInstance().ExecuteDataTable("CountDM_NhanVien", "@searchKey", query);
        Count = Convert.ToInt32(count.Rows.Count);        
        context.Response.Write(string.Format("{{total:{1},'plants':{0}}}", Ext.Net.JSON.Serialize(data), Count));
    }
    public System.Data.DataTable GetAllRecord(int start, int limit, string query, string MaDonVi, out int count)
    {
        System.Data.DataTable ccount = DataController.DataHandler.GetInstance().ExecuteDataTable("CountDM_NhanVien", "@searchKey", query);
        count = Convert.ToInt32(ccount.Rows.Count);
        System.Data.DataTable dt = DataController.DataHandler.GetInstance().ExecuteDataTable("GetTaiSanByDonVi", "@start", "@limit", "@searchKey", start, limit, query);
        return dt;
    }
    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}