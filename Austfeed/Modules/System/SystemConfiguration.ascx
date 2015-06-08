﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="SystemConfiguration.ascx.cs"
    Inherits="Modules_System_SystemConfiguration" %>
<script src="../../Resource/js/jquery-1.4.2.min.js" type="text/javascript"></script>
<script src="../../Resource/js/jquery.ui.core.min.js" type="text/javascript"></script>
<script src="../../Resource/js/jquery.ui.widget.min.js" type="text/javascript"></script>
<script src="../../Resource/js/jquery.ui.mouse.min.js" type="text/javascript"></script>
<script src="../../Resource/js/jquery.ui.sortable.min.js" type="text/javascript"></script>
<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<script type="text/javascript">
    var ValidateForm = function (email, password, confirmPassword, txtSoLuong) {

        if (confirmPassword.getValue().trim() != password.getValue().trim()) {
            alert('Xác nhận mật khẩu không hợp lệ');
            confirmPassword.focus();
            return false;
        }
        if (txtSoLuong.getValue() * 1 > 15) {
            alert('Số lượng chữ số không được vượt quá 15');
            txtSoLuong.focus();
            return false;
        }
        return true;
    }
    var GenerateDecisionNumber = function (idTextField) {
        var dnb = 'Mẫu: 001/';
        var currDate = new Date();
        dnb += currDate.getFullYear() + '/' + idTextField.getValue();
        idTextField.setNote(dnb);
    }
</script>
<style type="text/css">
    #SystemConfiguration1_tab_system_config .x-tab-panel-body {
        background-color: #DFE8F6 !important;
    }

    #SystemConfiguration1_Ctn6 {
        border-bottom: 1px solid #99BBE8 !important;
        padding-bottom: 10px !important;
    }
</style>
<ext:Window runat="server" Width="500" ID="wdWindow" Layout="FormLayout" Title="Thiết lập các thông số cấu hình hệ thống"
    Constrain="true" Icon="Cog" Modal="true" Hidden="true" Resizable="false" AutoHeight="true">
    <Items>
        <ext:TabPanel Border="false" runat="server" Cls="bkGround" ID="tab_system_config"
            Height="450">
            <Items>
                <ext:Panel runat="server" ID="pnlGeneralInformation" Title="Thông tin chung" AnchorHorizontal="100%"
                    AutoHeight="true" Border="false" Layout="FormLayout" Padding="6">
                    <Items>
                        <ext:FieldSet runat="server" ID="fs50" AnchorHorizontal="100%" Title="Thông tin đơn vị"
                            Layout="FormLayout" LabelWidth="90">
                            <Items>
                                <ext:TextField ID="txtCompanyName" AnchorHorizontal="100%" FieldLabel="Đơn vị sử dụng"
                                    runat="server">
                                </ext:TextField>
                                <ext:TextField runat="server" ID="txt_DiaChi" AnchorHorizontal="100%" FieldLabel="Địa chỉ">
                                </ext:TextField>
                                <ext:TextField ID="txtCity" Note="Yêu cầu nhập đầy đủ thông tin, ví dụ: Thành phố Hà Nội"
                                    NoteAlign="Top" AnchorHorizontal="100%" FieldLabel="Thành phố" runat="server">
                                </ext:TextField>
                                <ext:Container runat="server" ID="ctn40" AnchorHorizontal="100%" Layout="ColumnLayout"
                                    Height="50">
                                    <Items>
                                        <ext:Container runat="server" ID="ctn41" ColumnWidth=".5" Layout="FormLayout" LabelWidth="90">
                                            <Items>
                                                <ext:TextField runat="server" ID="txt_MaSoThue" AnchorHorizontal="98%" FieldLabel="Mã số thuế"
                                                    MaxLength="50">
                                                </ext:TextField>
                                                <ext:TextField runat="server" ID="txt_Fax" AnchorHorizontal="98%" FieldLabel="Fax"
                                                    MaxLength="50">
                                                </ext:TextField>
                                            </Items>
                                        </ext:Container>
                                        <ext:Container runat="server" ID="ctn42" ColumnWidth=".5" Layout="FormLayout" LabelWidth="70">
                                            <Items>
                                                <ext:TextField runat="server" ID="txt_DienThoai" AnchorHorizontal="100%" FieldLabel="Điện thoại"
                                                    MaskRe="[0-9]" MaxLength="20">
                                                </ext:TextField>
                                                <ext:TextField runat="server" ID="txt_Email" AnchorHorizontal="100%" FieldLabel="Email"
                                                    MaxLength="100">
                                                </ext:TextField>
                                            </Items>
                                        </ext:Container>
                                    </Items>
                                </ext:Container>
                            </Items>
                        </ext:FieldSet>
                        <ext:FieldSet ID="FieldSet1" runat="server" AnchorHorizontal="100%" AutoHeight="true"
                            Title="Email hệ thống" >
                            <Items>
                                <ext:TextField runat="server" FieldLabel="Địa chỉ" EmptyText="Nhập địa chỉ gmail"
                                    Regex="^[_a-z0-9-]+(\.[_a-z0-9-]+)*@gmail.com$" RegexText="Hệ thống chỉ chấp nhận định dạng gmail"
                                    ID="txtSystemMail" AnchorHorizontal="100%">
                                </ext:TextField>
                                <ext:Container Layout="ColumnLayout" runat="server" Height="30" AnchorHorizontal="100%">
                                    <Items>
                                        <ext:Container ColumnWidth="0.5" runat="server" ID="c1" Height="30" Layout="FormLayout">
                                            <Items>
                                                <ext:TextField runat="server" ID="txtPassword" InputType="Password" FieldLabel="Mật khẩu mail"
                                                    AnchorHorizontal="98%">
                                                </ext:TextField>
                                            </Items>
                                        </ext:Container> 
                                        <ext:TextField ID="txtConfirmPassword" ColumnWidth="0.5" runat="server" InputType="Password" FieldLabel="Xác nhận lại" />
                                    </Items>
                                </ext:Container>
                            </Items>
                        </ext:FieldSet>
                        <ext:ComboBox runat="server" AnchorHorizontal="100%" FieldLabel="Kiểu menu" Editable="false"
                            ID="cbMenuType" SelectedIndex="0">
                            <Items>
                                <ext:ListItem Text="Menu Dọc (Mở rộng)" Value="Vertical" />
                                <ext:ListItem Text="Menu Dọc (Thu nhỏ)" Value="VerticalCollapsed" />
                                <ext:ListItem Text="Menu Ngang" Value="Horizontal" />
                            </Items>
                        </ext:ComboBox>
                        <%--<ext:NumberField runat="server" ID="txtNotification" FieldLabel="Báo hết hạn hợp đồng"
                            AnchorHorizontal="100%" MinValue="0" MaxValue="31">
                        </ext:NumberField>--%>
                    </Items>
                </ext:Panel>
                <ext:Panel runat="server" ID="pnlDecisionNumber" Title="Sinh mã, số quyết định" AnchorHorizontal="100%"
                    AutoHeight="true" Border="false" Layout="FormLayout" Padding="6">
                    <Items>
                        <ext:FieldSet ID="FieldSet2" runat="server" AnchorHorizontal="100%" Title="Cấu hình định dạng mã cán bộ"
                            Layout="FormLayout">
                            <Items>
                                <ext:TextField runat="server" ID="txtTienTo" FieldLabel="Tiền tố mã CB" AnchorHorizontal="100%"
                                    EmptyText="Nhập tiền tố của mã cán bộ" MaxLength="5" />
                                <ext:TextField runat="server" ID="txtSoLuong" FieldLabel="Số lượng chữ số" AnchorHorizontal="100%"
                                    EmptyText="Nhập số lượng chữ số sau tiền tố trong mã cán bộ" MaskRe="/[0-9]/"
                                    MaxLength="1" />
                            </Items>
                        </ext:FieldSet>
                        <ext:FieldSet ID="FieldSet3" runat="server" AnchorHorizontal="100%" Title="Cấu hình sinh số quyết định"
                            Layout="FormLayout">
                            <Items>
                                <ext:Container runat="server" ID="Ctn6" Layout="FormLayout" AnchorHorizontal="100%">
                                    <Items>
                                        <ext:Container runat="server" ID="Ctn4" Layout="FitLayout" AnchorHorizontal="100%"
                                            Height="20">
                                            <Items>
                                                <ext:DisplayField ID="dp1" runat="server" Text="Định dạng số quyết định: Số thứ tự/năm/<span style='color:blue;'>kí hiệu quyết định</span>. Ví dụ: 001/2013/QĐ-KT">
                                                </ext:DisplayField>
                                            </Items>
                                        </ext:Container>
                                        <ext:Container runat="server" ID="Ctn5" Layout="FitLayout" AnchorHorizontal="100%"
                                            Height="20">
                                            <Items>
                                                <ext:DisplayField ID="dp2" runat="server" Text="Việc cấu hình chỉ áp dụng cho phần <span style='color:blue;'>kí hiệu quyết định</span>">
                                                </ext:DisplayField>
                                            </Items>
                                        </ext:Container>
                                    </Items>
                                </ext:Container>
                                <ext:Container runat="server" ID="Ctn3" Layout="ColumnLayout" AnchorHorizontal="100%"
                                    Height="200">
                                    <Items>
                                        <ext:Container runat="server" ID="Ctn1" ColumnWidth="0.52" Layout="FormLayout" LabelAlign="Top">
                                            <Items>
                                                <ext:TextField runat="server" ID="txtSoHopDong" AnchorHorizontal="93%" FieldLabel="Số hợp đồng"
                                                    MaxLength="10" Note="Mẫu: 001/2013/" NoteAlign="Down" EnableKeyEvents="true">
                                                    <Listeners>
                                                        <KeyUp Handler="GenerateDecisionNumber(#{txtSoHopDong});" />
                                                    </Listeners>
                                                </ext:TextField>
                                                <ext:TextField runat="server" ID="txtSoQDKhenThuong" AnchorHorizontal="93%" FieldLabel="Số quyết định khen thưởng"
                                                    MaxLength="10" Note="Mẫu: 001/2013/" NoteAlign="Down" EnableKeyEvents="true">
                                                    <Listeners>
                                                        <KeyUp Handler="GenerateDecisionNumber(#{txtSoQDKhenThuong});" />
                                                    </Listeners>
                                                </ext:TextField>
                                                <ext:TextField runat="server" ID="txtSoQDCongTac" AnchorHorizontal="93%" FieldLabel="Số quyết định công tác"
                                                    MaxLength="10" Note="Mẫu: 001/2013/" NoteAlign="Down" EnableKeyEvents="true">
                                                    <Listeners>
                                                        <KeyUp Handler="GenerateDecisionNumber(#{txtSoQDCongTac});" />
                                                    </Listeners>
                                                </ext:TextField>
                                            </Items>
                                        </ext:Container>
                                        <ext:Container runat="server" ID="Ctn2" ColumnWidth="0.48" Layout="FormLayout" LabelAlign="Top">
                                            <Items>
                                                <ext:TextField runat="server" ID="txtSoQuyetDinhLuong" AnchorHorizontal="100%" FieldLabel="Số quyết định lương"
                                                    MaxLength="10" Note="Mẫu: 001/2013/" NoteAlign="Down" EnableKeyEvents="true">
                                                    <Listeners>
                                                        <KeyUp Handler="GenerateDecisionNumber(#{txtSoQuyetDinhLuong});" />
                                                    </Listeners>
                                                </ext:TextField>
                                                <ext:TextField runat="server" ID="txtSoQDKyLuat" AnchorHorizontal="100%" FieldLabel="Số quyết định kỷ luật"
                                                    MaxLength="10" Note="Mẫu: 001/2013/" NoteAlign="Down" EnableKeyEvents="true">
                                                    <Listeners>
                                                        <KeyUp Handler="GenerateDecisionNumber(#{txtSoQDKyLuat});" />
                                                    </Listeners>
                                                </ext:TextField>
                                                <ext:TextField runat="server" ID="txtSoQĐieuChuyen" AnchorHorizontal="100%" FieldLabel="Số quyết định điều chuyển"
                                                    MaxLength="10" Note="Mẫu: 001/2013/" NoteAlign="Down" EnableKeyEvents="true">
                                                    <Listeners>
                                                        <KeyUp Handler="GenerateDecisionNumber(#{txtSoQĐieuChuyen});" />
                                                    </Listeners>
                                                </ext:TextField>
                                            </Items>
                                        </ext:Container>
                                    </Items>
                                </ext:Container>
                            </Items>
                        </ext:FieldSet>
                    </Items>
                </ext:Panel>
                <ext:Panel runat="server" ID="Panel1" Title="Người ký báo cáo" AnchorHorizontal="100%"
                    AutoHeight="true" Border="false" Layout="FormLayout" Padding="6">
                    <Items>
                        <ext:FieldSet ID="FieldSet4" runat="server" AnchorHorizontal="100%" Title="Cấu hình người ký báo cáo"
                            Layout="FormLayout">
                            <Items>
                                <ext:Container runat="server" ID="ctnguoic" Layout="ContainerLayout">
                                    <Items>
                                        <ext:Container runat="server" ID="ctnguoikyco" Layout="ColumnLayout" Height="25">
                                            <Items>
                                                <ext:TextField runat="server" ID="txtnguoiky1" FieldLabel="Người báo cáo" AnchorHorizontal="75%"
                                                    EmptyText="Nhập tên người lập" />
                                                <ext:DisplayField runat="server" Width="10" ID="df1">
                                                </ext:DisplayField>
                                                <ext:Checkbox runat="server" BoxLabel="Là người đăng nhập" ID="chknguoidangnhap">
                                                    <Listeners>
                                                        <Check Handler="if(#{chknguoidangnhap}.checked==true){#{txtnguoiky1}.disable();} else {#{txtnguoiky1}.enable();}" />
                                                    </Listeners>
                                                </ext:Checkbox>
                                            </Items>
                                        </ext:Container>
                                    </Items>
                                </ext:Container>
                                <ext:TextField runat="server" ID="txtnguoiky2" FieldLabel="Tổng giám đốc" AnchorHorizontal="100%"
                                    EmptyText="Nhập tên giám đốc/Tổng giám đốc" />
                                <ext:TextField runat="server" ID="txtnguoiky3" FieldLabel="Kế toán trưởng" AnchorHorizontal="100%"
                                    EmptyText="Nhập tên kế toán trưởng" />
                                <ext:TextField runat="server" ID="txtnguoiky4" FieldLabel="TP. HCNS" AnchorHorizontal="100%"
                                    EmptyText="Nhập tên trưởng phòng HCNS" />
                            </Items>
                        </ext:FieldSet>
                    </Items>
                </ext:Panel>
            </Items>
        </ext:TabPanel>
    </Items>
    <DirectEvents>
        <BeforeShow OnEvent="wdWindow_BeforeShow" />
    </DirectEvents>
    <Listeners>
        <%--<BeforeShow Handler="#{DirectMethods}.FillData();" />--%>
        <Hide Handler="#{txtSystemMail}.reset();#{txtPassword}.reset();#{txtConfirmPassword}.reset();#{cbMenuType}.reset();#{txtnguoiky1}.reset();
            #{txtnguoiky2}.reset();#{txtnguoiky3}.reset();" />
    </Listeners>
    <Buttons>
        <ext:Button ID="btnUpdateConfig" runat="server" Text="Cập nhật" Icon="Disk">
            <Listeners>
                <Click Handler="return ValidateForm(#{txtSystemMail},#{txtPassword},#{txtConfirmPassword}, #{txtSoLuong});" />
            </Listeners>
            <DirectEvents>
                <Click OnEvent="btnUpdateConfig_Click">
                    <EventMask ShowMask="true" Msg="Chờ trong giây lát..." />
                </Click>
            </DirectEvents>
        </ext:Button>
        <ext:Button runat="server" Text="Đóng lại" Icon="Decline">
            <Listeners>
                <Click Handler="#{wdWindow}.hide();" />
            </Listeners>
        </ext:Button>
    </Buttons>
</ext:Window>
