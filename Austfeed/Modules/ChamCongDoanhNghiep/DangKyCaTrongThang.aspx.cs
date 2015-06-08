using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using DAL;
using SoftCore.Security;
using Controller.ChamCongDoanhNghiep;
using DataController;
using ExtMessage;
using System.Data.SqlClient;

public partial class Modules_ChamCongDoanhNghiep_ThietLapCaChoNhanVien : WebBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!X.IsAjaxRequest)
        {
            hdfUserID.SetValue(CurrentUser.ID);
            hdfMenuID.SetValue(MenuID);
            SetEditor();
            hdfMaDonVi.Text = Session["MaDonVi"].ToString();
            new DTH.BorderLayout()
            {
                menuID = MenuID,
                script = "#{hdfMaDonVi}.setValue('" + DTH.BorderLayout.nodeID + "');txtSearchKey.reset();PagingToolbar1.pageIndex = 0; PagingToolbar1.doLoad();"
            }.AddDepartmentList(br, CurrentUser.ID, true);
            LoadDonVi();
            FindDayOfWeek(DateTime.Now.Month, DateTime.Now.Year);

            DAL.DanhSachBangPhanCa phanCa = new DanhSachBangPhanCaController().GetByMonthAndYear(DateTime.Now.Month, DateTime.Now.Year, hdfMaDonVi.Text);
            if (phanCa != null)
            {
                hdfIDBangPhanCa.Text = phanCa.ID.ToString();
                grpDanhSachBangPhanCaThang.Title = phanCa.TenBangPhanCa;

            }
        }
        ucChooseEmployee1.AfterClickAcceptButton += new EventHandler(ucChooseEmployee1_AfterClickAcceptButton);
    }

    void ucChooseEmployee1_AfterClickAcceptButton(object sender, EventArgs e)
    {

        try
        {
            BangPhanCaThangController controller = new BangPhanCaThangController();
            int count = 0;
            if (hdfIDBangPhanCa.Text != "")
            {
                foreach (var item in ucChooseEmployee1.SelectedRow)
                {

                    try
                    {
                        DAL.BangPhanCaThang obj = new BangPhanCaThang()
                                {
                                    CreatedBy = CurrentUser.ID,
                                    CreatedDate = DateTime.Now,
                                    MaCB = item.RecordID,
                                    MaDanhSachBangPhanCa = int.Parse(hdfIDBangPhanCa.Text),
                                };
                        controller.Add(obj);
                    }
                    catch (SqlException sql)
                    {
                        if (sql.ToString().Contains("UNIQUE"))
                        {
                            count++;
                            continue;
                        }

                    }
                    catch (Exception)
                    {

                    }
                }
                grpDanhSachBangPhanCaThang.Reload();
                if (count > 0)
                {
                    Dialog.ShowError("Nhân viên đã có trong danh sách bảng phân ca sẽ không được thêm. Các nhân viên khác thêm thành công.");
                }
            }
            else Dialog.ShowError("Bạn chưa chọn bảng phân ca tháng");
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }

    protected void HandleChanges(object sender, BeforeStoreChangedEventArgs e)
    {
        ChangeRecords<BangChamCongThangInfo> bangchamcongthang = e.DataHandler.ObjectData<BangChamCongThangInfo>();
        foreach (BangChamCongThangInfo update in bangchamcongthang.Updated)
        {

        }
    }

    #region Các thao tác liên quan tới Grid
    private void SetEditor()
    {
        int count;
        List<DanhSachCaInfo> data = new DanhSachCaController().GetAll(0, 100, Session["MaDonVI"].ToString(), "", out count);

        this.Store2.DataSource = DataHandler.GetInstance().ExecuteDataTable("select ID,MaCa,TenCa,GioVao,GioRa from ChamCong.DanhSachCa where MaDonVi = N'" + Session["MaDonVI"].ToString() + "'");
        this.Store2.DataBind();

        foreach (var col in grpDanhSachBangPhanCaThang.ColumnModel.Columns)
        {
            //     Ext.Net.MultiCombo cbWorkingStatus = new MultiCombo();
            Ext.Net.ComboBox cbWorkingStatus = new ComboBox();
            cbWorkingStatus.StoreID = "Store2";
            cbWorkingStatus.Width = 60;
            cbWorkingStatus.ListWidth = 300;
            cbWorkingStatus.ID = "cb" + col.ColumnID;
            cbWorkingStatus.TypeAhead = true;
            cbWorkingStatus.ForceSelection = true;
            //    cbWorkingStatus.SelectionMode = MultiSelectMode.Selection;
            cbWorkingStatus.DisplayField = "TenCa";
            cbWorkingStatus.ValueField = "MaCa";
            cbWorkingStatus.Editable = false;
            cbWorkingStatus.Mode = DataLoadMode.Local;
            cbWorkingStatus.ItemSelector = "tr.list-item";
            cbWorkingStatus.Template.Html = @"
                                            <tpl for=""."">
						                        <tpl if=""[xindex] == 1"">
							                        <table class=""cbStates-list"">
								                        <tr>
									                        <th>Mã ca</th>
									                        <th>Tên ca</th>
								                        </tr>
						                        </tpl>
						                        <tr class=""list-item"">
							                        <td style=""padding:3px 0px;"">{MaCa}</td>
							                        <td>{TenCa} ({GioVao} đến {GioRa})</td>
						                        </tr>
						                        <tpl if=""[xcount-xindex]==0"">
							                        </table>
						                        </tpl>
					                        </tpl>
                                            ";

            if (col.ColumnID.StartsWith("Ngay"))
            {
                col.Editor.Add(cbWorkingStatus);
                // col.DataIndex = "MaCa";
            }
        }
    }
    /// <summary>
    /// Tìm thứ trong tuần và tô màu ngày cuối tuần
    /// </summary>
    /// <param name="IdBangChamCong"></param>
    private void FindDayOfWeek(int month, int year)
    {
        try
        {
            int totalDays = DateTime.DaysInMonth(year, month);//tổng số ngày trong tháng 
            DateTime date = new DateTime(year, month, 1);
            string styleWeekend = "";

            foreach (var col in grpDanhSachBangPhanCaThang.ColumnModel.Columns)
            {
                if (col.ColumnID.StartsWith("Ngay"))
                {
                    string DayOfWeek = "";
                    switch (date.DayOfWeek.ToString())
                    {
                        case "Monday":
                            DayOfWeek = " T2";
                            break;
                        case "Tuesday":
                            DayOfWeek = " T3";
                            break;
                        case "Wednesday":
                            DayOfWeek = " T4";
                            break;
                        case "Thursday":
                            DayOfWeek = " T5";
                            break;
                        case "Friday":
                            DayOfWeek = " T6";
                            break;
                        case "Saturday":
                            DayOfWeek = " T7";
                            break;
                        case "Sunday":
                            DayOfWeek = " CN";
                            break;
                    }
                    //if (col.ColumnID != "NgayHomNay")
                    //{
                    //      dictionaryDay.Add(col.DataIndex, day);
                    if (int.Parse(col.ColumnID.Replace("Ngay", "")) > totalDays)
                    {
                        col.Hidden = true;
                        continue;
                    }
                    if (DayOfWeek.Contains("CN") || DayOfWeek.Contains("Thứ 7"))
                    {
                        styleWeekend += ".x-grid3-td-Ngay" + date.Day + ",";
                    }
                    date = date.AddDays(1);
                    col.Header += DayOfWeek;
                    //}
                    //else
                    //{
                    //    if (bangChamCong.StartDate.Month != DateTime.Today.Month)
                    //    {
                    //        col.Hidden = true;
                    //        mnuToday.Visible = false;
                    //        mnuChamCongHomNay.Visible = false;
                    //    }
                    //    else
                    //    {
                    //        mnuChamCongHomNay.Visible = true;
                    //    }
                    //    col.Header += " " + SoftCore.Util.GetInstance().GetTodayName();
                    //}
                    //col.Header += DayOfWeek;
                }
            }
            //set weekend style + today style
            //   styleWeekend += "{background-color:#e3e6eb;}.x-grid3-td-Ngay" + DateTime.Today.Day + "{background-color:#ff6600}";
            ltrweekendStyle.Text = "<style type='text/css'>" + styleWeekend + "nothing</style>";
            //   GridPanel1.Reload();
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }
    #endregion

    #region Quản lý, tạo bảng phân ca
    protected void btnTaoBangPhanCaThang_Click(object sender, DirectEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(ddfDonVi.Text) || string.IsNullOrEmpty(spfYear.Text))
            {
                X.Msg.Alert("Thông báo", "Tạo bảng phân ca thất bại. Dữ liệu nhập vào không hợp lệ").Show();
                return;
            }
            string str = hdfStringMaDonVi.Text;
            string a = hdfStringAllMaDonVi.Text;
            hdfStringMaDonVi.Text = "";

            DAL.DanhSachBangPhanCa dsbc = new DanhSachBangPhanCa()
            {
                CreatedBy = CurrentUser.ID,
                CreatedDate = DateTime.Now,
                MaDonVi = Session["MaDonVi"].ToString(),
                Nam = int.Parse(spfYear.Text),
                Thang = int.Parse(cbThang.SelectedItem.Value),
                DonViSuDung = str,
                Lock = false,
                TenBangPhanCa = txtTenBangPhanCa.Text,
            };
            int id = new DanhSachBangPhanCaController().Insert(dsbc);
            if (id > 0)
            {
                
                //int isLayTuThangTruoc = -1;
                //if (chkLayTuThangTruoc.Checked == true)
                //    isLayTuThangTruoc = 1;
                //new BangPhanCaThangController().TaoBangPhanCaThang(id, CurrentUser.ID, int.Parse(cbThang.SelectedItem.Value), int.Parse(spfYear.Text), str, isLayTuThangTruoc);
                hdfIDBangPhanCa.Text = id.ToString();
                grpDanhSachBangPhanCaThang.Title = DataController.DataHandler.GetInstance().ExecuteScalar("store_LayTenBangPhanCa", "@ID", id).ToString();
                RM.RegisterClientScriptBlock("reloadgrid", "grpDanhSachBangPhanCaThangStore.reload();");
                wdTaoBangPhanCa.Hide();
            }
            else
            {
                X.MessageBox.Alert("Có lỗi xảy ra", "Không tạo được bảng chấm công tháng").Show();
            }
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Thông báo ", ex.Message).Show();
        }
    }
    protected void cbChonLaiBangPhanCaStore_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        try
        {
            cbChonLaiBangPhanCaStore.DataSource = DataController.DataHandler.GetInstance().ExecuteDataTable("getDanhSachBangPhanCaByMaDV",
                                                                                                            "@MA_DV", "@Nam", Session["MaDonVi"].ToString(),
                                                                                                            spnChonNam.Value);
            cbChonLaiBangPhanCaStore.DataBind();
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }
    #endregion

    #region loadtree ddfDonVi
    private void LoadDonVi()
    {
        List<StoreComboObject> dvList = new DM_DONVIController().GetStoreByParentID(Session["MaDonVi"].ToString());
        Ext.Net.TreeNode root = new Ext.Net.TreeNode();
        foreach (var item in dvList)
        {
            string actionNode = string.Empty;
            Ext.Net.TreeNode node = new Ext.Net.TreeNode(item.TEN);
            node.Icon = Ext.Net.Icon.House;
            root.Nodes.Add(node);
            node.Expanded = true;
            node.NodeID = item.MA;
            node.Checked = ThreeStateBool.False;
            hdfStringAllMaDonVi.Text += item.MA + ",";
            actionNode += LoadChildDepartment(item.MA, node);
            if (actionNode != "")
            {
                node.Listeners.CheckChange.Handler = "TreePanelDonVi.getNodeById('" + actionNode.Remove(actionNode.LastIndexOf(',')).Trim().Replace(",", "').getUI().checkbox.checked = (TreePanelDonVi.getNodeById('" + item.MA + "').getUI().checkbox.checked == true ? true : false);TreePanelDonVi.getNodeById('") + "').getUI().checkbox.checked = (TreePanelDonVi.getNodeById('" + item.MA + "').getUI().checkbox.checked == true ? true : false);";
            }
        }
        TreePanelDonVi.Listeners.CheckChange.Handler = @"#{ddfDonVi}.setValue(getTasks(this), false);
                                                         txtTenBangPhanCa.setValue('Bảng phân ca tháng ' + cbThang.getValue() +' năm '+ spfYear.getValue()+' tại ' + ddfDonVi.getText().replace('[', '').replace(']', ''));";
        TreePanelDonVi.Root.Clear();
        TreePanelDonVi.Root.Add(root);
    }

    private string LoadChildDepartment(string maDonVi, Ext.Net.TreeNode DvNode)
    {
        List<StoreComboObject> childList = new DM_DONVIController().GetStoreByParentID(maDonVi);
        string dsChild = "";
        foreach (var dv in childList)
        {
            string tmp = "";
            Ext.Net.TreeNode node = new Ext.Net.TreeNode(dv.TEN);
            node.Icon = Ext.Net.Icon.Folder;
            DvNode.Nodes.Add(node);
            node.Expanded = true;
            node.NodeID = dv.MA;
            node.Checked = ThreeStateBool.False;
            hdfStringAllMaDonVi.Text += dv.MA + ",";
            tmp += LoadChildDepartment(dv.MA, node);
            if (tmp != "")
            {
                node.Listeners.CheckChange.Handler = "TreePanelDonVi.getNodeById('" + tmp.Remove(tmp.LastIndexOf(',')).Trim().Replace(",", "').getUI().checkbox.checked = (TreePanelDonVi.getNodeById('" + dv.MA + "').getUI().checkbox.checked == true ? true : false);TreePanelDonVi.getNodeById('") + "').getUI().checkbox.checked = (TreePanelDonVi.getNodeById('" + dv.MA + "').getUI().checkbox.checked == true ? true : false);";
            }
            tmp += dv.MA + ",";
            dsChild += tmp;
        }
        return dsChild;
    }
    #endregion

    [DirectMethod]
    public void SaveData(string sql)
    {
        try
        {
            DataHandler.GetInstance().ExecuteNonQuery(sql);
            RM.RegisterClientScriptBlock("clearSQL", "clearSQL();");
            Dialog.ShowNotification("Dữ liệu đã được tự động lưu thành công");
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }

    protected void btnSave_Click(object sender, DirectEventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(e.ExtraParams["sqlQuery"]))
            {
                DataHandler.GetInstance().ExecuteNonQuery(e.ExtraParams["sqlQuery"]);
                RM.RegisterClientScriptBlock("clearSQL", "clearSQL();");
            }
            Dialog.ShowNotification("Cập nhật thành công");
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }

    protected void mnuLoaiBoNhanVien_Click(object sender, DirectEventArgs e)
    {
        try
        {
            BangPhanCaThangController controller = new BangPhanCaThangController();
            foreach (var item in RowSelectionModel1.SelectedRows)
            {
                controller.DeleteEmployee(int.Parse(item.RecordID));
            }
            mnuLoaiBoNhanVien.Disabled = true;
            grpDanhSachBangPhanCaThang.Reload();
        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }

    protected void btnThietLapCaNhanh_Click(object sender, DirectEventArgs e)
    {
        try
        {
            if (rdApplyforSelectedEmployee.Checked == true)
            {
                foreach (var item in RowSelectionModel1.SelectedRows)
                {
                    int fromDay = FromDate.SelectedDate.Day;
                    int toDay = ToDate.SelectedDate.Day;
                    for (int i = fromDay; i < toDay + 1; i++)
                    {
                        string field = "";
                        string value = "";
                        if (i < 10)
                            field = "NGAY0" + i;
                        else field = "NGAY" + i;

                        DateTime date = new DateTime(FromDate.SelectedDate.Year, FromDate.SelectedDate.Month, i);
                        if (chkSaturday.Checked && date.DayOfWeek.ToString() == "Saturday") //Nếu chọn thứ 7
                        {
                            value = MultiComboSaturday.SelectedItem.Value;
                        }
                        else if (chkSunday.Checked && date.DayOfWeek.ToString() == "Sunday") //Nếu chọn CN
                        {
                            value = MultiComboSunday.SelectedItem.Value;
                        }
                        else if (chkSaturday.Checked == false && date.DayOfWeek.ToString() == "Saturday") //Nếu ko chọn thứ 7
                        {
                            value = "";
                        }
                        else if (chkSunday.Checked == false && date.DayOfWeek.ToString() == "Sunday")//Nếu ko chọn CN
                        {
                            value = "";
                        }
                        else
                        {
                            value = cbTinhTrangLamViec.SelectedItem.Value;
                        }

                        new BangPhanCaThangController().Update(int.Parse(item.RecordID), field, value);
                       
                    }
                }
                wdThietLapCaNhanh.Hide();
                 grpDanhSachBangPhanCaThang.Reload();
            }
            else
                if (rdApplyforSelectedDepartment.Checked == true)
                {
                    int fromDay = FromDate.SelectedDate.Day;
                    int toDay = ToDate.SelectedDate.Day;
                    for (int i = fromDay; i < toDay + 1; i++)
                    {
                        string field = "";
                        string value = "";
                        if (i < 10)
                            field = "NGAY0" + i;
                        else field = "NGAY" + i;

                        DateTime date = new DateTime(FromDate.SelectedDate.Year, FromDate.SelectedDate.Month, i);
                        if (chkSaturday.Checked && date.DayOfWeek.ToString() == "Saturday") //Nếu chọn thứ 7
                        {
                            value = MultiComboSaturday.SelectedItem.Value;
                        }
                        else if (chkSunday.Checked && date.DayOfWeek.ToString() == "Sunday") //Nếu chọn CN
                        {
                            value = MultiComboSunday.SelectedItem.Value;
                        }
                        else if (chkSaturday.Checked == false && date.DayOfWeek.ToString() == "Saturday") //Nếu ko chọn thứ 7
                        {
                            value = "";
                        }
                        else if (chkSunday.Checked == false && date.DayOfWeek.ToString() == "Sunday")//Nếu ko chọn CN
                        {
                            value = "";
                        }
                        else
                        {
                            value = cbTinhTrangLamViec.SelectedItem.Value;
                        }
                        new BangPhanCaThangController().UpdateByPhongBan(hdfMaDonVi.Text,int.Parse("0"+hdfIDBangPhanCa.Text),field,value);
                    }
                    grpDanhSachBangPhanCaThang.Reload();
                    wdThietLapCaNhanh.Hide();
                }
                else Dialog.ShowError("Bạn chưa chọn đối tượng phân ca.");

        }
        catch (Exception ex)
        {
            X.MessageBox.Alert("Có lỗi xảy ra", ex.Message).Show();
        }
    }
    [DirectMethod(Namespace = "PhanCaTrongThang")]
    public void AfterEdit(string field, string oldValue, string newValue, int ID)
    {
        try
        {
            new BangPhanCaThangController().Update(ID, field, newValue);
            grpDanhSachBangPhanCaThangStore.CommitChanges();

        }
        catch (Exception ex) { Dialog.ShowError(ex.Message); }
    }
}