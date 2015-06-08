using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SoftCore.Security;
using Ext.Net;
using ExtMessage;
using DAL;
using System.Data;
using System.IO;
using LinqToExcel;

public partial class Modules_TienLuong_BangLuongDong : WebBase
{
    //private int idBangLuong = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Ext.Net.X.IsAjaxRequest)
        {
            if (MenuID != 271 && MenuID != 276)
            {
                btnNhapTienBoSong.Hidden = true;
            }

            LoadRecordField();
            LoadColumnIntoGrid();
            LoadDonVi();

            new DTH.BorderLayout()
            {
                menuID = MenuID,
                script = "#{hdfSelectedDepartment}.setValue('" + DTH.BorderLayout.nodeID + "');#{StaticPagingToolbar}.pageIndex = 0; #{StaticPagingToolbar}.doLoad();"
            }.AddDepartmentList(br, CurrentUser.ID, true);

            cbChonThang.SetValue(DateTime.Now.Month);
            spinChonNam.SetValue(DateTime.Now.Year);
            hdfSessionDepartment.Text = Session["MaDonVi"].ToString();
            hdfMenuID.SetValue(MenuID);
            hdfUserID.SetValue(CurrentUser.ID);
        }
        ucChooseEmployee1.AfterClickAcceptButton += new EventHandler(ucChooseEmployee1_AfterClickAcceptButton);

        // phân quyền chức năng
        SetVisibleByControlID(mnuAddEmployee, mnuDeleteEmployee, btnAdjustment, mnuLayTatCa, mnuLayDuocChon, mnuTinhChoTatCa, mnuCalculateSelected,
            btnKhoaBangLuong, btnMoKhoaBangLuong, btnThemBangTinhLuong, btnSuaBangTinhLuong, btnXoaBangTinhLuong, btnNhapTienBoSong, btnEditOnGrid);
    }

    #region Load đơn vị
    private void LoadDonVi()
    {
        List<DM_DONVI> dvList = new UserController().GetDonViByUserID(CurrentUser.ID);
        Ext.Net.TreeNode root = new Ext.Net.TreeNode();
        foreach (DM_DONVI dv in dvList)
        {
            Ext.Net.TreeNode node = new Ext.Net.TreeNode(dv.TEN_DONVI);
            node.Icon = Ext.Net.Icon.House;
            root.Nodes.Add(node);
            node.Expanded = true;
            node.NodeID = dv.MA_DONVI;
            node.Checked = ThreeStateBool.False;
            LoadChildDepartment(dv.MA_DONVI, node);
            //node.Listeners.Click.Handler = "txtTenBangTinhLuong.setValue('Bảng tính lương tháng '+cbChonThang.getValue()+' năm '+spinChonNam.getValue() + ' tại bộ phận ' + Field3.getValue());";
        }

        TreePanel1.Root.Clear();
        TreePanel1.Root.Add(root);
    }

    private void LoadChildDepartment(string maDonVi, Ext.Net.TreeNode DvNode)
    {
        List<DM_DONVI> childList = new DM_DONVIController().GetByParentID(maDonVi);
        foreach (DM_DONVI dv in childList)
        {
            Ext.Net.TreeNode node = new Ext.Net.TreeNode(dv.TEN_DONVI);
            node.Icon = Ext.Net.Icon.Folder;
            DvNode.Nodes.Add(node);
            node.Expanded = true;
            node.NodeID = dv.MA_DONVI;
            node.Checked = ThreeStateBool.False;
            //node.Listeners.Click.Handler = "txtTenBangTinhLuong.setValue('Bảng tính lương tháng '+cbChonThang.getValue()+' năm '+spinChonNam.getValue() + ' tại bộ phận ' + Field3.getValue());";
            LoadChildDepartment(dv.MA_DONVI, node);
        }
    }
    #endregion

    #region Cấu hình bảng lương động
    private void LoadColumnIntoGrid()
    {
        // create HeaderRow
        Ext.Net.HeaderRow row = new HeaderRow();
        int i = 0;
        foreach (var item in new SalaryBoardConfigController().GetSalaryColumnList(MenuID))
        {
            // set editor
            Ext.Net.TextField txtEditor = new TextField();
            txtEditor.MaskRe = "/[0-9.-]/";
            txtEditor.ID = "txtEditor" + i;
            item.Editor.Add(txtEditor);

            grpSalaryBoard.ColumnModel.Columns.Add(item);

            #region Tạo GroupHeader
            // create HeaderColumn
            Ext.Net.HeaderColumn column = new HeaderColumn();
            column.AutoWidthElement = false;
            // tạo DisplayField để hiển thị
            Ext.Net.DisplayField dpf = new DisplayField();
            dpf.ID = "dpf" + item.ColumnID;
            dpf.Text = "";
            // add DisplayField to ColumnHeader
            column.Component.Add(dpf);
            row.Columns.Add(column);
            #endregion

            i++;
        }
        lkv.HeaderRows.Add(row);
    }

    private void LoadRecordField()
    {
        //RecordField r = new RecordField() { Name = "C1" };
        //stSalaryBoard.AddField(r);
        foreach (var item in new SalaryBoardConfigController().GetSalaryColumnList(MenuID))
        {
            RecordField r = new RecordField() { Name = item.ColumnID };
            stSalaryBoard.AddField(r);
        }
    }

    private void SetEditor()
    {
        if (hdfIsLocked.Text == "true")
            SetEditable(false);
        else
            SetEditable(true);
    }

    private void SetEditable(bool value)
    {
        //int number = new SalaryBoardConfigController().GetSalaryColumnList(MenuID).Count;
        //for (int i = 2; i < number; i++)
        //{
        //    grpSalaryBoard.ColumnModel.Columns[i].Editable = value;
        //}
        int j = 0;
        foreach (var item in new SalaryBoardConfigController().GetSalaryColumnList(MenuID))
        {
            if (btnEditOnGrid.Visible)
            {
                if (value == true)
                {
                    if (item.Editable == true)
                        grpSalaryBoard.ColumnModel.SetEditable(4 + j, value);
                }
                else
                {
                    grpSalaryBoard.ColumnModel.SetEditable(4 + j, value);
                }
            }
            else
            {
                grpSalaryBoard.ColumnModel.SetEditable(4 + j, false);
            }
            j++;
        }
    }
    #endregion

    #region Quản lý bảng lương
    /// <summary>
    /// Thêm mới một bảng lương
    /// @daibx
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnDongYThemBangTinhClick(object sender, DirectEventArgs e)
    {
        try
        {
            DanhSachBangLuongController controller = new DanhSachBangLuongController();
            int thang = int.Parse(cbChonThang.SelectedItem.Value);
            int nam = int.Parse(spinChonNam.Text);
            if (e.ExtraParams["Edit"] != "True")//thêm bảng tính
            {
                if (controller.CheckTrungThangNam(hdfMaDonVi.Text, thang, nam, MenuID))
                {
                    X.Msg.Alert("Thông báo", "Đã tồn tại bảng tính lương cho bộ phận " + Field3.Text + " trong tháng " + thang.ToString() + " năm " + nam.ToString() + "").Show();
                    return;
                }
                DAL.DanhSachBangLuong bang = new DAL.DanhSachBangLuong()
                {
                    CreatedBy = CurrentUser.ID,
                    CreatedDate = DateTime.Now,
                    MA_DONVI = hdfMaDonVi.Text,
                    SessionDepartment = Session["MaDonVi"].ToString(),
                    Month = thang,
                    Year = nam,
                    Title = txtTenBangTinhLuong.Text,
                    Description = txtDescription.Text,
                    MenuID = MenuID
                };
                controller.Insert(bang);
                hdfIDBangLuong.SetValue(bang.ID);
                if (!string.IsNullOrEmpty(hdfMaDonVi.Text))
                    DataController.DataHandler.GetInstance().ExecuteNonQuery("CreateBangLuong", "@IdBangLuong", "@MaDonVi", bang.ID, hdfMaDonVi.Text);
                Dialog.ShowNotification("Thông báo", "Thêm mới bảng lương thành công");
            }
            else //sửa bảng tính
            {
                DAL.DanhSachBangLuong bang = controller.GetByID(int.Parse("0" + hdfIDBangLuong.Text));
                bang.Title = txtTenBangTinhLuong.Text;
                bang.Month = thang;
                bang.Year = nam;
                bang.Description = txtDescription.Text;
                controller.Update(bang);
                Dialog.ShowNotification("Thông báo", "Câp nhật thông tin bảng lương thành công");
            }
            wdThemBangTinhLuong.Hide();
            grpDanhSachBangTinhLuong.Reload();
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    /// <summary>
    /// Sửa thông tin bảng lương
    /// @daibx
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSuaBangTinhLuong_Click(object sender, DirectEventArgs e)
    {
        try
        {
            DAL.DanhSachBangLuong dsach = new DanhSachBangLuongController().GetByID(int.Parse("0" + hdfIDBangLuong.Text));
            if (dsach != null)
            {
                cbChonThang.SetValue(dsach.Month);
                spinChonNam.SetValue(dsach.Year);
                txtTenBangTinhLuong.Text = dsach.Title;
                txtDescription.Text = dsach.Description;

                wdThemBangTinhLuong.Show();
            }
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    /// <summary>
    /// Xóa bảng lương khỏi danh sách (chỉ xóa các bảng lương chưa khóa)
    /// @daibx
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnXoaBangTinhLuongClick(object sender, DirectEventArgs e)
    {
        try
        {
            bool isLock = new DanhSachBangLuongController().Delete(int.Parse("0" + hdfIDBangLuong.Text));
            if (isLock == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không có quyền xóa");
            }
            hdfIDBangLuong.Text = "0";
            grpDanhSachBangTinhLuong.Reload();
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    /// <summary>
    /// Chọn bảng lương
    /// @daibx
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnChonBangTinhLuongClick(object sender, DirectEventArgs e)
    {
        try
        {
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(int.Parse("0" + hdfIDBangLuong.Text));
            int idBangLuong = bangLuong.ID;
            grpSalaryBoard.Title = bangLuong.Title;
            wdQuanLyBangTinhLuong.Hide();
            //Response.Redirect(Request.RawUrl);
            ReloadGrid();
        }
        catch (Exception)
        {
            Dialog.ShowError("Không tìm thấy bảng lương");
        }
    }
    #endregion

    #region Thêm, xóa cán bộ khỏi bảng lương
    void ucChooseEmployee1_AfterClickAcceptButton(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);
            if (bangLuong.DaKhoa == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không được phép thao tác");
                return;
            }
            int count = 0;
            string ma = "", errStr = string.Empty;
            // lấy danh sách các mã cán bộ được chọn
            SelectedRowCollection selectedRows = ucChooseEmployee1.SelectedRow;
            foreach (var item in selectedRows)
            {
                try
                {
                    bool isSuccess = bool.Parse(DataController.DataHandler.GetInstance().ExecuteScalar("InsertEmployeeToSalaryBoard", "@IDBangLuong", "@MaCanBo",
                        idBangLuong, item.RecordID).ToString());
                    if (isSuccess == false)
                    {
                        ma += item.RecordID + ", ";
                        count++;
                    }
                }
                catch (Exception)
                {
                    count++;
                }
            }
            if (count == 0)
                Dialog.ShowNotification("Thêm mới cán bộ thành công");
            else
            {
                errStr += "Không thêm được " + count + " cán bộ.";
                if (ma != "")
                {
                    ma = ma.Remove(ma.LastIndexOf(','));
                    errStr += " Các cán bộ có mã " + ma + " đã tồn tại";
                }
                X.Msg.Alert("Thông báo từ hệ thống", errStr).Show();
            }
            grpSalaryBoard.Reload();
        }
        catch (Exception ex)
        {
            X.Msg.Alert("Thông báo từ hệ thống", "Có lỗi xảy ra: " + ex.Message).Show();
        }
    }

    protected void mnuXoaNhanVien_Click(object sender, DirectEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);
            if (bangLuong.DaKhoa == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không được phép thao tác");
                return;
            }
            SelectedRowCollection selectedRows = RowSelectionModelSalaryBoard.SelectedRows;
            string error = string.Empty;
            foreach (var item in selectedRows)
            {
                try
                {
                    DataController.DataHandler.GetInstance().ExecuteDataTable("TienLuong_DeleteEmployee", "@ID", item.RecordID);
                }
                catch (Exception ex)
                {
                    error += ex.Message + "<br />";
                }
            }
            if (!string.IsNullOrEmpty(error))
            {
                X.Msg.Alert("Thông báo từ hệ thống", error).Show();
            }
            grpSalaryBoard.Reload();
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }
    #endregion

    #region Đọc lương khoán từ file excel
    private void UploadFile()
    {
        try
        {
            //upload file 
            HttpPostedFile file = FileUploadField1.PostedFile;

            //if (file.ContentType != "application/vnd.ms-excel") //ko phải Excel 2003
            //{
            //    Dialog.ShowError(GlobalResourceManager.GetInstance().GetErrorMessageValue("NotExcel2003"));
            //    return;
            //}
            if (FileUploadField1.HasFile == false && file.ContentLength > 2000000)
            {
                Dialog.ShowNotification("File không được lớn hơn 200kb");
                return;
            }
            else
            {
                string path = string.Empty;
                try
                {
                    DirectoryInfo dir = new DirectoryInfo(Server.MapPath("File"));
                    if (dir.Exists == false)
                        dir.Create();
                    path = Server.MapPath("File/") + FileUploadField1.FileName;
                    file.SaveAs(path);
                }
                catch (Exception ex)
                {
                    Dialog.ShowError(ex.Message);
                }
            }
        }
        catch (Exception ex)
        {
            Dialog.ShowNotification(ex.Message);
        }
    }

    /// <summary>
    /// Tải tệp tin excel mẫu lương khoán
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void DownloadBangChamCongMau(object sender, DirectEventArgs e)
    {
        try
        {
            string fileName = Server.MapPath("SampleFile/MauExcelTienBoSung.xlsx");
            System.IO.FileInfo file = new System.IO.FileInfo(fileName);

            if (file.Exists)
            {
                Response.Clear();
                Response.AddHeader("content-disposition", "attachment; filename=" + "MauExcelTienBoSung.xlsx");
                Response.AddHeader("Content-Length", file.Length.ToString());
                //Response.ContentType = "application/vnd.ms-excel";
                Response.WriteFile(file.FullName);
                Response.End();
            }
            else
            {
                X.Msg.Alert("Thông báo", "File mẫu không tồn tại").Show();
            }
        }
        catch (Exception ex)
        {
            X.Msg.Alert("Thông báo", ex.Message.ToString()).Show();
        }
    }

    protected void cbSheetNameStore_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        try
        {
            UploadFile();
            string path = Server.MapPath("File/") + FileUploadField1.FileName;
            FileInfo info = new FileInfo(path);
            if (info.Exists)
            {
                List<object> sheetData = new List<object>();
                IEnumerable<string> sheetname = ExcelEngine.GetInstance().GetAllSheetName(path);
                foreach (var item in sheetname)
                {
                    sheetData.Add(new { SheetName = item });
                }
                cbSheetNameStore.DataSource = sheetData;
                cbSheetNameStore.DataBind();
            }
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    protected void ImportDataFromExcel(object sender, DirectEventArgs e)
    {
        string saveLocation = string.Empty;
        FileInfo file;
        try
        {
            string extension = System.IO.Path.GetExtension(FileUploadField1.PostedFile.FileName).ToLower();
            //TinhLuongKhoanController controller = new TinhLuongKhoanController();
            if (!extension.Equals(".xls") && !extension.Equals(".xlsx"))
            {
                X.Msg.Alert("Thông báo", "File bạn chọn không phải excel").Show();
                return;
            }
            string fn = System.IO.Path.GetFileName(FileUploadField1.PostedFile.FileName);
            saveLocation = Server.MapPath("File") + "\\" + fn;

            List<Row> dataExcel = ExcelEngine.GetInstance().GetDataFromExcel(saveLocation, cbSheetName.SelectedItem.Value, 0);
            int count = 0;
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse(hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong dsbl = new DanhSachBangLuongController().GetByID(idBangLuong);
            if (dsbl == null)
            {
                Dialog.ShowError("Không tìm thấy bảng lương");
                return;
            }

            #region cấu hình vị trí cột
            int manvindex = 1, thuongcvindex = 4, tienhotroindex = 5, tienbuindex = 6, lan1tienmatindex = 7,
                lan1chuyenkhoanindex = 8, trutienindex = 9, baolanhindex = 10, tamungindex = 11, thamnienindex = 12,
                tienanindex = 13, congdoanindex = 14, bhxhindex = 15, bhytindex = 16, bhtnindex = 17, x1index = 18, x2index = 19, x3index = 20, x4index = 21, x5index = 22, x6index = 23, x7index = 24, x8index = 25;
            #endregion

            foreach (Row item in dataExcel)
            {
                string macb = "";
                try
                {
                    double thuongcv = 0, tienhotro = 0, tienbu = 0, lan1chuyenkhoan = 0, lan1tienmat = 0, trutien = 0, baolanh = 0, tamung = 0,
                        thamnien = 0, tienan = 0, congdoan = 0, bhxh = 0, bhyt = 0, bhtn = 0, x1 = 0, x2 = 0, x3 = 0, x4 = 0, x5 = 0, x6 = 0, x7 = 0, x8 = 0 ;
                    if (count > 20)
                        break;
                    if (string.IsNullOrEmpty(item[manvindex]))
                    {
                        count++;
                    }
                    else
                    {
                        // dữ liệu thang
                        try { macb = item[manvindex].ToString(); }
                        catch (Exception ex) { }
                        try { thuongcv = double.Parse(item[thuongcvindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { tienhotro = double.Parse(item[tienhotroindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { tienbu = double.Parse(item[tienbuindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { lan1chuyenkhoan = double.Parse(item[lan1chuyenkhoanindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { lan1tienmat = double.Parse(item[lan1tienmatindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { trutien = double.Parse(item[trutienindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { baolanh = double.Parse(item[baolanhindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { tamung = double.Parse(item[tamungindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { thamnien = double.Parse(item[thamnienindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { tienan = double.Parse(item[tienanindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { congdoan = double.Parse(item[congdoanindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { bhxh = double.Parse(item[bhxhindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { bhyt = double.Parse(item[bhytindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { bhtn = double.Parse(item[bhtnindex].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }

                        try { x1 = double.Parse(item[x1index].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { x2 = double.Parse(item[x2index].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { x3 = double.Parse(item[x3index].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { x4 = double.Parse(item[x4index].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { x5 = double.Parse(item[x5index].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { x6 = double.Parse(item[x6index].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { x7 = double.Parse(item[x7index].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        try { x8 = double.Parse(item[x8index].ToString().Replace(".", ",")); }
                        catch (Exception ex) { }
                        // cập nhật vào csdl
                        DataController.DataHandler.GetInstance().ExecuteNonQuery("TienLuong_UpdateTienBoSungVanPhong",
                                "@IdBangLuong", "@MenuID", "@MaCanBo", "@ThuongCV", "@TienHoTro", "@TienBu", "@Lan1TienMat", 
                                "@Lan1ChuyenKhoan", "@TruTien", "@BaoLanh", "@TamUng", "@ThamNien", "@TienAn", "@CongDoan",
                                "@BHXH", "@BHYT", "@BHTN", "@x1", "@x2", "@x3", "@x4", "@x5", "@x6", "@x7", "@x8",
                                idBangLuong, MenuID, macb, thuongcv, tienhotro, tienbu, lan1tienmat, lan1chuyenkhoan, trutien, baolanh, 
                                tamung, thamnien, tienan, congdoan, bhxh, bhyt, bhtn,x1,x2,x3,x4,x5,x6,x7,x8);
                    }
                }
                catch (Exception ex)
                {

                }
            }

            file = new FileInfo(saveLocation);
            if (file.Exists)
                file.Delete();
            Dialog.ShowNotification("Nhập dữ liệu thành công");
            grpSalaryBoard.Reload();
            wdNhapTuExcel.Hide();
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
            file = new FileInfo(saveLocation);
            if (file.Exists)
                file.Delete();
        }
    }
    #endregion

    #region Điều chỉnh bảng lương
    protected void btnAcceptAdjustment_Click(object sender, DirectEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);
            if (bangLuong.DaKhoa == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không được phép thao tác");
                return;
            }
            // áp dụng cho các cán bộ được chọn
            if (chkApplySelectedEmployee.Checked)
            {
                SelectedRowCollection selecteds = RowSelectionModelSalaryBoard.SelectedRows;
                foreach (var item in selecteds)
                {
                    DataController.DataHandler.GetInstance().ExecuteNonQuery("TienLuong_AdjustmentValueSelected", "@ID", "@ColumnName", "@Value",
                            int.Parse(item.RecordID), cbxSelectColumn.SelectedItem.Value, float.Parse(txtValueAdjustment.Text.Replace('.', ',')));
                }
            }
            // áp dụng cho toàn bộ cán bộ
            else if (chkApplyForAll.Checked)
            {
                DataController.DataHandler.GetInstance().ExecuteNonQuery("TienLuong_AdjustmentValueForAll", "@IDBangLuong", "@ColumnName", "@Value",
                        idBangLuong, cbxSelectColumn.SelectedItem.Value, float.Parse(txtValueAdjustment.Text.Replace('.', ',')));
            }
            grpSalaryBoard.Reload();
            wdDieuChinh.Hide();
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    [DirectMethod]
    public void AfterEdit(int id, string field, string oldValue, string newValue, object customer)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);
            if (bangLuong.DaKhoa == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không được phép thao tác");
                stSalaryBoard.CommitChanges();
                grpSalaryBoard.Reload();
                return;
            }
            float value = 0;
            try
            {
                value = float.Parse(newValue.Replace('.', ','));
            }
            catch (Exception) { value = 0; }
            new BangLuongDongController().UpdateBangThanhToanLuong(id, field, value, idBangLuong);
            stSalaryBoard.CommitChanges();
            //try
            //{
            //    new BangLuongDongController().CalculateSalaryForAnEmployee(idBangLuong, id + "");
            //}
            //catch (Exception)
            //{

            //}
            //LoadTongLuong();
            //grpSalaryBoard.Reload();
        }
        catch (Exception ex)
        {
            Dialog.ShowNotification("Có lỗi xảy ra: " + ex.Message);
        }
    }
    #endregion

    #region Lấy dữ liệu
    /// <summary>
    /// Lấy dữ liệu cho tất cả cán bộ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void mnuGetDataForAll_Click(object sender, DirectEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);
            if (bangLuong.DaKhoa == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không được phép thao tác");
                return;
            }
            DataController.DataHandler.GetInstance().ExecuteNonQuery("TienLuong_CapNhatThamSoCong", "@SalaryBoardID", "@selectedID", idBangLuong, "");
            grpSalaryBoard.Reload();
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    /// <summary>
    /// Lấy dữ liệu cho các nhân viên được chọn
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void mnuGetDataForSelectedEmployee_Click(object sender, DirectEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);
            if (bangLuong.DaKhoa == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không được phép thao tác");
                return;
            }
            SelectedRowCollection selecteds = RowSelectionModelSalaryBoard.SelectedRows;
            string selectedID = string.Empty;
            foreach (var item in selecteds)
            {
                selectedID += item.RecordID + ",";
            }
            DataController.DataHandler.GetInstance().ExecuteNonQuery("TienLuong_CapNhatThamSoCong", "@SalaryBoardID", "@selectedID", idBangLuong, selectedID);
            grpSalaryBoard.Reload();
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }
    #endregion

    #region Tính lương
    protected void btnCalculateSalary_Click(object sender, DirectEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);
            if (bangLuong.DaKhoa == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không được phép thao tác");
                return;
            }
            new BangLuongDongController().CalculateSalaryBoard(idBangLuong);
            LoadTongLuong();
            grpSalaryBoard.Reload();
            Dialog.ShowNotification("Hoàn thành tính lương");
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    protected void mnuCalculateSelected_Click(object sender, DirectEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);
            if (bangLuong.DaKhoa == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không được phép thao tác");
                return;
            }
            SelectedRowCollection selecteds = RowSelectionModelSalaryBoard.SelectedRows;
            string dsIdBangLuongDong = string.Empty;
            foreach (var item in selecteds)
            {
                dsIdBangLuongDong += item.RecordID + ",";
            }
            int pos = dsIdBangLuongDong.LastIndexOf(',');
            if (pos != -1)
                dsIdBangLuongDong = dsIdBangLuongDong.Remove(pos);
            new BangLuongDongController().CalculateSalaryForAnEmployee(idBangLuong, dsIdBangLuongDong);
            LoadTongLuong();
            grpSalaryBoard.Reload();
            Dialog.ShowNotification("Tính lương xong cho nhân viên được chọn");
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    [DirectMethod]
    public void LoadTongLuong()
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                //Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            //DataTable table = DataController.DataHandler.GetInstance().ExecuteDataTable("TienLuong_TinhTongLuongGroupHeader", "@MaDonVi", "@IDBangLuong", "@seachKey",
            //    "", idBangLuong, txtSearch.Text);
            List<SalaryBoardConfigInfo> lists = new SalaryBoardConfigController().GetSalaryBoardConfig(MenuID);
            string sqlString = string.Empty;
            foreach (var it in lists)
            {
                if (it.AllowSum == true)
                {
                    sqlString += "SUM(ISNULL(bld." + it.ColumnName + ", 0)) AS '" + it.ColumnName + "',";
                }
            }
            int pos = sqlString.LastIndexOf(',');
            if (pos != -1)
                sqlString = sqlString.Remove(pos);
            if (string.IsNullOrEmpty(sqlString) || sqlString == "")
            {
                return;
            }
            sqlString = "SELECT " + sqlString + string.Format(@"FROM   (
                                      SELECT hs.PR_KEY,
                                             hs.MA_CB,
                                             hs.TEN_CB,
                                             hs.HO_TEN,
                                             hs.MA_DONVI
                                      FROM   HOSO hs
                                  ) AS hs
                                  LEFT JOIN TienLuong.BangLuongDong bld
                                       ON  hs.PR_KEY = bld.PrKeyHoSo
                           WHERE  (
                                      LEN('" + txtSearch.Text + @"') = 0
                                      OR hs.MA_CB LIKE N'%' + '" + txtSearch.Text + @"' + '%'
                                      OR hs.HO_TEN LIKE N'%' + '" + txtSearch.Text + @"' + '%'
                           )
                           AND (LEN('') = 0 OR  hs.MA_DONVI in (select MA_DONVI from f_GetDanhSachMaDonVi('')))
                           AND " + idBangLuong + @"=bld.IDBangLuong
                           GROUP BY bld.IDBangLuong");
            DataTable table = DataController.DataHandler.GetInstance().ExecuteDataTable(sqlString);

            if (table.Rows.Count > 0)
            {
                DataRow record = table.Rows[0];
                string javascript = string.Empty;
                foreach (var item in lists)
                {
                    if (item.AllowSum == true)
                    {
                        javascript += "dpf" + item.ColumnName + ".setValue(RenderVNDGroupHeader(" + record[item.ColumnName] + "));";
                    }
                }
                RM.RegisterClientScriptBlock("SetSum", javascript);
            }
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }
    #endregion

    #region Khóa/Mở khóa bảng lương
    protected void btnKhoaBangLuongClick(object sender, DirectEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);

            if (bangLuong.DaKhoa == true)
            {
                Dialog.ShowError("Bảng lương đã khóa. Bạn không được phép thao tác");
                return;
            }
            if (idBangLuong == 0)
            {
                X.Msg.Alert("Thông báo từ hệ thống", "Không tìm thấy bảng tổng hợp lương").Show();
                return;
            }
            new DanhSachBangLuongController().LockBangLuong(idBangLuong, true);
            //Response.Redirect(Request.RawUrl);
            ReloadGrid();
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }

    protected void btnMoBangLuongClick(object sender, DirectEventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(hdfIDBangLuong.Text))
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương");
                return;
            }
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            if (idBangLuong == 0)
            {
                X.Msg.Alert("Thông báo từ hệ thống", "Không tìm thấy bảng tổng hợp lương").Show();
                return;
            }
            new DanhSachBangLuongController().LockBangLuong(idBangLuong, false);
            //Response.Redirect(Request.RawUrl);
            ReloadGrid();
        }
        catch (Exception ex)
        {
            X.Msg.Alert("Thông báo từ hệ thống", "Có lỗi xảy ra: " + ex.Message).Show();
        }
    }
    #endregion

    #region Load ComboBox
    protected void cbxSelectColumnStore_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        List<object> objs = new List<object>();
        foreach (var item in new SalaryBoardConfigController().GetSalaryColumnList(MenuID))
        {
            objs.Add(new { ColumnName = item.ColumnID, ColumnDescription = item.Header });
        }
        cbxSelectColumnStore.DataSource = objs;
        cbxSelectColumnStore.DataBind();
    }
    #endregion

    private void ReloadGrid()
    {
        try
        {
            // xử lý chọn bảng lương
            int idBangLuong = int.Parse("0" + hdfIDBangLuong.Text);
            if (idBangLuong != 0)
            {
                try
                {
                    DAL.DanhSachBangLuong bangLuong = new DanhSachBangLuongController().GetByID(idBangLuong);
                    idBangLuong = bangLuong.ID;
                    hdfIDBangLuong.SetValue(idBangLuong);
                    grpSalaryBoard.Title = bangLuong.Title;
                    wdQuanLyBangTinhLuong.Hide();
                    if (bangLuong.DaKhoa == true)
                    {
                        if (btnEmployee.Visible)
                            btnEmployee.Disabled = true;
                        if (btnNhapTienBoSong.Visible)
                            btnNhapTienBoSong.Disabled = true;
                        if (btnAdjustment.Visible)
                            btnAdjustment.Disabled = true;
                        if (btnCalculateSalary.Visible)
                            btnCalculateSalary.Disabled = true;
                        if (btnMoKhoaBangLuong.Visible)
                            btnMoKhoaBangLuong.Show();
                        if (btnKhoaBangLuong.Visible)
                            btnKhoaBangLuong.Hide();
                        hdfIsLocked.Text = "true";
                    }
                    else
                    {
                        if (btnEmployee.Visible)
                            btnEmployee.Disabled = false;
                        if (btnNhapTienBoSong.Visible)
                            btnNhapTienBoSong.Disabled = false;
                        if (btnAdjustment.Visible)
                            btnAdjustment.Disabled = false;
                        if (btnCalculateSalary.Visible)
                            btnCalculateSalary.Disabled = false;
                        if (btnMoKhoaBangLuong.Visible)
                            btnMoKhoaBangLuong.Hide();
                        if (btnKhoaBangLuong.Visible)
                            btnKhoaBangLuong.Show();
                        hdfIsLocked.Text = "false";
                    }
                    SetEditor();
                    grpSalaryBoard.Reload();
                }
                catch (Exception ex)
                {
                    Dialog.ShowError(ex.Message);
                }
            }
        }
        catch (Exception ex)
        {
            Dialog.ShowError(ex.Message);
        }
    }
    protected void btnSendMail_Click(object sender, DirectEventArgs e)
    {
        var data = DataController.DataHandler.GetInstance().ExecuteDataTable("TienLuong_GetBangLuongDong", "@Start", "@Limit", "@SearchKey", "@IdBangLuong", "@MaDonVi", "@UserID", "@MenuID",
            0, 100000, "", int.Parse("0" + hdfIDBangLuong.Text), hdfMaDonVi.Text, int.Parse(hdfUserID.Text), int.Parse(hdfMenuID.Text));
        string body = string.Empty;

        List<HOSO> chuaCoEmail = new List<HOSO>();

        foreach (DataRow item in data.Rows)
        {
            decimal prkNhanVien = decimal.Parse(item["PrKeyHoSo"].ToString());
            int IdBangLuong = int.Parse(item["IdBangLuong"].ToString());
            DanhSachBangLuong bangluong = new DanhSachBangLuongController().GetByID(IdBangLuong);
            HOSO s = new HoSoController().GetByPrKey(prkNhanVien);
            if (string.IsNullOrEmpty(s.EMAIL))
            {
                chuaCoEmail.Add(s);
            }
            HeThongController htc = new HeThongController();

            if (hdfMenuID.Text == "271")
            {
                using (StreamReader reader = new StreamReader(Server.MapPath("~/Modules/TienLuong/File/PhieuLuong.html")))
                {
                    body = reader.ReadToEnd();
                }
                body = body.Replace("{MA_CB}", item["MA_CB"].ToString())//[85] = {MA_CB}
                 .Replace("{TEN_CHUCVU}", item["TEN_CHUCVU"].ToString())
                 .Replace("{FullName}", item["HO_TEN"].ToString())//[86] = {HO_TEN}
                 .Replace("{LuongCoBan}", item["C1"].ToString())//[30] = C28
                 .Replace("{CongDiLam}", item["C5"].ToString())//[39] = {C37}
                 .Replace("{LuongTrongThang}", item["C6"].ToString())//C2
                 .Replace("{TienLamThem}", item["C13"].ToString())//C26
                 .Replace("{NgayPhep}", item["C14"].ToString())//C3
                 .Replace("{TienPhep}", item["C15"].ToString())//C4
                 .Replace("{TienThuongCV}", item["C16"].ToString())//C5
                 .Replace("{Luong130}", item["C49"].ToString())//C6
                 .Replace("{Luong150}", item["C50"].ToString())//C7
                 .Replace("{Luong195}", item["C51"].ToString())//C8
                 .Replace("{Luong200}", item["C52"].ToString())//C9
                 .Replace("{Luong260}", item["C53"].ToString())//C10
                 .Replace("{Luong300}", item["C54"].ToString())//C11
                 .Replace("{PhuCapThamNien}", item["C26"].ToString())//C12
                 .Replace("{TongPhuCap}", item["C23"].ToString())//C13
                 .Replace("{LuongKhoanChenhLech}", item["C24"].ToString())//C14
                 .Replace("{ThuNhapChiuThue}", item["ThuNhapChiuThue"].ToString())//C15
                 .Replace("{TienTamUng}", item["C42"].ToString())//C16
                 .Replace("{TongThuNhap}", item["C29"].ToString())//C17
                 .Replace("{TongGiamTru}", item["C45"].ToString())//C18
                 .Replace("{TongLuongThucNhan}", item["C46"].ToString())//C19
                 .Replace("{TienBaoLanh}", item["C40"].ToString())//C21
                 .Replace("{TienCongDoan}", item["C32"].ToString())//C23
                 .Replace("{BHXH}", item["C33"].ToString())//C24
                 .Replace("{BHYT}", item["C34"].ToString())//C25
                 .Replace("{BHTN}", item["C35"].ToString())//ThuNhapChiuThue            
                 .Replace("{TienHoTro}", item["C27"].ToString())
                 .Replace("{TienBu}", item["C28"].ToString())
                 .Replace("{GiamGiaCanh}", item["C32"].ToString())
                 .Replace("{ThueTNCN}", item["ThueTNCN"].ToString())
                 .Replace("{TruTien}", item["C41"].ToString())
                 .Replace("{Lan1TM}", item["C43"].ToString())
                 .Replace("{Month}", bangluong.Month.ToString());
            }
            else if (hdfMenuID.Text == "276")
            {
                using (StreamReader reader = new StreamReader(Server.MapPath("~/Modules/TienLuong/File/PhieuLuongKD.html")))
                {
                    body = reader.ReadToEnd();
                }
                body = body.Replace("{MA_CB}", item["MA_CB"].ToString())//[85] = {MA_CB}
                 .Replace("{FullName}", item["HO_TEN"].ToString())//[86] = {HO_TEN}
                 .Replace("{TEN_CHUCVU}", item["TEN_CHUCVU"].ToString())
                 .Replace("{LuongCoBan}", item["C1"].ToString())//[30] = C28
                 .Replace("{CongDiLam}", item["C4"].ToString())//[39] = {C37}
                 .Replace("{LuongTrongThang}", item["C6"].ToString())//C2
                 .Replace("{NgayPhep}", item["C14"].ToString())//C3
                 .Replace("{TienPhep}", item["C15"].ToString())//C4
                 .Replace("{TienThuongCV}", item["C16"].ToString())//C5
                 .Replace("{PCTienAn}", item["C9"].ToString())//C6
                 .Replace("{PCDT}", item["C10"].ToString())//C7
                 .Replace("{PCNhaO}", item["C11"].ToString())//C8
                 .Replace("{ThuongSPCL}", item["C12"].ToString())//C9
                 .Replace("{ThuongSPKK}", item["C13"].ToString())//C10
                 .Replace("{ThuongTarget}", item["C14"].ToString())//C11
                 .Replace("{PhatTarget}", item["C15"].ToString())//C9
                 .Replace("{ThuongTT}", item["C16"].ToString())//C10
                 .Replace("{PhatTT}", item["C17"].ToString())//C11
                 .Replace("{ThuongTTQ}", item["C18"].ToString())//C9
                 .Replace("{PhatTTQ}", item["C19"].ToString())//C10
                 .Replace("{ThuongDL}", item["C20"].ToString())//C11
                 .Replace("{ThuongCV}", item["C57"].ToString())//C11
                 .Replace("{TongPhuCap}", item["C29"].ToString())//C13
                 .Replace("{ThuNhapChiuThue}", item["ThuNhapChiuThue"].ToString())//C15
                 .Replace("{TienTamUng}", item["C42"].ToString())//C16
                 .Replace("{TongThuNhap}", item["C29"].ToString())//C17
                 .Replace("{TongGiamTru}", item["C45"].ToString())//C18
                 .Replace("{TongLuongThucNhan}", item["C46"].ToString())//C19
                 .Replace("{TienBaoLanh}", item["C40"].ToString())//C21
                 .Replace("{TienCongDoan}", item["C32"].ToString())//C23
                 .Replace("{BHXH}", item["C33"].ToString())//C24
                 .Replace("{BHYT}", item["C34"].ToString())//C25
                 .Replace("{BHTN}", item["C35"].ToString())//ThuNhapChiuThue            
                 .Replace("{TienHoTro}", item["C30"].ToString())
                 .Replace("{TienBu}", item["C31"].ToString())
                 .Replace("{GiamGiaCanh}", item["GiamTruThue"].ToString())
                 .Replace("{ThueTNCN}", item["ThueTNCN"].ToString())
                 .Replace("{TruTien}", item["C42"].ToString())
                 .Replace("{Lan1TM}", item["C44"].ToString())
                 .Replace("{Month}", bangluong.Month.ToString());
            }

            string mailFrom = htc.GetValueByName(SystemConfigParameter.EMAIL, Session["MaDonVi"].ToString());
            string psw = htc.GetValueByName(SystemConfigParameter.PASSWORD_EMAIL, Session["MaDonVi"].ToString());
            SendMail.SendMail("smtp.gmail.com", 587,
                mailFrom,
                "".Split(';', ','),
                "".Split(';', ','),
                "".Split(','),
                psw,
                CurrentUser.DisplayName,
                string.IsNullOrEmpty(s.EMAIL) ? mailFrom : s.EMAIL,
                String.Format("Phiếu lương {0} tháng {1}, năm {2}", item["HO_TEN"].ToString(),
                bangluong.Month,
                bangluong.Year),
                body);
        }
    }
}