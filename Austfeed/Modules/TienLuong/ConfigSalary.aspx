<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ConfigSalary.aspx.cs" Inherits="Modules_TienLuong_ConfigSalary" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script type="text/javascript">
        var afterEdit = function (e) {
            if (e.record.data.ID == null) {
                //SalaryBoardConfigX.Insert(e.record.data.MenuID, e.field, e.originalValue, e.value, e.record.data);
            }
            else {
                SalaryBoardConfigX.AfterEdit(e.record.data.ID, e.record.data.MenuID, e.field, e.originalValue, e.value, e.record.data);
            }
        };
        var Render = function (value, p, record) {
            if (value == 'RenderVND')
                return "Kiểu tiền tệ";
            if (value == 'RenderNumber')
                return "Kiểu số";
            else return value;
        }
        var RenderComboboxDataSource = function (value, p, record) {
            switch (value) {
                case 'f_Cong_LayNgayCongTrongThang':
                    return 'Số ngày công chuẩn'
                    break;
                case 'f_Cong_LayNgayCongThuongTheoMA_CBVaThangNam':
                    return 'Ngày công thực tế'
                    break;
                case 'f_Luong_LaySoLuongCungTheoPrKeyHoSo':
                    return 'Lương cứng'
                    break;
                case 'f_ChamCong_LaySoNgayNghiPhepTheoMA_CBVaThangNam':
                    return 'Số ngày phép'
                    break;
                case 'f_Cong_LaySoNgayLe':
                    return 'Số ngày lễ';
                    break;
                case 'f_Luong_LayHeSoLuongTheoLoaiHopDong':
                    return 'Hệ số lương theo loại hợp đồng'
                case 'f_Luong_LaySoLuongDongBaoHiemTheoPrKeyHoSo':
                    return 'Lương đóng bảo hiểm';
                case 'f_HoSo_LaySoNguoiChiuThueTheoPrKey':
                    return 'Số người chịu thuế(Số người phụ thuộc)';
                case 'f_Cong_LayCong130TheoMA_CBVaThangNam':
                    return 'Công 130%';
                case 'f_Cong_LayCong150TheoMA_CBVaThangNam':
                    return 'Công 150%';
                case 'f_Cong_LayCong195TheoMA_CBVaThangNam':
                    return 'Công 195%';
                case 'f_Cong_LayCong200TheoMA_CBVaThangNam':
                    return 'Công 200%';
                case 'f_Cong_LayCong260TheoMA_CBVaThangNam':
                    return 'Công 260%';
                case 'f_Cong_LayCong300TheoMA_CBVaThangNam':
                    return 'Công 300%';
                case 'CalculateThamNien':
                    return 'Thâm niêm';
                case 'f_TongHopCongComTheoMaCBVaThangNam':
                    return 'Tổng hợp công cơm';
                case 'f_GetSoTienDongBHTN_By_PRKEYHOSO_Month':
                    return 'Tiền BHTN';
                case 'f_GetSoTienDongBHXH_By_PRKEYHOSO_Month':
                    return 'Tiền BHXH';
                case 'f_GetSoTienDongBHYT_By_PRKEYHOSO_Month':
                    return 'Tiền BHYT';
                case 'f_GetPhuCap_TrachNhiem':
                    return 'Phụ cấp trách nhiệm';
                case 'f_GetPhuCap_ThuHut':
                    return 'Phụ cấp thu hút';
                case 'f_GetPhuCap_NangNhoc':
                    return 'Phụ cấp nặng nhọc';
                case 'f_GetPhuCap_KiemNhiem':
                    return 'Phụ cấp kiêm nhiệm';
                case 'f_GetPhuCap_DienThoai':
                    return 'Phụ cấp điện thoại';
                case 'f_GetPhuCap_DiLai':
                    return 'Phụ cấp đi lại';
                case 'f_GetTongCongLuongKhoan':
                    return 'Tổng lương khoán sản xuất';
                case 'f_LaySoThangThuTienBaoLanh':
                    return 'Số tháng thu tiền bảo lãnh';
                case 'f_GetPhuCap_TienAn':
                    return 'Phụ cấp tiền ăn';
                case 'f_GetPhuCap_NhaO':
                    return '(SL)Phụ cấp nhà ở';
                case 'f_PhuCapTrachNhiem':
                    return '(SL)Phụ cấp trách nhiệm';
                case 'f_ThuongSPChienLuoc':
                    return '(SL)Thưởng SP chiến lược';
                case 'f_ThuongSPKhuyenKhich':
                    return '(SL)Thưởng SP khuyến khích';
                case 'f_ThuongTarget':
                    return '(SL)Thưởng Target';
                case 'f_PhatTarget':
                    return '(SL)Phạt Target';
                case 'f_ThuongTangTruongThang':
                    return '(SL)Thưởng tăng trưởng tháng';
                case 'f_PhatTangTruongThang':
                    return '(SL)Phạt tăng trưởng tháng';
                case 'f_ThuongTangTruongQuy':
                    return '(SL)Thưởng tăng trưởng quý';
                case 'f_PhatTangTruongQuy':
                    return '(SL)Phạt tăng trưởng quý';
                case 'f_DaiLyMoi':
                    return '(SL)Đại lý mới';
                case 'f_DaiLyDatSanLuong':
                    return '(SL)Đại lý đạt sản lượng';
                case 'f_ThuongPhatChiTieu':
                    return '(Sl)Thưởng/ phạt chỉ tiêu';
                case 'f_KinhDoanh_DienThoai':
                    return '(KD)Phụ cấp điện thoại';
                case 'f_KinhDoanh_TienAn':
                    return '(KD)Phụ cấp tiền ăn';
                case 'f_KinhDoanh_NhaO':
                    return '(KD)Phụ cấp nhà ở';
                case 'f_KinhDoanh_NgayCongThucTe':
                    return '(KD)Ngày công thực tế';
                default:
                    return ''
            }
        }
        var RenderAlign = function (value, p, record) {
            if (value == "Left") {
                return "Trái";
            }
            else if (value == "Right")
                return "Phải";
            else if (value == "Center")
                return "Giữa";
            return value;
        }

        function ResetTreeID() {
            document.getElementById("hdfTreeNodeID").value = "";
        }
        function ClearFormValue() {
            document.getElementById("txtMenuName").value = "";
            document.getElementById("txtTabName").value = "";
            document.getElementById("hdfMenuCommand").value = "";
            document.getElementById("hdfParentID").value = "";
            document.getElementById("hdfOldMenuRole").value = "";
            document.getElementById("txtIcon").value = "";
            document.getElementById("ddfParentMenu").value = "";
        }
    </script>
    <script src="../../Resource/js/RenderJS.js" type="text/javascript"></script>
    <title></title>
    <style type="text/css">
        #grpSalaryConfig .x-grid3-cell-inner
        {
            white-space: nowrap !important;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ext:ResourceManager runat="server" ID="RM" />
        <ext:Hidden runat="server" ID="hdfTreeNodeID" />
        <ext:Store runat="server" ID="ModuleFileStore" AutoLoad="false" OnRefreshData="ModuleFileRefresh">
            <DirectEventConfig>
                <EventMask ShowMask="false" />
            </DirectEventConfig>
            <Reader>
                <ext:JsonReader IDProperty="Path">
                    <Fields>
                        <ext:RecordField Name="Path" Type="String" />
                    </Fields>
                </ext:JsonReader>
            </Reader>
            <Listeners>
                <Load Handler="#{cbFile}.setValue(#{cbFile}.store.getAt(0).get('Path'));" />
            </Listeners>
        </ext:Store>
        <ext:Window ID="wdAddModule" runat="server" Border="false" Padding="0" Icon="Pencil"
            Width="550" Modal="true" Maximizable="false" Resizable="false" AutoHeight="true"
            Title="Thêm mới một bảng lương" Hidden="true">
            <Items>
                <ext:Panel ID="Panel1" runat="server" Frame="true" Padding="6" Border="false" Layout="FormLayout">
                    <Items>
                        <ext:Hidden ID="hdfMenuCommand" runat="server" />
                        <ext:DropDownField ID="ddfParentMenu" FieldLabel="Menu cấp cha" Width="400" runat="server"
                            Editable="false" TriggerIcon="SimpleArrowDown" Hidden="true">
                            <Component>
                                <ext:TreePanel ID="MenuTreePanel" runat="server" Title="<%$ Resources:Language, choose_parent_category%>"
                                    Icon="Accept" Height="300" Shadow="None" UseArrows="true" AutoScroll="true" Animate="true"
                                    EnableDD="true" ContainerScroll="true" RootVisible="false">
                                    <Listeners>
                                        <CheckChange Handler="this.dropDownField.setValue(getText(this),getValues(this), false);" />
                                    </Listeners>
                                </ext:TreePanel>
                            </Component>
                            <Listeners>
                                <Expand Handler="this.component.getRootNode().expand(true);" Single="true" Delay="10" />
                            </Listeners>
                        </ext:DropDownField>
                        <ext:Hidden runat="server" ID="hdfParentID" />
                        <ext:TextField ID="txtMenuName" runat="server" FieldLabel="<%$ Resources:Language, menu_name%>"
                            Width="400" />
                        <ext:TextField ID="txtTabName" runat="server" Width="400" FieldLabel="<%$ Resources:Language, tab_name%>"
                            AllowBlank="false" MsgTarget="Side" Hidden="true" />
                        <ext:ComboBox ID="cbModule" runat="server" Editable="false" Width="400" TypeAhead="true"
                            Mode="Local" FieldLabel="<%$ Resources:Language, choose_module%>" ForceSelection="true"
                            TriggerAction="All" SelectOnFocus="true" EmptyText="<%$ Resources:Language, choose_module%>"
                            Hidden="true">
                            <Listeners>
                                <Select Handler="#{cbFile}.clearValue(); #{ModuleFileStore}.reload();" />
                            </Listeners>
                        </ext:ComboBox>
                        <ext:ComboBox ID="cbFile" StoreID="ModuleFileStore" Editable="false" runat="server"
                            TypeAhead="true" Width="400" Mode="Local" FieldLabel="<%$ Resources:Language, choose_file%>"
                            ForceSelection="true" TriggerAction="All" DisplayField="Path" ValueField="Path"
                            EmptyText="<%$ Resources:Language, choose_file%> aspx..." Hidden="true">
                            <Triggers>
                                <ext:FieldTrigger Icon="Clear" HideTrigger="true" />
                            </Triggers>
                            <Listeners>
                                <Select Handler="this.triggers[0].show();" />
                                <BeforeQuery Handler="this.triggers[0][ this.getRawValue().toString().length == 0 ? 'hide' : 'show']();" />
                                <TriggerClick Handler="if (index == 0) { this.clearValue(); this.triggers[0].hide(); }" />
                            </Listeners>
                        </ext:ComboBox>
                        <ext:DropDownField ID="ddfRole" FieldLabel="<%$ Resources:Language, choose_authorization%>"
                            Width="400" runat="server" Editable="false" TriggerIcon="SimpleArrowDown">
                            <Component>
                                <ext:TreePanel ID="TreePanelRole" runat="server" Title="<%$ Resources:Language, choose_authorization_category%>"
                                    Icon="Accept" Height="250" Shadow="None" UseArrows="true" AutoScroll="true" Animate="true"
                                    EnableDD="true" ContainerScroll="true" RootVisible="false">
                                    <Buttons>
                                        <ext:Button ID="Button5" runat="server" Text="<%$ Resources:Language, close%>">
                                            <Listeners>
                                                <Click Handler="#{ddfRole}.collapse();" />
                                            </Listeners>
                                        </ext:Button>
                                    </Buttons>
                                    <Listeners>
                                        <CheckChange Handler="this.dropDownField.setValue(getRoleTextAndValue(this), false);" />
                                    </Listeners>
                                </ext:TreePanel>
                            </Component>
                            <Listeners>
                                <Expand Handler="this.component.getRootNode().expand(true);SetNodeChecked(#{TreePanelRole});"
                                    Single="true" Delay="10" />
                            </Listeners>
                        </ext:DropDownField>
                        <ext:TextField runat="server" ID="txtMenuLink" FieldLabel="<%$ Resources:Language, link%>"
                            AnchorHorizontal="100%" Hidden="true" />
                        <ext:Hidden ID="hdfOldMenuRole" runat="server" />
                        <ext:Hidden runat="server" ID="hdfRoleID" />
                        <ext:TextField ID="txtIcon" FieldLabel="<%$ Resources:Language, choose_icon%>" runat="server"
                            Hidden="true" />
                        <ext:Checkbox runat="server" FieldLabel="<%$ Resources:Language, choose_is_panel%>"
                            ID="chkIsMenuPanel" Hidden="true" />
                    </Items>
                    <Buttons>
                        <ext:Button runat="server" Text="<%$ Resources:Language, update%>" Icon="Disk" ID="btnUpdateMenu">
                            <DirectEvents>
                                <Click OnEvent="btnUpdateMenu_Click">
                                    <EventMask ShowMask="true" Msg="<%$ Resources:Language, updating%>" />
                                    <ExtraParams>
                                        <ext:Parameter Name="MenuCommand" Mode="Raw" Value="Insert" />
                                    </ExtraParams>
                                </Click>
                            </DirectEvents>
                        </ext:Button>
                        <ext:Button ID="Button3" runat="server" Text="<%$ Resources:Language, close%>" Icon="Decline">
                            <Listeners>
                                <Click Handler="wdAddModule.hide();" />
                            </Listeners>
                        </ext:Button>
                    </Buttons>
                </ext:Panel>
            </Items>
            <Listeners>
                <Hide Handler="ResetTreeID();ClearFormValue();" />
                <Close Handler="ResetTreeID();ClearFormValue();" />
            </Listeners>
        </ext:Window>
        <ext:Viewport runat="server" ID="vp">
            <Items>
                <ext:BorderLayout runat="server" ID="br">
                    <Center>
                        <ext:GridPanel runat="server" ID="grpSalaryConfig" Border="false">
                            <TopBar>
                                <ext:Toolbar runat="server">
                                    <Items>
                                        <ext:Hidden ID="hdfSalaryTable" runat="server" />
                                        <ext:Button runat="server" Text="Tạo mới một bảng lương" Icon="Add" Hidden="true">
                                            <Listeners>
                                                <Click Handler="wdAddModule.show();" />
                                            </Listeners>
                                        </ext:Button>
                                        <ext:ComboBox runat="server" EmptyText="Chọn bảng lương" Width="250" Editable="false"
                                            ID="cbChooseSalaryTable" ValueField="MenuID" DisplayField="MenuName">
                                            <Store>
                                                <ext:Store runat="server" ID="stChooseSalaryTable" AutoLoad="false" OnRefreshData="stChooseSalaryTable_OnRefreshData">
                                                    <Reader>
                                                        <ext:JsonReader IDProperty="MenuID">
                                                            <Fields>
                                                                <ext:RecordField Name="MenuID" />
                                                                <ext:RecordField Name="MenuName" />
                                                            </Fields>
                                                        </ext:JsonReader>
                                                    </Reader>
                                                </ext:Store>
                                            </Store>
                                            <Listeners>
                                                <Expand Handler="if(stChooseSalaryTable.getCount()==0){stChooseSalaryTable.reload();}" />
                                                <Select Handler="hdfSalaryTable.setValue(cbChooseSalaryTable.getValue()); grpSalaryConfig.reload();" />
                                            </Listeners>
                                        </ext:ComboBox>
                                    </Items>
                                </ext:Toolbar>
                            </TopBar>
                            <Store>
                                <ext:Store runat="server" ID="stSalaryConfig" AutoLoad="false" OnRefreshData="stSalaryConfig_OnRefreshData">
                                    <Reader>
                                        <ext:JsonReader IDProperty="ID">
                                            <Fields>
                                                <ext:RecordField Name="ID" />
                                                <ext:RecordField Name="MenuID" />
                                                <ext:RecordField Name="RenderJS" />
                                                <ext:RecordField Name="Order" />
                                                <ext:RecordField Name="Width" />
                                                <ext:RecordField Name="ColumnName" />
                                                <ext:RecordField Name="ColumnDescription" />
                                                <ext:RecordField Name="Formula" />
                                                <ext:RecordField Name="AllowSum" />
                                                <ext:RecordField Name="Align" />
                                                <ext:RecordField Name="DataSourceFunction" />
                                                <ext:RecordField Name="DisplayOnGrid" />
                                                <ext:RecordField Name="WhereClause" />
                                                <ext:RecordField Name="IsInUsed" />
                                                <ext:RecordField Name="AllowEditOnGrid" />
                                                <ext:RecordField Name="DefaultValue" />
                                                <ext:RecordField Name="DisplayOnReport" />
                                            </Fields>
                                        </ext:JsonReader>
                                    </Reader>
                                </ext:Store>
                            </Store>
                            <Listeners>
                                <AfterEdit Fn="afterEdit" />
                            </Listeners>
                            <ColumnModel>
                                <Columns>
                                    <ext:RowNumbererColumn Header="STT" Align="Center" Width="35" Locked="true" />
                                    <ext:Column DataIndex="ColumnName" Width="50" Header="Ký hiệu" Locked="true">
                                        <Editor>
                                            <%--<ext:ComboBox runat="server" ID="cbColumnName" DisplayField="Value" ValueField="ID"
                                                Editable="false">
                                                <Store>
                                                    <ext:Store runat="server" ID="stColumnName" AutoLoad="false" OnRefreshData="stColumnName_OnRefreshData" >
                                                        <Reader>
                                                            <ext:JsonReader IDProperty="ID">
                                                                <Fields>
                                                                    <ext:RecordField Name="ID" />
                                                                    <ext:RecordField Name="Value" />
                                                                </Fields>
                                                            </ext:JsonReader>
                                                        </Reader>
                                                    </ext:Store>
                                                </Store>
                                            </ext:ComboBox>--%>
                                            <%-- <ext:TextField runat="server" ID="txtColumnName" />--%>
                                        </Editor>
                                    </ext:Column>
                                    <ext:Column DataIndex="ColumnDescription" Width="250" Header="Tên diễn giải" Locked="true">
                                        <Editor>
                                            <ext:TextField runat="server" ID="txtDescription" />
                                        </Editor>
                                    </ext:Column>
                                    <ext:Column DataIndex="Order" Width="80" Align="Right" Header="Thứ tự tính toán/hiển thị">
                                        <Editor>
                                            <ext:TextField runat="server" ID="txtOrder" />
                                        </Editor>
                                    </ext:Column>
                                    <ext:Column DataIndex="Formula" Width="250" Header="Công thức">
                                        <Editor>
                                            <ext:TextField runat="server" ID="txtFormula" />
                                        </Editor>
                                    </ext:Column>
                                    <ext:Column DataIndex="Width" Width="60" Header="Dài" Align="Right">
                                        <Editor>
                                            <ext:NumberField runat="server" ID="txtWidth">
                                            </ext:NumberField>
                                        </Editor>
                                        <Renderer Fn="RenderAlign" />
                                    </ext:Column>
                                    <ext:Column DataIndex="RenderJS" Width="120" Header="Render">
                                        <Editor>
                                            <ext:ComboBox runat="server" ID="cbRenderJS">
                                                <Store>
                                                    <ext:Store runat="server" ID="Store5" AutoLoad="false">
                                                        <Reader>
                                                            <ext:JsonReader IDProperty="ID">
                                                                <Fields>
                                                                    <ext:RecordField Name="ID" />
                                                                    <ext:RecordField Name="Value" />
                                                                </Fields>
                                                            </ext:JsonReader>
                                                        </Reader>
                                                    </ext:Store>
                                                </Store>
                                                <Items>
                                                    <ext:ListItem Value="RenderVND" Text="Kiểu tiền tệ" />
                                                    <ext:ListItem Value="RenderNumber" Text="Kiểu số" />
                                                </Items>
                                            </ext:ComboBox>
                                        </Editor>
                                        <Renderer Fn="Render" />
                                    </ext:Column>
                                    <ext:Column DataIndex="AllowSum" Width="80" Header="Tính tổng">
                                        <Editor>
                                            <ext:ComboBox runat="server" ID="cbAllowSum">
                                                <Store>
                                                    <ext:Store runat="server" ID="Store1" AutoLoad="false">
                                                        <Reader>
                                                            <ext:JsonReader IDProperty="ID">
                                                                <Fields>
                                                                    <ext:RecordField Name="ID" />
                                                                    <ext:RecordField Name="Value" />
                                                                </Fields>
                                                            </ext:JsonReader>
                                                        </Reader>
                                                    </ext:Store>
                                                </Store>
                                                <Items>
                                                    <ext:ListItem Value="True" Text="True" />
                                                    <ext:ListItem Value="False" Text="False" />
                                                </Items>
                                            </ext:ComboBox>
                                        </Editor>
                                        <Renderer Fn="GetBooleanIcon" />
                                    </ext:Column>
                                    <ext:Column DataIndex="Align" Width="60" Header="Align">
                                        <Editor>
                                            <ext:ComboBox Editable="false" runat="server" ID="txtAlign">
                                                <Items>
                                                    <ext:ListItem Text="Trái" Value="Left" />
                                                    <ext:ListItem Text="Phải" Value="Right" />
                                                    <ext:ListItem Text="Giữa" Value="Center" />
                                                </Items>
                                            </ext:ComboBox>
                                        </Editor>
                                        <Renderer Fn="RenderAlign" />
                                    </ext:Column>
                                    <ext:Column DataIndex="DataSourceFunction" Width="120" Header="Nguồn dữ liệu">
                                        <Renderer Fn="RenderComboboxDataSource" />
                                        <Editor>
                                            <ext:ComboBox runat="server" ListWidth="200" ID="txtDataSourceTable">
                                                <Triggers>
                                                    <ext:FieldTrigger Icon="Clear" HideTrigger="true" />
                                                </Triggers>
                                                <Items>
                                                    <ext:ListItem Text="Số ngày công chuẩn" Value="f_Cong_LayNgayCongTrongThang" />
                                                    <ext:ListItem Text="Ngày công thực tế" Value="f_Cong_LayNgayCongThuongTheoMA_CBVaThangNam" />
                                                    <ext:ListItem Text="Lương cứng" Value="f_Luong_LaySoLuongCungTheoPrKeyHoSo" />
                                                    <ext:ListItem Text="Số ngày phép" Value="f_ChamCong_LaySoNgayNghiPhepTheoMA_CBVaThangNam" />
                                                    <ext:ListItem Text="Số ngày lễ" Value="f_Cong_LaySoNgayLe" />
                                                    <ext:ListItem Text="Hệ số lương theo loại hợp đồng" Value="f_Luong_LayHeSoLuongTheoLoaiHopDong" />
                                                    <ext:ListItem Text="Lương đóng bảo hiểm" Value="f_Luong_LaySoLuongDongBaoHiemTheoPrKeyHoSo" />
                                                    <ext:ListItem Text="Số người chịu thuế(Số người phụ thuộc)" Value="f_HoSo_LaySoNguoiChiuThueTheoPrKey" />
                                                    <ext:ListItem Text="Công 130%" Value="f_Cong_LayCong130TheoMA_CBVaThangNam" />
                                                    <ext:ListItem Text="Công 150%" Value="f_Cong_LayCong150TheoMA_CBVaThangNam" />
                                                    <ext:ListItem Text="Công 195%" Value="f_Cong_LayCong195TheoMA_CBVaThangNam" />
                                                    <ext:ListItem Text="Công 200%" Value="f_Cong_LayCong200TheoMA_CBVaThangNam" />
                                                    <ext:ListItem Text="Công 260%" Value="f_Cong_LayCong260TheoMA_CBVaThangNam" />
                                                    <ext:ListItem Text="Công 300%" Value="f_Cong_LayCong300TheoMA_CBVaThangNam" />
                                                    <ext:ListItem Text="Thâm niên" Value="CalculateThamNien" />
                                                    <ext:ListItem Text="Phụ cấp trách nhiệm" Value="f_GetPhuCap_TrachNhiem" />
                                                    <ext:ListItem Text="Phụ cấp thu hút" Value="f_GetPhuCap_ThuHut" />
                                                    <ext:ListItem Text="Phụ cấp nặng nhọc" Value="f_GetPhuCap_NangNhoc" />
                                                    <ext:ListItem Text="Phụ cấp kiêm nhiệm" Value="f_GetPhuCap_KiemNhiem" />
                                                    <ext:ListItem Text="Phụ cấp điện thoại" Value="f_GetPhuCap_DienThoai" />
                                                    <ext:ListItem Text="Phụ cấp đi lại" Value="f_GetPhuCap_DiLai" />
                                                    <ext:ListItem Text="(SL)Phụ cấp nhà ở" Value="f_GetPhuCap_NhaO" />
                                                    <ext:ListItem Text="Phụ cấp tiền ăn" Value="f_GetPhuCap_TienAn" />
                                                    <ext:ListItem Text="(SL)Phụ cấp trách nhiệm" Value="f_PhuCapTrachNhiem" />
                                                    <ext:ListItem Text="Tổng lương khoán sản xuất" Value="f_GetTongCongLuongKhoan" />

                                                    <ext:ListItem Text="Tiền bảo hiểm thất nghiệp" Value="f_GetSoTienDongBHTN_By_PRKEYHOSO_Month" />
                                                    <ext:ListItem Text="Tiền bảo hiểm xã hội" Value="f_GetSoTienDongBHXH_By_PRKEYHOSO_Month" />
                                                    <ext:ListItem Text="Tiền bảo hiểm y tế" Value="f_GetSoTienDongBHYT_By_PRKEYHOSO_Month" />
                                                    <ext:ListItem Text="Số tháng thu tiền bảo lãnh" Value="f_LaySoThangThuTienBaoLanh" />
                                                    
                                                    <ext:ListItem Text="(SL)Thưởng SP chiến lược" Value="f_ThuongSPChienLuoc" />
                                                    <ext:ListItem Text="(SL)Thưởng SP khuyến khích" Value="f_ThuongSPKhuyenKhich" />
                                                    <ext:ListItem Text="(SL)Thưởng Target" Value="f_ThuongTarget" />
                                                    <ext:ListItem Text="(SL)Phạt Target" Value="f_PhatTarget" />
                                                    <ext:ListItem Text="(SL)Thưởng tăng trưởng tháng" Value="f_ThuongTangTruongThang" />
                                                    <ext:ListItem Text="(SL)Phạt tăng trưởng tháng" Value="f_PhatTangTruongThang" />
                                                    <ext:ListItem Text="(SL)Thưởng tăng trưởng quý" Value="f_ThuongTangTruongQuy" />
                                                    <ext:ListItem Text="(SL)Phạt tăng trưởng quý" Value="f_PhatTangTruongQuy" />
                                                    <ext:ListItem Text="(SL)Đại lý mới" Value="f_DaiLyMoi" />
                                                    <ext:ListItem Text="(SL)Đại lý đạt sản lượng" Value="f_DaiLyDatSanLuong" />
                                                    <ext:ListItem Text="(Sl)Thưởng/ phạt chỉ tiêu" Value="f_ThuongPhatChiTieu" />

                                                    <ext:ListItem Text="(KD)Phụ cấp điện thoại" Value="f_KinhDoanh_DienThoai" />
                                                    <ext:ListItem Text="(KD)Phụ cấp tiền ăn" Value="f_KinhDoanh_TienAn" />
                                                     <ext:ListItem Text="(KD)Phụ cấp nhà ở" Value="f_KinhDoanh_NhaO" />
                                                     <ext:ListItem Text="(KD)Ngày công thực tế" Value="f_KinhDoanh_NgayCongThucTe" />
                                                </Items>
                                                <Listeners>
                                                    <Select Handler="this.triggers[0].show();" />
                                                    <TriggerClick Handler="if (index == 0) { this.clearValue(); this.triggers[0].hide(); }" />
                                                </Listeners>
                                            </ext:ComboBox>
                                        </Editor>
                                    </ext:Column>
                                    <ext:Column DataIndex="WhereClause" Width="80" Header="Điều kiện tính lương">
                                        <Editor>
                                            <ext:TextField runat="server" ID="txtWhereClause" />
                                        </Editor>
                                    </ext:Column>
                                    <ext:Column DataIndex="DefaultValue" Width="100" Header="Giá trị mặc định">
                                        <Editor>
                                            <ext:TextField runat="server" ID="txtDefaultValue" />
                                        </Editor>
                                    </ext:Column>
                                    <ext:Column DataIndex="DisplayOnGrid" Width="80" Header="Hiển thị trên bảng lương">
                                        <Editor>
                                            <ext:ComboBox runat="server" ID="cbDisplayOnGrid">
                                                <Store>
                                                    <ext:Store runat="server" ID="Store3" AutoLoad="false">
                                                        <Reader>
                                                            <ext:JsonReader IDProperty="ID">
                                                                <Fields>
                                                                    <ext:RecordField Name="ID" />
                                                                    <ext:RecordField Name="Value" />
                                                                </Fields>
                                                            </ext:JsonReader>
                                                        </Reader>
                                                    </ext:Store>
                                                </Store>
                                                <Items>
                                                    <ext:ListItem Value="True" Text="True" />
                                                    <ext:ListItem Value="False" Text="False" />
                                                </Items>
                                            </ext:ComboBox>
                                        </Editor>
                                        <Renderer Fn="GetBooleanIcon" />
                                    </ext:Column>
                                    <ext:Column DataIndex="IsInUsed" Width="80" Header="Đang sử dụng">
                                        <Editor>
                                            <ext:ComboBox runat="server" ID="cbIsInUsed">
                                                <Store>
                                                    <ext:Store runat="server" ID="Store4" AutoLoad="false">
                                                        <Reader>
                                                            <ext:JsonReader IDProperty="ID">
                                                                <Fields>
                                                                    <ext:RecordField Name="ID" />
                                                                    <ext:RecordField Name="Value" />
                                                                </Fields>
                                                            </ext:JsonReader>
                                                        </Reader>
                                                    </ext:Store>
                                                </Store>
                                                <Items>
                                                    <ext:ListItem Value="True" Text="True" />
                                                    <ext:ListItem Value="False" Text="False" />
                                                </Items>
                                            </ext:ComboBox>
                                        </Editor>
                                        <Renderer Fn="GetBooleanIcon" />
                                    </ext:Column>
                                    <ext:Column DataIndex="AllowEditOnGrid" Width="90" Header="Cho phép sửa trên grid">
                                        <Editor>
                                            <ext:ComboBox runat="server" ID="cbAllowEditOnGrid">
                                                <Store>
                                                    <ext:Store runat="server" ID="Store2" AutoLoad="false">
                                                        <Reader>
                                                            <ext:JsonReader IDProperty="ID">
                                                                <Fields>
                                                                    <ext:RecordField Name="ID" />
                                                                    <ext:RecordField Name="Value" />
                                                                </Fields>
                                                            </ext:JsonReader>
                                                        </Reader>
                                                    </ext:Store>
                                                </Store>
                                                <Items>
                                                    <ext:ListItem Value="True" Text="True" />
                                                    <ext:ListItem Value="False" Text="False" />
                                                </Items>
                                            </ext:ComboBox>
                                        </Editor>
                                        <Renderer Fn="GetBooleanIcon" />
                                    </ext:Column>
                                    <ext:Column DataIndex="DisplayOnReport" Width="80" Header="Hiển thị trên báo cáo">
                                        <Editor>
                                            <ext:ComboBox runat="server" ID="cbDisplayOnReport">
                                                <Store>
                                                    <ext:Store runat="server" ID="Store6" AutoLoad="false">
                                                        <Reader>
                                                            <ext:JsonReader IDProperty="ID">
                                                                <Fields>
                                                                    <ext:RecordField Name="ID" />
                                                                    <ext:RecordField Name="Value" />
                                                                </Fields>
                                                            </ext:JsonReader>
                                                        </Reader>
                                                    </ext:Store>
                                                </Store>
                                                <Items>
                                                    <ext:ListItem Value="True" Text="True" />
                                                    <ext:ListItem Value="False" Text="False" />
                                                </Items>
                                            </ext:ComboBox>
                                        </Editor>
                                        <Renderer Fn="GetBooleanIcon" />
                                    </ext:Column>
                                </Columns>
                            </ColumnModel>
                            <View>
                                <ext:LockingGridView runat="server" ID="LockingGridView1" LockText="Cố định cột này lại"
                                    UnlockText="Hủy cố định cột" />
                            </View>
                            <LoadMask ShowMask="true" />
                            <SelectionModel>
                                <ext:RowSelectionModel ID="RowSelectionModel1" runat="server">
                                </ext:RowSelectionModel>
                            </SelectionModel>
                            <BottomBar>
                                <ext:PagingToolbar ID="StaticPagingToolbar" IDMode="Static" EmptyMsg="Hiện không có dữ liệu"
                                    NextText="Trang sau" PageSize="50" PrevText="Trang trước" LastText="Trang cuối cùng"
                                    FirstText="Trang đầu tiên" DisplayMsg="Dòng {0} đến dòng {1} / {2} dòng" runat="server">
                                    <Items>
                                        <ext:Label ID="Label1" runat="server" Text="Số bản ghi trên 1 trang:" />
                                        <ext:ToolbarSpacer ID="ToolbarSpacer1" runat="server" Width="10" />
                                        <ext:ComboBox ID="ComboBoxPaging" SelectedIndex="0" Editable="false" runat="server"
                                            Width="80">
                                            <Items>
                                                <ext:ListItem Text="50" />
                                                <ext:ListItem Text="100" />
                                            </Items>
                                            <Listeners>
                                                <Select Handler="#{StaticPagingToolbar}.pageSize = parseInt(this.getValue()); #{StaticPagingToolbar}.doLoad();" />
                                            </Listeners>
                                        </ext:ComboBox>
                                    </Items>
                                </ext:PagingToolbar>
                            </BottomBar>
                        </ext:GridPanel>
                    </Center>
                </ext:BorderLayout>
            </Items>
        </ext:Viewport>
    </div>
    </form>
</body>
</html>
