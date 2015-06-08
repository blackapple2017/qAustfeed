<%@ WebHandler Language="C#" Class="UngVienDuTruHandler" %>

using System;
using System.Web;

public class UngVienDuTruHandler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        var start = 0;
        var limit = 10;
        var searchKey = string.Empty;
        var blackorstore = string.Empty;
        var count = 0;
        var DotTuyenDung = 0;
        if (!string.IsNullOrEmpty(context.Request["start"]))
        {
            start = int.Parse(context.Request["start"]);
        }
        if (!string.IsNullOrEmpty(context.Request["limit"]))
        {
            limit = int.Parse(context.Request["limit"]);
        }
        if (!string.IsNullOrEmpty(context.Request["searchKey"]))
        {
            searchKey = context.Request["searchKey"];
            searchKey = "%" + SoftCore.Util.GetInstance().GetKeyword(searchKey) + "%";
        }
        if (!string.IsNullOrEmpty(context.Request["blackorstore"]))
        {
            blackorstore = context.Request["blackorstore"];
        }
        if (!string.IsNullOrEmpty(context.Request["DotTuyenDung"]))
        {
            DotTuyenDung = int.Parse("0" + context.Request["DotTuyenDung"]);
        }
        count = int.Parse("0" + DataController.DataHandler.GetInstance().ExecuteScalar("dbo.TuyenDung_Count_UngVienDuTru", "@searchKey", "@blackorstore", "@DotTuyenDung", searchKey, blackorstore, DotTuyenDung).ToString());
        var data = DataController.DataHandler.GetInstance().ExecuteDataTable("TuyenDung_UngVienDuTru", "@start", "@limit", "@searchKey", "@blackorstore", "@DotTuyenDung", start, limit, searchKey, blackorstore, DotTuyenDung);

        context.Response.Write(string.Format("{{TotalRecords:{1},'Data':{0}}}", Ext.Net.JSON.Serialize(data), count));
    }

    public bool IsReusable
    {
        get
        {
            return true;
        }
    }

}