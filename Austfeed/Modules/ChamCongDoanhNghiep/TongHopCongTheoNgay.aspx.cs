using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using SoftCore.Security;
using ExtMessage;
using System.Data.SqlClient;
/// <summary>
/// @ Thế Tư
/// </summary>
public partial class Modules_ChamCongDoanhNghiep_TongHopCongTheoNgay : WebBase
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!X.IsAjaxRequest)
        {
            new DTH.BorderLayout()
            {
                menuID = MenuID,
                script = "#{hdfSelectedDepartment}.setValue('" + DTH.BorderLayout.nodeID + "');txtSearchKey.reset();PagingToolbar1.pageIndex = 0; PagingToolbar1.doLoad();"
            }.AddDepartmentList(brlayout, CurrentUser.ID, true);

            hdfUserID.SetValue(CurrentUser.ID);
            hdfMenuID.SetValue(MenuID);

            dfNgayChamCong.SetValue(DateTime.Now);
            GenerateGridColumn();
            int phut = int.Parse("0" + DataController.DataHandler.GetInstance().ExecuteScalar("LayThoiGianCapNhatLonNhat").ToString());
            int h, m, ngay;
            ngay = phut / 1440;
            h = phut % 1440 / 60;
            m = phut % 1440 % 60;
            string str = "";
            if (ngay > 0)
            {
                str = ngay + " ngày " + h + " giờ " + m;
            }
            else
            {
                if (h > 0)
                    str = h + " giờ " + m;
                else str = m.ToString();
            }
            dpfPhut.Text = "<b>Cập nhật lần cuối : " + str + " phút trước";
        }

        SetVisibleByControlID(btnAddNhanVien, btnEditOnGrid);
        SetEditOnGrid();
    }

    private Ext.Net.Column GetColumn(string header, string dataIndex, int width)
    {
        Column column = new Column()
        {
            ColumnID = dataIndex,
            Header = header,
            Width = width,
            DataIndex = dataIndex,
            Align = Alignment.Right,
        };
        return column;
    }
    private void SetEditor(int max)
    {
        for (int i = 5; i < 5 + max; i++)
        {
            Ext.Net.TextField txtEditor = new TextField();
            txtEditor.MaskRe = "/[0-9:]/";
            txtEditor.MaxLength = 8;
            txtEditor.ID = "txtEditor" + (i - 2);
            grpVaoRaCa.ColumnModel.Columns[i].Editor.Add(txtEditor);
            if (btnEditOnGrid.Visible)
                grpVaoRaCa.ColumnModel.Columns[i].Editable = true;
            else
                grpVaoRaCa.ColumnModel.Columns[i].Editable = false;
        }
    }
    private void GenerateGridColumn()
    {
        int max = int.Parse("0" + DataController.DataHandler.GetInstance().ExecuteScalar("LaySoLuotChamCongLonNhat").ToString());
        hdfMax.Text = max.ToString();
        var grid = grpVaoRaCa;
        var store = grid.GetStore();
        var cm = grid.ColumnModel;
        store.Reader[0].Fields.Add("PhongBan");
        Column PhongBan = new Column()
        {
            ColumnID = "PhongBan",
            Header = "Phòng ban",
            Width = 150,
            DataIndex = "PhongBan"

        };
        cm.Columns.Insert(4, PhongBan);
        for (int i = 0; i < max; i++)
        {
            int k = i + 1;
            // add to store
            store.Reader[0].Fields.Add("Lan" + k);
            cm.Columns.Insert(i + 5, GetColumn("Lần " + k, "Lan" + k, 60));
        }
        SetEditor(max);
    }

    private void SetEditOnGrid()
    {
        foreach (var item in grpVaoRaCa.ColumnModel.Columns)
        {
            if (btnEditOnGrid.Visible)
                item.Editable = true;
            else
                item.Editable = false;
        }
    }

    [DirectMethod(Namespace = "TongHopCongTheoNgay")]
    public void AfterEdit(string field, string oldValue, string newValue, TongHopCongTheoNgayInfo oj)
    {
        try
        {
            if (oldValue != "" && field.Substring(0, 3) == "Lan")
            {
                bool check = true;
                string[] item = newValue.Split(':');
                if (item.Length != 3)
                {
                    Dialog.ShowError("Dữ liệu cập nhật không hợp lệ.");
                    check = false;
                }
                else
                    //if (int.Parse("0" + item[0]) > 24m || item[0] == "")
                    //{
                    //    Dialog.ShowError("Giờ không hợp lệ");
                    //    check = false;
                    //}
                    //else
                    if (int.Parse("0" + item[1]) > 59 || item[1] == "")
                    {
                        Dialog.ShowError("Phút không hợp lệ");
                        check = false;
                    }
                    else
                        if (int.Parse("0" + item[2]) > 59 || item[2] == "")
                        {
                            Dialog.ShowError("Giây không hợp lệ");
                            check = false;
                        }
                if (check == true)
                {
                    DAL.VaoRaCa data = new DAL.VaoRaCa();
                    data.MaChamCong = oj.MaChamCong;

                    if (!SoftCore.Util.GetInstance().IsDateNull(dfNgayChamCong.SelectedDate))
                        data.NgayChamCong = DateTime.Parse(dfNgayChamCong.SelectedDate.ToString("yyyy-MM-dd"));
                    data.Time = newValue;
                    if (int.Parse("0" + item[0]) > 24m || item[0] == "")
                    {
                        newValue = "23:59:00";
                    }
                    DateTime ngayChamCong = DateTime.Parse(dfNgayChamCong.SelectedDate.ToString("yyyy-MM-dd") + " " + newValue);
                    new VaoRaCaController().UpdateTime(data, oldValue, ngayChamCong);
                    Store1.CommitChanges();
                }
                else
                {
                    Store1.CommitChanges();
                    this.grpVaoRaCa.Reload();
                }
            }
            else
            {
                if (string.IsNullOrEmpty(newValue) && string.IsNullOrEmpty(oldValue))
                {
                    Store1.CommitChanges();
                }
                else
                {
                    if (string.IsNullOrEmpty(newValue) && field != "KyHieuChamCong" && field != "GhiChu")
                        newValue = "0";
                    else
                        if (string.IsNullOrEmpty(newValue) && (field == "KyHieuChamCong" || field == "GhiChu"))
                            newValue = "";
                    new TongHopCongTheoNgayController().Update(oj.ID, field, newValue);
                    Store1.CommitChanges();
                }
            }
        }
        catch (Exception ex) { Dialog.ShowError(ex.Message); }
    }
    protected void btnCapNhatThem_Click(object sender, DirectEventArgs e)
    {
        try
        {
            var check = DataController.DataHandler.GetInstance().ExecuteScalar("checkMaChamCong", "@PrKey",
                                                                  hdfChonCanBo.Text);
            if (check != "" && check != null)
            {
                new TongHopCongTheoNgayController().Insert(hdfChonCanBo.Text, "", hdfKyHieuChamCong.Text, txtArGhiChu.Text, dfNgayChamCong.SelectedDate);
                Dialog.ShowNotification("Thêm thành công");
                grpVaoRaCa.Reload();
                if (e.ExtraParams["Close"] == "True")
                {
                    wdAddWindow.Hide();
                }
                else
                {
                    RM.RegisterClientScriptBlock("resetForm", "ResetwdAddWindow();");
                }
            }
            else
            {
                cbxChonCanBo.Reset();
                cbxChonCanBo.Focus();
                Dialog.ShowError("Nhân viên chưa có mã máy chấm công. Thêm không thành công");
            }
        }
        catch (SqlException sqlex)
        {
            if (sqlex.ToString().Contains("UNIQUE"))
                Dialog.ShowError("Nhân viên đã có trong danh sách tổng hợp công theo ngày");
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }
}