<%@ WebHandler Language="C#" Class="HoSoUngVienHandler" %>

using System;
using System.Web;
using Ext.Net;
using System.Collections.Generic;
using SoftCore.Security;

public class HoSoUngVienHandler : IHttpHandler
{

    public void ProcessRequest(HttpContext context)
    {
        var Start = 0;
        var Limit = 20;
        var SearchKey = string.Empty;
        var Count = 0;
        var DotTuyenDung = 0;

        if (!string.IsNullOrEmpty(context.Request["start"]))
        {
            Start = int.Parse("0" + context.Request["start"]);
        }
        if (!string.IsNullOrEmpty(context.Request["limit"]))
        {
            Limit = int.Parse("0" + context.Request["limit"]);
        }
        if (!string.IsNullOrEmpty(context.Request["SearchKey"]))
        {
            SearchKey = context.Request["SearchKey"];
            SearchKey = "%" + SoftCore.Util.GetInstance().GetKeyword(SearchKey) + "%";
        }
        if (!string.IsNullOrEmpty(context.Request["DotTuyenDung"]))
        {
            DotTuyenDung = int.Parse("0"+context.Request["DotTuyenDung"]);
        }   
        System.Data.DataTable kehoach = DataController.DataHandler.GetInstance().ExecuteDataTable("tuyendung_danhsachUV",
                                                                                                    "@SearchKey", 
                                                                                                    "@DotTuyenDung",                                            
                                                                                                    "@Start",
                                                                                                    "@Limit", SearchKey, DotTuyenDung, Start, Limit);
        object obj = DataController.DataHandler.GetInstance().ExecuteScalar("tuyendung_CountdanhsachUV",
                                                                            "@SearchKey",
                                                                            "@DotTuyenDung",
                                                                            SearchKey, DotTuyenDung);
        if (obj!=null)
        {
            Count = int.Parse(obj.ToString());
        }
        context.Response.Write(string.Format("{{TotalRecords:{1},'Data':{0}}}", Ext.Net.JSON.Serialize(kehoach), Count));
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}