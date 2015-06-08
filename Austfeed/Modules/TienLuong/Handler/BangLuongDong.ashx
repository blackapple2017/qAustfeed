<%@ WebHandler Language="C#" Class="BangLuongDong" %>

using System;
using System.Web;

public class BangLuongDong : IHttpHandler
{
    public void ProcessRequest(HttpContext context)
    {
        int start = 0, limit = 30;
        string searchKey = string.Empty, maDonVi = "";
        int idBangLuong = 0;
        int userID = 0, menuID = 0;

        if (!string.IsNullOrEmpty(context.Request["start"]))
            start = int.Parse(context.Request["start"]);
        if (!string.IsNullOrEmpty(context.Request["limit"]))
            limit = int.Parse(context.Request["limit"]);
        if (!string.IsNullOrEmpty(context.Request["UserID"]))
            userID = int.Parse(context.Request["UserID"]);
        if (!string.IsNullOrEmpty(context.Request["MenuID"]))
            menuID = int.Parse(context.Request["MenuID"]);
        if (!string.IsNullOrEmpty(context.Request["MaDonVi"]))
            maDonVi = context.Request["MaDonVi"];
        if (!string.IsNullOrEmpty(context.Request["SearchKey"]))
            searchKey = SoftCore.Util.GetInstance().GetKeyword(context.Request["SearchKey"]);
        if (!string.IsNullOrEmpty(context.Request["IDBangLuong"]))
            idBangLuong = int.Parse("0" + context.Request["IDBangLuong"]);

        var data = DataController.DataHandler.GetInstance().ExecuteDataTable("TienLuong_GetBangLuongDong",
                "@Start", "@Limit", "@SearchKey", "@IdBangLuong", "@MenuID", "@UserID", "@MaDonVi", 
                start, limit, searchKey, idBangLuong, menuID, userID, maDonVi);
        var count = int.Parse(DataController.DataHandler.GetInstance().ExecuteScalar("TienLuong_CountBangLuongDong",
                "@SearchKey", "@IdBangLuong", "@MenuID", "@UserID", "@MaDonVi", 
                searchKey, idBangLuong, menuID, userID, maDonVi).ToString());
        context.Response.Write(string.Format("{{TotalRecords:{1},'Data':{0}}}", Ext.Net.JSON.Serialize(data), count));
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

}