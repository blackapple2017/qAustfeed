using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Ext.Net;
using ExtMessage;
using SoftCore.Security;
using SoftCore.Menu;
using SoftCore;

public partial class Modules_TienLuong_ConfigSalary : WebBase
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void stSalaryConfig_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        try
        {
            if (hdfSalaryTable.Text != "")
            {
                stSalaryConfig.DataSource = DataController.DataHandler.GetInstance().ExecuteDataTable("sp_GetSalaryBoardConfigByMenuID", "@MenuID", int.Parse(hdfSalaryTable.Text));
            }
            else
            {
                Dialog.ShowError("Bạn chưa chọn bảng lương nào");
            }
        }
        catch (Exception ex)
        {
            Dialog.ShowError("Lỗi xảy ra " + ex.Message);
        }
    }
    protected void stChooseSalaryTable_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        try
        {
            stChooseSalaryTable.DataSource = DataController.DataHandler.GetInstance().ExecuteDataTable("sp_GetSalaryTableForCombobox");
            stChooseSalaryTable.DataBind();
        }
        catch (Exception ex)
        {
            Dialog.ShowError("Lỗi xảy ra " + ex.Message);
        }
    }
    protected void stColumnName_OnRefreshData(object sender, StoreRefreshDataEventArgs e)
    {
        try
        {
            //stColumnName.DataSource = DataController.DataHandler.GetInstance().ExecuteDataTable("");
            //stColumnName.DataBind();
        }
        catch (Exception ex)
        {
            Dialog.ShowError("Lỗi xảy ra " + ex.Message);
        }
    }
    [DirectMethod(Namespace = "SalaryBoardConfigX")]
    public void AfterEdit(int id, int prkey, string field, string oldValue, string newValue, SalaryBoardConfigInfo oj)
    {
        try
        {
            if (newValue == "" && oj.DataSourceFunction == "")
            {
                if (oj.ColumnName == "Formula" || oj.ColumnName == "DataSourceFunction")
                    newValue = "";
                else
                    newValue = "0";
            }
            SalaryBoardConfigController sdc = new SalaryBoardConfigController();
            sdc.Update(id, prkey, field, newValue);
            this.grpSalaryConfig.Store.Primary.CommitChanges();
            if (field == "IsInUsed")
            {
                string colName = oj.ColumnName;
                int menuID = int.Parse(hdfSalaryTable.Text);
                int v = bool.Parse(newValue) == true ? 1 : 0;

                if (v == 0)
                {
                    try
                    {
                        string sql = "UPDATE TienLuong.BangLuongDong SET " + colName + " = " + v +
                                        " WHERE IdBangLuong IN (SELECT dsbl.ID FROM TienLuong.DanhSachBangLuong dsbl WHERE dsbl.MenuID = " + menuID + ")";
                        DataController.DataHandler.GetInstance().ExecuteNonQuery(sql);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }
        catch (Exception ex) { Dialog.ShowError(ex.Message); }
    }

    [DirectMethod(Namespace = "SalaryBoardConfigX")]
    public void Insert(int prkey, string field, string oldValue, string newValue, object oj)
    {

        this.grpSalaryConfig.Store.Primary.CommitChanges();
    }


    protected void btnUpdateMenu_Click(object sender, DirectEventArgs e)
    {
        if (e.ExtraParams["MenuCommand"].Equals("Insert"))
        {
            InsertMenu();
        }
        else
        {
            UpdateMenu();
        }
        wdAddModule.Hide();
    }
    /// <summary>
    /// Thêm mới menu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void InsertMenu()
    {
        MenuInfo menuInfo = new MenuInfo()
        {
            MenuName = txtMenuName.Text,
            IsDeleted = false,
            Order = 1,
            ParentID = int.Parse(hdfParentID.Text),
            TabName = txtTabName.Text,
            CreatedBy = CurrentUser.ID,
            EdittedBy = CurrentUser.ID,
            Icon = txtIcon.Text,
            IsPanel = chkIsMenuPanel.Checked,
            LinkUrl = "Modules/TienLuong/BangLuongDong.aspx"
        };
        //if (!string.IsNullOrEmpty(cbFile.SelectedItem.Value))
        //{
        //    string LinkUrl = cbFile.SelectedItem.Value.Replace("\\", "/");
        //    menuInfo.LinkUrl = LinkUrl.Substring(LinkUrl.IndexOf("Modules/"));
        //}
        //else
        //    menuInfo.LinkUrl = txtMenuLink.Text;

        int menuID = MenuController.GetInstance().InsertMenu(menuInfo);
        if (menuID > 0)
        {
            string[] roleID = hdfRoleID.Text.Split(',');
            foreach (string item in roleID)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    MenuController.GetInstance().AddRole(menuID, int.Parse(item), UsersController.GetInstance().GetCurrentUser().ID, false);
                }
            }
            Dialog.ShowNotification(GlobalResourceManager.GetInstance().GetLanguageValue("add_menu_successful"));
        }
        else
        {
            Dialog.ShowError(GlobalResourceManager.GetInstance().GetLanguageValue("error"));
        }
    }
    private void UpdateMenu()
    {
        MenuInfo menuInfo = MenuController.GetInstance().GetMenu(int.Parse(hdfTreeNodeID.Text));
        menuInfo.MenuName = txtMenuName.Text;
        menuInfo.TabName = txtTabName.Text;
        menuInfo.ParentID = int.Parse(hdfParentID.Text);
        menuInfo.Icon = txtIcon.Text;
        if (!string.IsNullOrEmpty(cbFile.SelectedItem.Value))
        {
            string LinkUrl = cbFile.SelectedItem.Value.Replace("\\", "/");
            menuInfo.LinkUrl = LinkUrl.Substring(LinkUrl.IndexOf("Modules/"));
        }
        menuInfo.EdittedBy = UsersController.GetInstance().GetCurrentUser().ID;
        menuInfo.EdittedDate = DateTime.Now;
        menuInfo.IsPanel = chkIsMenuPanel.Checked;
        bool updateStatus = MenuController.GetInstance().UpdateMenu(menuInfo);
        if (updateStatus)//update role cho menu
        {
            string[] roleID = hdfRoleID.Text.Split(',');
            foreach (string item in roleID)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    MenuController.GetInstance().AddRole(menuInfo, int.Parse(item), UsersController.GetInstance().GetCurrentUser().ID, false);
                }
            }
        }
    }
    //Lấy các file của Module
    protected void ModuleFileRefresh(object sender, StoreRefreshDataEventArgs e)
    {
        List<object> data = new List<object>();
        List<string> FileList = ModuleController.GetInstance().GetFileInModule(Server.MapPath("Modules") + "\\" + cbModule.SelectedItem.Value);
        foreach (string item in FileList)
        {
            data.Add(new { Path = item });
        }
        this.ModuleFileStore.DataSource = data;
        this.ModuleFileStore.DataBind();
    }
}