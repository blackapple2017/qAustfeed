<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Modules_TuyenDung_DanhSachThamSo_Default" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../../Resource/js/RenderJS.js" type="text/javascript"></script>
    <script type="text/javascript">
        var ResetForm = function () {
            txtGiaTri.reset();
            txtGhiChu.reset();
            chkTinhTrang.checked = true;
        }
        var Validate = function () {
            if (txtGiaTri.getValue().trim() == '') {
                alert("Bạn chưa nhập giá trị");
                txtGiaTri.focus();
                return false;
            }
            if (txtGiaTri.getValue().trim().length > 500) {
                alert("Độ dài vượt quá giới hạn cho phép");
                txtGiaTri.focus();
                return false;
            }
            if (txtGhiChu.getValue().trim().length > 500) {
                alert("Độ dài vượt quá giới hạn cho phép");
                txtGhiChu.focus();
                return false;
            }
            return true;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ext:ResourceManager runat="server" ID="RM">
            <Listeners>
                <DocumentReady Handler="grpDanhSachThamSoStore.reload();" />
            </Listeners>
        </ext:ResourceManager>
        <ext:Hidden runat="server" ID="hdfRecordID" />
        <ext:Window runat="server" Title="Cập nhật giá trị tham số" Padding="6" Layout="FormLayout"
            ID="wdThemGiaTri" Modal="true" Hidden="true" Width="450" AutoHeight="true">
            <Items>
                <ext:TextField runat="server" ID="txtGiaTri" FieldLabel="Giá trị" AnchorHorizontal="100%" />
                <ext:TextArea runat="server" ID="txtGhiChu" FieldLabel="Ghi chú" AnchorHorizontal="100%">
                </ext:TextArea>
                <ext:Checkbox runat="server" Checked="true" ID="chkTinhTrang" FieldLabel="Tình trạng"
                    BoxLabel="Đang sử dụng">
                </ext:Checkbox>
            </Items>
            <Listeners>
                <Hide Handler="ResetForm();btnCapNhat.show();btnUpdateAndClose.show();btnUpdate.hide();" />
            </Listeners>
            <Buttons>
                <ext:Button ID="btnCapNhat" runat="server" Text="Cập nhật & nhập tiếp" Icon="Disk">
                    <Listeners>
                        <Click Handler="return Validate();" />
                    </Listeners>
                    <DirectEvents>
                        <Click OnEvent="btnCapNhat_Click">
                            <EventMask ShowMask="true" Msg="Chờ trong giây lát..." />
                            <ExtraParams>
                                <ext:Parameter Name="Close" Value="False">
                                </ext:Parameter>
                            </ExtraParams>
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button ID="btnUpdate" Hidden="true" runat="server" Text="Cập nhật" Icon="Disk">
                    <Listeners>
                        <Click Handler="return Validate();" />
                    </Listeners>
                    <DirectEvents>
                        <Click OnEvent="btnCapNhat_Click">
                            <EventMask ShowMask="true" Msg="Chờ trong giây lát..." />
                            <ExtraParams>
                                <ext:Parameter Name="Close" Value="False">
                                </ext:Parameter>
                                <ext:Parameter Name="Command" Value="Update">
                                </ext:Parameter>
                            </ExtraParams>
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button runat="server" Text="Cập nhật & Đóng lại" ID="btnUpdateAndClose" Icon="Disk">
                    <Listeners>
                        <Click Handler="return Validate();" />
                    </Listeners>
                    <DirectEvents>
                        <Click OnEvent="btnCapNhat_Click">
                            <EventMask ShowMask="true" Msg="Chờ trong giây lát..." />
                            <ExtraParams>
                                <ext:Parameter Name="Close" Value="True">
                                </ext:Parameter>
                            </ExtraParams>
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button ID="Button4" runat="server" Text="Đóng lại" Icon="Decline">
                    <Listeners>
                        <Click Handler="wdThemGiaTri.hide();" />
                    </Listeners>
                </ext:Button>
            </Buttons>
        </ext:Window>
        <ext:Viewport runat="server" ID="vp">
            <Items>
                <ext:BorderLayout ID="BorderLayout1" runat="server">
                    <Center>
                        <ext:GridPanel ID="grpDanhSachThamSo" runat="server" Header="true" Title="Danh sách hình thức làm việc"
                            AutoExpandColumn="Description" StripeRows="true" Border="false">
                            <TopBar>
                                <ext:Toolbar runat="server" ID="tb">
                                    <Items>
                                        <ext:Button ID="Button1" runat="server" Text="Thêm" Icon="Add">
                                            <Listeners>
                                                <Click Handler="wdThemGiaTri.show();" />
                                            </Listeners>
                                        </ext:Button>
                                        <ext:Button ID="btnEdit" runat="server" Disabled="true" Text="Sửa" Icon="Pencil">
                                            <Listeners>
                                                <Click Handler="btnCapNhat.hide();btnUpdateAndClose.hide();btnUpdate.show();" />
                                            </Listeners>
                                            <DirectEvents>
                                                <Click OnEvent="btnEdit_Click">
                                                    <EventMask ShowMask="true" Msg="Chờ trong giây lát..." />
                                                </Click>
                                            </DirectEvents>
                                        </ext:Button>
                                        <ext:Button runat="server" ID="btnDelete" Text="Xóa" Disabled="true" Icon="Delete">
                                            <DirectEvents>
                                                <Click OnEvent="btnDelete_Click">
                                                    <EventMask ShowMask="true" Msg="Đang xóa dữ liệu..." />
                                                    <Confirmation Title="Cảnh báo" ConfirmRequest="true" Message="Bạn có chắc chắn muốn xóa không ?" />
                                                </Click>
                                            </DirectEvents>
                                        </ext:Button>
                                        <ext:ToolbarSeparator runat="server" />
                                        <ext:ComboBox runat="server" ID="cbDanhSachThamSo" SelectedIndex="0" FieldLabel="Danh sách tham số"
                                            Width="350" Editable="false">
                                            <Items>
                                                <ext:ListItem Value="HinhThucLamViec" Text="Hình thức làm việc" />
                                                <ext:ListItem Value="CacMonThiTuyen" Text="Danh sách các môn thi tuyển" />
                                                <ext:ListItem Value="TrangThaiTuyenDung" Text="Trạng thái kế hoạch tuyển dụng" />
                                                <ext:ListItem Value="NguonUngVien" Text="Danh sách nguồn ứng viên" />
                                                <ext:ListItem Value="LyDoDuaVaoKho" Text="Lý do đưa ứng viên vào kho" />
                                                <ext:ListItem Value="LyDoDuaVaoDanhSachHanChe" Text="Lý do đưa ứng viên vào danh sách hạn chế" />
                                                <ext:ListItem Value="DanhSachKyNang" Text="Danh sách kỹ năng" />
                                                <ext:ListItem Value="LyDoTuyenDung" Text="Lý do tuyển dụng" />
                                            </Items>
                                            <Listeners>
                                                <Select Handler="PagingToolbar1.pageIndex=0;PagingToolbar1.doLoad();grpDanhSachThamSoStore.reload();" />
                                            </Listeners>
                                        </ext:ComboBox>
                                        <ext:ToolbarFill runat="server" />
                                        <ext:TextField runat="server" EnableKeyEvents="true" EmptyText="Nhập từ khóa tìm kiếm"
                                            ID="txtSearch" Width="200">
                                        </ext:TextField>
                                        <ext:Button runat="server" Text="Tìm kiếm" Icon="Zoom">
                                            <Listeners>
                                                <Click Handler="PagingToolbar1.pageIndex=0;PagingToolbar1.doLoad();grpDanhSachThamSoStore.reload();" />
                                            </Listeners>
                                        </ext:Button>
                                    </Items>
                                </ext:Toolbar>
                            </TopBar>
                            <Store>
                                <ext:Store ID="grpDanhSachThamSoStore" runat="server" OnRefreshData="grpDanhSachThamSoStore_OnRefreshData">
                                    <Reader>
                                        <ext:JsonReader IDProperty="ID">
                                            <Fields>
                                                <ext:RecordField Name="ID" />
                                                <ext:RecordField Name="Value" />
                                                <ext:RecordField Name="Description" />
                                                <ext:RecordField Name="CreatedDate" />
                                                <ext:RecordField Name="IsInUsed" />
                                            </Fields>
                                        </ext:JsonReader>
                                    </Reader>
                                </ext:Store>
                            </Store>
                            <ColumnModel ID="ColumnModel1" runat="server">
                                <Columns>
                                    <ext:RowNumbererColumn Header="STT" Width="35" />
                                    <ext:Column ColumnID="Value" Header="Giá trị" Width="200" DataIndex="Value" />
                                    <ext:CheckColumn Header="Đang sử dụng" Width="90" DataIndex="IsInUsed">
                                    </ext:CheckColumn>
                                    <ext:DateColumn Header="Ngày tạo" Width="85" DataIndex="CreatedDate" Format="dd/MM/yyyy" />
                                    <ext:Column Header="Ghi chú" Width="200" DataIndex="Description">
                                    </ext:Column> 
                                </Columns>
                            </ColumnModel>
                            <SelectionModel>
                                <ext:RowSelectionModel ID="RowSelectionModel1" runat="server">
                                    <Listeners>
                                        <RowSelect Handler="hdfRecordID.setValue(RowSelectionModel1.getSelected().id);btnEdit.enable();btnDelete.enable();" />
                                    </Listeners>
                                </ext:RowSelectionModel>
                            </SelectionModel>
                            <Listeners>
                                <RowDblClick Handler="btnCapNhat.hide();btnUpdateAndClose.hide();btnUpdate.show();" />
                            </Listeners>
                            <DirectEvents>
                                <RowDblClick OnEvent="btnEdit_Click">
                                    <EventMask ShowMask="true" Msg="Chờ trong giây lát..." />
                                </RowDblClick>
                            </DirectEvents>
                            <LoadMask ShowMask="true" />
                            <BottomBar>
                                <ext:PagingToolbar ID="PagingToolbar1" runat="server" PageSize="10">
                                    <Items>
                                        <ext:Label ID="Label1" runat="server" Text="Page size:" />
                                        <ext:ToolbarSpacer ID="ToolbarSpacer1" runat="server" Width="10" />
                                        <ext:ComboBox ID="ComboBox1" runat="server" Width="80">
                                            <Items>
                                                <ext:ListItem Text="1" />
                                                <ext:ListItem Text="2" />
                                                <ext:ListItem Text="10" />
                                                <ext:ListItem Text="20" />
                                            </Items>
                                            <SelectedItem Value="10" />
                                            <Listeners>
                                                <Select Handler="#{PagingToolbar1}.pageSize = parseInt(this.getValue()); #{PagingToolbar1}.doLoad();" />
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
