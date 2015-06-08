﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using SoftCore.Security;
using System.Data;
using DataController;
public partial class Modules_BaoHiem_tesst : UserControlBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        hdfMaDonVi.Text = Session["MaDonVi"].ToString();
    }
    protected void Store_ddfCheDoNghi_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        //int a;
        //Store_ddfCheDoNghi.DataSource = new CheDoBaoHiemController().GetAll(Session["MaDonVi"].ToString(),out a);
        //Store_ddfCheDoNghi.DataBind();
        LoadCha(-2);
    }
    public void LoadCha(int idchedobh)
    {
        List<CheDoBaoHiemInfo> lists = new CheDoBaoHiemController().GetbyParentID(0, -1);
        List<object> obj = new List<object>();
        //obj.Add(new { ParentID = "0", TenCheDoBaoHiem = "Là gốc" });

        foreach (CheDoBaoHiemInfo info in lists)
        {
            if (info.ParentID == 0)
            {
               //    obj.Add(new { ID = info.IDCheDoBaoHiem, TenCheDoBaoHiem = info.TenCheDoBaoHiem });
                obj = LoadMenuCon(obj, info.IDCheDoBaoHiem, 1, idchedobh);
            }
            if (idchedobh == info.IDCheDoBaoHiem)
            {
                ddfCheDoNghi.SelectedItem.Text = info.TenCheDoBaoHiem;
                //ddfCheDoNghi.SelectedItem.Value = info.IDCheDoBaoHiem.ToString();
                break;
            }
        }
        Store_ddfCheDoNghi.DataSource = obj;
        Store_ddfCheDoNghi.DataBind();
    }
    [DirectMethod]
    public void DeleteRecord(int id)
    {
        new BangTinhCheDoBaoHiemController().Delete(id);
    }
    [DirectMethod]
    public void Resetwindown()
    {
        wdBangTinhCheDoBaoHiem.Title = "Thêm mới công thức tính chế độ bảo hiểm";
        wdBangTinhCheDoBaoHiem.Icon = Icon.Add;
    }
    protected void btnDouble_Click(object sender, DirectEventArgs e)
    {

    }
    protected void btnEdit_Click(object sender, DirectEventArgs e)
    {
        wdBangTinhCheDoBaoHiem.Show();
        wdBangTinhCheDoBaoHiem.Title = "Sửa công thức tính chế độ bảo hiểm";
        wdBangTinhCheDoBaoHiem.Icon = Icon.Pencil; int idbh = 0;
        if (!string.IsNullOrEmpty(hdfIdTinhCheDoBH.Text))
        {
            idbh = Convert.ToInt32(hdfIdTinhCheDoBH.Text);
        }

        DAL.BHBANGTINHCHEDOBAOHIEM cdbh = new BangTinhCheDoBaoHiemController().GetByPrKey(idbh);
        hdfIdTinhCheDoBH.Text = cdbh.IDBangTinhCheDoBaoHiem.ToString();
        LoadCha(cdbh.IDCheDoBaoHiem);
        hdfCheDoNghi.Text = cdbh.IDCheDoBaoHiem.ToString();

        txtMaDieuKienHuong.Text = cdbh.MaDieuKienHuong;
        txtDieuKienHuong.Text = cdbh.TenDieuKienHuong;
        string tg = "0";
        nfThoiGianDongBaoHiem.Text = cdbh.DKThoiGianDongBH == null ? tg : ((float)cdbh.DKThoiGianDongBH).ToString();
        nfThoiGianHuongCheDo.Text = cdbh.DKThoiGianToiDaHuongCheDo.ToString();
        txaCongThuc.Text = cdbh.CongThuc;
        txaYeuCauThuTuc.Text = cdbh.YeuCauThuTuc;
        txaDienGiai.Text = cdbh.DienGiai;
        //BangTinhCheDoBaoHiem1_wdBangTinhCheDoBaoHiem.show();
        wdBangTinhCheDoBaoHiem.Show();
    }
    private List<object> LoadMenuCon(List<object> obj, int menuID, int k, int idchedobh)
    {
        List<CheDoBaoHiemInfo> lists = new CheDoBaoHiemController().GetbyParentID(menuID, -1);
        foreach (var item in lists)
        {
            string tmp = "";
            for (int i = 0; i < k; i++)
                tmp += "- ";
            obj.Add(new { ID = item.IDCheDoBaoHiem, TenCheDoBaoHiem = tmp + item.TenCheDoBaoHiem });
            if (idchedobh == item.IDCheDoBaoHiem)
            {
                ddfCheDoNghi.SelectedItem.Text = item.TenCheDoBaoHiem;
                //ddfCheDoNghi.SelectedItem.Value = item.IDCheDoBaoHiem.ToString();
                break;
            }
            obj = LoadMenuCon(obj, item.IDCheDoBaoHiem, k + 1, idchedobh);

        }
        return obj;
    }
    protected void MyData_Refresh(object sender, StoreRefreshDataEventArgs e)
    {

    }
    protected void Add_Click(object sender, DirectEventArgs e)
    {
        DAL.BHBANGTINHCHEDOBAOHIEM dl = new DAL.BHBANGTINHCHEDOBAOHIEM();
        //cdbh.IDCheDoBaoHiem=
        dl.IDCheDoBaoHiem = hdfCheDoNghi.Text == null || hdfCheDoNghi.Text == "" ? 0 : Convert.ToInt32(hdfCheDoNghi.Value.ToString());
        dl.MaDonVi = Session["MaDonVi"].ToString();
        dl.TenDieuKienHuong = txtDieuKienHuong.Text;
        dl.DKThoiGianDongBH = decimal.Parse(nfThoiGianDongBaoHiem.Value.ToString().Replace(".", ","));
        dl.DKThoiGianToiDaHuongCheDo = nfThoiGianHuongCheDo.Text == "" ? 0 : Convert.ToInt32(nfThoiGianHuongCheDo.Value);
        dl.CongThuc = txaCongThuc.Text;
        dl.YeuCauThuTuc = txaYeuCauThuTuc.Text;
        dl.DienGiai = txaDienGiai.Text;
        dl.DateCreate = DateTime.Now;
        dl.MaDieuKienHuong = txtMaDieuKienHuong.Text;
        dl.UserID = CurrentUser.ID;
        if (e.ExtraParams["update"] == "True")
        {
            dl.IDBangTinhCheDoBaoHiem = Convert.ToInt32(hdfIdTinhCheDoBH.Text);
            new BangTinhCheDoBaoHiemController().Update(dl);
            wdBangTinhCheDoBaoHiem.Hide();
        }
        else
        {
            DataTable dt = DataHandler.GetInstance().ExecuteDataTable("GetBangTinhCDBH_MaDieuKienHuong", "@MaDieuKienHuong", txtMaDieuKienHuong.Text);
            if (dt.Rows.Count > 0)
            {
                X.MessageBox.Alert("Thông báo", "Mã điều kiện hưởng đã tồn tại, vui lòng chọn mã khác").Show();
                txtMaDieuKienHuong.Focus();
                return;
            }
            else
            {
                new BangTinhCheDoBaoHiemController().Insert(dl);
            }
        }
        grpbangtinhchedobaohiem.Reload();
        if (e.ExtraParams["Close"] == "True")
        {
            wdBangTinhCheDoBaoHiem.Hide();
        }
    }
}