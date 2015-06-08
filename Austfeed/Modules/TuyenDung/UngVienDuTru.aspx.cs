using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using SoftCore.Security;
using System.Data;
using DataController;
using System.Data.SqlClient;
using SoftCore;
using ExtMessage;

public partial class Modules_TuyenDung_UngVienDuTru : WebBase
{    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!X.IsAjaxRequest)
        { 
        }
        hdfType.Reset();
        if (Request.QueryString["type"] == "blacklist")
        {
            hdfType.SetValue("black");            
            btnBlack.Visible = false;            
        }
        else
        {
            if (Request.QueryString["type"] == "store")
            {
                hdfType.SetValue("store");
                btnStore.Visible = false;
            }
            else
            {
                cbx_LyDo.Visible = false;
            }
        }
        df_NgayPhongVan.MinDate = DateTime.Now;
        uscTuyenDung_HoSoUngVien1.AfterUpdate += new EventHandler(uscTuyenDung_HoSoUngVien1_AfterUpdate);
    }

    void uscTuyenDung_HoSoUngVien1_AfterUpdate(object sender, EventArgs e)
    {
        GridPanel1.Reload();
        RowSelectionModel3.ClearSelections();
        btnDelete.Disabled = true;
        btnEdit.Disabled = true;
        btnNext.Disabled = true;
        btnPrint.Disabled = true;
    }
    protected void cbx_tt_honnhanstore_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        try
        {
            cbx_tt_honnhanstore.DataSource = DataHandler.GetInstance().ExecuteDataTable("select MA_TT_HN,TEN_TT_HN from DM_TT_HN");
            cbx_tt_honnhanstore.DataBind();
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message.ToString());
        }
    }
    protected void cbx_LyDoStore_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        try
        {
            string s = "";
            if (Equals(hdfType.Text, "black"))
            {
                s += "LyDoDuaVaoDanhSachHanChe";
            }
            else
            {
                if (Equals(hdfType.Text, "store"))
                s += "LyDoDuaVaoKho";
            }
            cbx_LyDoStore.DataSource = DataHandler.GetInstance().ExecuteDataTable("select ID, Value from dbo.ThamSoTrangThai where ParamName = '" + s + "' AND IsInUsed = 1");
            cbx_LyDoStore.DataBind();
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }
    protected void cbx_Chuyen_LyDo_Store_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        try
        {
            string s = "";
            if (Equals(hdfType.Text, "black"))
            {
                s += "LyDoDuaVaoKho";
            }
            else
            {
                if (Equals(hdfType.Text, "store"))
                    s += "LyDoDuaVaoDanhSachHanChe";
            }
            cbx_Chuyen_LyDo_Store.DataSource = DataHandler.GetInstance().ExecuteDataTable("select ID, Value from dbo.ThamSoTrangThai where ParamName = '" + s + "' AND IsInUsed = 1");
            cbx_Chuyen_LyDo_Store.DataBind();
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }

    public void btnDelete_Click(object sender, DirectEventArgs e)
    {
        try
        {
            foreach (var item in RowSelectionModel3.SelectedRows)
            {
                new HoSoUngVienController().Delete(int.Parse("0" + item.RecordID));
            }
            GridPanel1.Reload();
            RowSelectionModel3.ClearSelections();
            btnDelete.Disabled = true;
            btnEdit.Disabled = true;
            btnNext.Disabled = true;
            btnPrint.Disabled = true;
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }
    public void btnChuyenTiep_Click(object sender, DirectEventArgs e)
    {
        string type="";
        bool datrungtuyen = false;
        HoSoUngVienController hosoungvien = new HoSoUngVienController();
        DAL.HoSoUngVien hsuv = new DAL.HoSoUngVien();
        if (e.ExtraParams["type"] == "toList")
        {
            type = "";
            datrungtuyen = true;
        }
        else
        {
            if (e.ExtraParams["type"] == "toDaTrungTuyen")
            {
                type = "DaTrungTuyen";
                hsuv.DaTrungTuyen = true;
                datrungtuyen = true;
            }
            else
            {
                if (Equals(hdfType.Text, "store"))
                {
                    type = "black";
                }
                else
                {
                    if (Equals(hdfType.Text, "black"))
                    {
                        type = "store";                        
                    }
                }
            }
        }
        try
        {            
            foreach (var item in RowSelectionModel3.SelectedRows)
            {
                hsuv.MaUngVien = decimal.Parse("0" + item.RecordID);
                hsuv.BlackListOrStore = type;
                if (datrungtuyen == false)
                {
                    hsuv.MaLyDo = int.Parse("0" + hdfChuyen_LyDo.Text);
                    hsuv.GhiChu = txt_Chuyen_GhiChu.Text;
                }
                hsuv.XacNhanDiLam = null;
                hosoungvien.ChuyenDanhSach(hsuv, datrungtuyen);                
            }
            wdChuyenLyDo.Hide();
            GridPanel1.Reload();
            RowSelectionModel3.ClearSelections();
            btnDelete.Disabled = true;
            btnEdit.Disabled = true;
            btnNext.Disabled = true;
            btnPrint.Disabled = true;
            Dialog.ShowNotification("Chuyển thành công!");
        }
        catch (Exception ex)
        {
            Dialog.ShowError("Thông báo", "Có lỗi xảy ra: " + ex.Message);
        }
    }   
    public void btn_ChuyenLichHenPV_Click(object sender, DirectEventArgs e)
    {
        try
        {                 
            LichPhongVanController lichphongvan = new LichPhongVanController();
            DAL.LichHenPhongVan lpv = new DAL.LichHenPhongVan();
            HoSoUngVienController hosoungvien = new HoSoUngVienController();
            DAL.HoSoUngVien hsuv = new DAL.HoSoUngVien();
            foreach (var item in RowSelectionModel3.SelectedRows)
            {
                lpv.FR_KEY = decimal.Parse("0" + item.RecordID);
                lpv.CreatedBy = CurrentUser.ID;
                lpv.CreatedDate = DateTime.Now;
                if (!df_NgayPhongVan.SelectedDate.ToString().Contains("0001"))
                    lpv.LichHen = Convert.ToDateTime(df_NgayPhongVan.SelectedDate);
                lpv.ThoiGian = tf_GioPhongVan.Text;
                lpv.ThuTuPhongVan = int.Parse("0" + txt_ThuTuPhongVan.Text);
                lpv.VongPhongVan = int.Parse("0" + txt_VongPhongVan.Text);
                lpv.GhiChu = txt_ghichu.Text;
                lichphongvan.InsertByHoSoUngVien(lpv);
                hsuv.MaUngVien = decimal.Parse("0" + item.RecordID);
                hsuv.BlackListOrStore = "";
                hosoungvien.ChuyenDanhSach(hsuv, false);
            }

            wdChuyenLichHenPV.Hide();
            GridPanel1.Reload();
            RowSelectionModel3.ClearSelections();
            btnDelete.Disabled = true;
            btnEdit.Disabled = true;
            btnNext.Disabled = true;
            btnPrint.Disabled = true;
            Dialog.ShowNotification("Chuyển thành công!");
        }
        catch (Exception ex)
        {
            Dialog.ShowError("Thông báo", "Có lỗi xảy ra: " + ex.Message);
        }
    }
}