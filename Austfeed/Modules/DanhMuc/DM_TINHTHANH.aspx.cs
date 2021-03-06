﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modules_DanhMuc_DM_TINHTHANH : SoftCore.Security.WebBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        grp_dm_tinhthanh.accessHistory = new WebUI.Entity.AccessHistory()
        {
            Delete_AccessHistoryDescription = "Xóa thông tin tỉnh thành",
            ModuleDescription = "Quản lý danh mục tỉnh thành",
            Update_AccessHistoryDescription = "Cập nhật thông tin tỉnh thành",
            Insert_AccessHistoryDescription = "Thêm mới thông tin tỉnh thành"
        };

        
    }
}