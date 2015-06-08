﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Modules_DanhMuc_DM_NOICAP_CMND : SoftCore.Security.WebBase
{
    protected void Page_Load(object sender, EventArgs e)
    {
        grp_dm_noicap_cmnd.accessHistory = new WebUI.Entity.AccessHistory()
        {
            Delete_AccessHistoryDescription = "Xóa thông tin nơi cấp chứng minh nhân dân",
            ModuleDescription = "Quản lý danh mục nơi cấp chứng minh nhân dân",
            Update_AccessHistoryDescription = "Cập nhật thông tin nơi cấp chứng minh nhân dân",
            Insert_AccessHistoryDescription = "Thêm mới thông tin nơi cấp chứng minh nhân dân"
        };

    }
}