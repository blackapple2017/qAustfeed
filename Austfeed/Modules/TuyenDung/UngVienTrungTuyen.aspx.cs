using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;
using Ext.Net;
using ExtMessage;
using SoftCore.Security;
using DataController;
using SoftCore;

public partial class Modules_TuyenDung_UngVienTrungTuyen : WebBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!X.IsAjaxRequest)
        {
            DateTime1.MinDate = DateTime.Now;            
            hdfMaDonVi.Text = Session["MaDonVi"].ToString();
            btn_BaoCao.Visible = SetVisible(btn_BaoCao.Text);
        }
    }

    protected void btnRoiNgayDiLam_Click(object sender, DirectEventArgs e)
    {
        try
        {
            string chuoi = DateTime1.SelectedDate.Year + "/" + DateTime1.SelectedDate.Month + "/" + DateTime1.SelectedDate.Day;
            DataHandler.GetInstance().ExecuteDataTable("UpdateNgayDilam", "@ngaycothedilam", "@maungvien", chuoi, int.Parse("0" + hdfMaUngVien.Text));
            wdRoiNgayDiLam.Hide();
            RM.RegisterClientScriptBlock("d", "#{Store1}.reload();");
            Dialog.ShowNotification("Thiết lập thành công !");
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    protected void cbx_Chuyen_LyDo_Store_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        try
        {
            string s = "";
            if (Equals(hdfType.Text, "black"))
            {
                s = "LyDoDuaVaoDanhSachHanChe";
            }
            else
            {
                s = "LyDoDuaVaoKho";
            }
            cbx_Chuyen_LyDo_Store.DataSource = new ThamSoTrangThaiController().GetByParamName(s, true);
            cbx_Chuyen_LyDo_Store.DataBind();
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }

    protected void btnTiepNhan_Click(object sender, DirectEventArgs e) { }
    protected void btnChuyenTiep_Click(object sender, DirectEventArgs e)
    {
        string type = "";
        bool datrungtuyen = false;
        HoSoUngVienController hosoungvien = new HoSoUngVienController();
        DAL.HoSoUngVien hsuv = new DAL.HoSoUngVien();
        if (Equals(hdfType.Text, "toList"))
        {
            type = "";
            datrungtuyen = true;
        }
        else
        {
            if (Equals(hdfType.Text, "store"))
            {
                type = "store";
            }
            else
            {
                if (Equals(hdfType.Text, "black"))
                {
                    type = "black";
                }
            }
        }
        try
        {
            foreach (var item in checkboxSelection.SelectedRows)
            {
                hsuv.MaUngVien = decimal.Parse("0" + item.RecordID);
                hsuv.BlackListOrStore = type;
                if (datrungtuyen == false)
                {
                    hsuv.GhiChu = txt_Chuyen_GhiChu.Text;
                    hsuv.MaLyDo = int.Parse("0" + hdfChuyen_LyDo.Text);
                }
                hosoungvien.ChuyenDanhSach(hsuv, datrungtuyen);
            }
            checkboxSelection.ClearSelections();
            GridPanel1.Reload();
            btnChuyenTiep.Disabled = true;
            btnRoiNgayDiLam.Disabled = true;
            btnTinhTrangDiLam.Disabled = true;
            Dialog.ShowNotification("Chuyển thành công!");
        }
        catch (Exception ex)
        {
            Dialog.ShowError("Lỗi xảy ra " + ex.Message);
        }
    }
    [DirectMethod]
    /// <summary>
    /// Insert dữ liệu vào bảng HOSO dữ liệu lấy từ HoSoUngVien
    /// </summary>
    /// <author>ViVi</author>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public void btnForward_Click(object sender, DirectEventArgs e)
    {
        HoSoUngVienController ctrol = new HoSoUngVienController();
        //hdfMaUngVien.Text;
        //Session["MaDonVi"].ToString();
        //hdfMaKeHoachTuyenDung.text;
        //dfNgayThuViec
        try
        {
            // sinh mã cán bộ
            HoSoController hsController = new HoSoController();
            string newMaCb = hsController.GenerateMaCB(Session["MaDonVi"].ToString());            
            if (!dfNgayThuViec.SelectedDate.ToString().Contains("0001"))
            {
                ctrol.CopyToHoSo(int.Parse("0" + hdfMaUngVien.Text), Session["MaDonVi"].ToString(), int.Parse("0" + hdfMaKeHoachTuyenDung.Text), dfNgayThuViec.SelectedDate, newMaCb);
                wdForwardToHOSO.Hide();
                checkboxSelection.ClearSelections();
                GridPanel1.Reload();
                btnChuyenTiep.Disabled = true;
                btnRoiNgayDiLam.Disabled = true;
                btnTinhTrangDiLam.Disabled = true;
                Dialog.ShowNotification("Chuyển thành công!");
            }
        }
        catch(Exception ex){
            Dialog.ShowError(ex.Message);
        }
    }
    public void mnuXacNhanDiLam_Click(object sender, DirectEventArgs e)
    {
        try
        {
            foreach (var item in checkboxSelection.SelectedRows)
            {
                DAL.HoSoUngVien hsuv = new DAL.HoSoUngVien();
                hsuv.MaUngVien = int.Parse("0" + item.RecordID);
                if (e.ExtraParams["XacNhan"] == "TuChoi")
                { hsuv.XacNhanDiLam = false; }
                else
                { hsuv.XacNhanDiLam = true; }
                new HoSoUngVienController().XacNhanDiLam(hsuv);
            }
            checkboxSelection.ClearSelections();
            GridPanel1.Reload();
            btnChuyenTiep.Disabled = true;
            btnRoiNgayDiLam.Disabled = true;
            btnTinhTrangDiLam.Disabled = true;
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }
}