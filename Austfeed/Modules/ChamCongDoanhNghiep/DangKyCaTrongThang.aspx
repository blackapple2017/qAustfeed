<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DangKyCaTrongThang.aspx.cs"
    Inherits="Modules_ChamCongDoanhNghiep_ThietLapCaChoNhanVien" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>
<%@ Register Src="../ChooseEmployee/ucChooseEmployee.ascx" TagName="ucChooseEmployee"
    TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #grpDanhSachBangPhanCaThang
        {
            border-left: 1px solid #99bbe8 !important;
        }
        #pnlCoCauToChuc-xsplit
        {
            border-right: none !important;
        }
    </style>
    <script src="../../Resource/js/jquery-1.4.2.min.js" type="text/javascript"></script>
    <link href="Resource/DangKyCaTrongThang.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Resource/js/jquery-1.4.2.min.js"></script>
    <script src="Resource/jsDangKyCaTrongThang.js" type="text/javascript"></script>
    <script type="text/javascript">
        var enterKeyPressHandler = function (f, e) {
            if (e.getKey() == e.ENTER) {
                PagingToolbar1.pageIndex = 0; PagingToolbar1.doLoad();
            }
            if (txtSearchKey.getValue() != '')
                this.triggers[0].show();
        }
        var ResetNodeChecked = function (tree, stringallmadonvi) {
            if (stringallmadonvi.getValue().length != 0) {
                var str = stringallmadonvi.getValue().split(',');
                for (var i = 0; i < str.length; i++) {
                    if (str[i].length != 0) {
                        tree.getNodeById(str[i]).getUI().checkbox.checked = false;
                    }
                }
            }
        }

        var GetSelectedNodeDonVi = function (tree, stringallmadonvi, stringmadonvi) {
            if (stringallmadonvi.getValue().length != 0) {
                stringmadonvi.setValue('');
                stringmadonvi.reset();
                var str = stringallmadonvi.getValue().split(',');
                for (var i = 0; i < str.length; i++) {
                    if (str[i].length != 0) {
                        if (tree.getNodeById(str[i]).getUI().checkbox.checked == true) {
                            stringmadonvi.setValue(stringmadonvi.getValue() + "," + str[i]);
                        }
                    }
                }
                stringmadonvi.setValue(stringmadonvi.getValue().substring(1, stringmadonvi.getValue().length));
            }
        }

        var getTasks = function (tree) {
            var msg = [],
                    selNodes = tree.getChecked();
            msg.push("[");

            Ext.each(selNodes, function (node) {
                if (msg.length > 1) {
                    msg.push(",");
                }

                msg.push(node.text);
            });

            msg.push("]");

            return msg.join("");
        };

        var afterEdit = function (e) {
            PhanCaTrongThang.AfterEdit(e.field, e.originalValue, e.value, e.record.data.ID)
        }
        var saveData = function () {
            var innerHTML = document.getElementById("sqlQuery").innerHTML;
            if (innerHTML.length != 0) {
                Ext.net.DirectMethods.SaveData(innerHTML);
            }
        }

        var clearSQL = function () {
            document.getElementById("sqlQuery").innerHTML = "";
        }

        var getPageIndex = function () {
            $("#ext-comp-1042").text;
        }

        $(function () {
            setInterval("saveData()", 1000 * 600); // 10" gửi request một lần
        });
    </script>
    <asp:Literal Text="" ID="ltrweekendStyle" runat="server" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ext:ResourceManager runat="server" ID="RM">
        </ext:ResourceManager>
        <uc1:ucChooseEmployee ID="ucChooseEmployee1" runat="server" />
        <div id="sqlQuery" style="display: none;">
        </div>
        <ext:Hidden runat="server" ID="hdfMaDonVi" />
        <ext:Hidden runat="server" ID="hdfStringAllMaDonVi">
        </ext:Hidden>
        <ext:Hidden runat="server" ID="hdfStringMaDonVi" />
        <ext:Hidden runat="server" ID="hdfIDBangPhanCa" />
        <ext:Hidden runat="server" ID="hdfUserID" />
        <ext:Hidden runat="server" ID="hdfMenuID" />
        <ext:Store ID="Store2" runat="server">
            <Reader>
                <ext:JsonReader IDProperty="ID">
                    <Fields>
                        <ext:RecordField Name="ID" />
                        <ext:RecordField Name="MaCa" />
                        <ext:RecordField Name="TenCa" />
                        <ext:RecordField Name="GioVao" />
                        <ext:RecordField Name="GioRa" />
                    </Fields>
                </ext:JsonReader>
            </Reader>
        </ext:Store>
        <ext:Store runat="server" ID="cbChonLaiBangPhanCaStore" OnRefreshData="cbChonLaiBangPhanCaStore_OnRefreshData"
            AutoLoad="false">
            <Reader>
                <ext:JsonReader IDProperty="ID">
                    <Fields>
                        <ext:RecordField Name="TenBangPhanCa" />
                        <ext:RecordField Name="ID" />
                    </Fields>
                </ext:JsonReader>
            </Reader>
        </ext:Store>
        <ext:Store runat="server" ID="grpDanhSachBangPhanCaThangStore" AutoSave="false" OnBeforeStoreChanged="HandleChanges">
            <Proxy>
                <ext:HttpProxy Json="true" Method="GET" Url="Handler/BangPhanCaThang.ashx">
                </ext:HttpProxy>
            </Proxy>
            <AutoLoadParams>
                <ext:Parameter Name="Start" Value="={0}" />
                <ext:Parameter Name="Limit" Value="={25}" />
            </AutoLoadParams>
            <BaseParams>
                <ext:Parameter Name="MaDonVi" Value="#{hdfMaDonVi}.getValue()" Mode="Raw" />
                <ext:Parameter Name="IDBangPhanCa" Value="#{hdfIDBangPhanCa}.getValue()" Mode="Raw" />
                <ext:Parameter Name="SearchKey" Value="#{txtSearchKey}.getValue()" Mode="Raw" />
                <ext:Parameter Name="UserID" Value="#{hdfUserID}.getValue()" Mode="Raw" />
                <ext:Parameter Name="MenuID" Value="#{hdfMenuID}.getValue()" Mode="Raw" />
            </BaseParams>
            <Reader>
                <ext:JsonReader Root="Data" TotalProperty="TotalRecords" IDProperty="ID">
                    <Fields>
                        <ext:RecordField Name="ID" />
                        <ext:RecordField Name="MaCB" />
                        <ext:RecordField Name="TenCB" />
                        <ext:RecordField Name="BoPhan" />
                        <ext:RecordField Name="Ngay01" />
                        <ext:RecordField Name="Ngay02" />
                        <ext:RecordField Name="Ngay03" />
                        <ext:RecordField Name="Ngay04" />
                        <ext:RecordField Name="Ngay05" />
                        <ext:RecordField Name="Ngay06" />
                        <ext:RecordField Name="Ngay07" />
                        <ext:RecordField Name="Ngay08" />
                        <ext:RecordField Name="Ngay09" />
                        <ext:RecordField Name="Ngay10" />
                        <ext:RecordField Name="Ngay11" />
                        <ext:RecordField Name="Ngay12" />
                        <ext:RecordField Name="ngay13" />
                        <ext:RecordField Name="ngay14" />
                        <ext:RecordField Name="Ngay15" />
                        <ext:RecordField Name="Ngay16" />
                        <ext:RecordField Name="Ngay17" />
                        <ext:RecordField Name="Ngay18" />
                        <ext:RecordField Name="Ngay19" />
                        <ext:RecordField Name="Ngay20" />
                        <ext:RecordField Name="Ngay21" />
                        <ext:RecordField Name="Ngay22" />
                        <ext:RecordField Name="Ngay23" />
                        <ext:RecordField Name="Ngay24" />
                        <ext:RecordField Name="Ngay25" />
                        <ext:RecordField Name="Ngay26" />
                        <ext:RecordField Name="Ngay27" />
                        <ext:RecordField Name="Ngay28" />
                        <ext:RecordField Name="Ngay29" />
                        <ext:RecordField Name="Ngay30" />
                        <ext:RecordField Name="Ngay31" />
                    </Fields>
                </ext:JsonReader>
            </Reader>
        </ext:Store>
        <ext:Window runat="server" Icon="ClockAdd" ID="wdTaoBangPhanCa" Padding="6" Layout="FormLayout"
            Title="Tạo bảng phân ca" Hidden="true" LabelWidth="105" Width="470" Modal="true"
            Constrain="true" AutoHeight="true">
            <Items>
                <ext:DropDownField runat="server" Editable="false" ID="ddfDonVi" AnchorHorizontal="99%"
                    AllowBlank="false" BlankText="Bạn phải chọn đơn vị hoặc bộ phận sử dụng" FieldLabel="Chọn bộ phận">
                    <Component>
                        <ext:TreePanel ID="TreePanelDonVi" runat="server" Header="false" Icon="Accept" Height="300"
                            Shadow="None" UseArrows="true" AutoScroll="true" Animate="true" EnableDD="true"
                            ContainerScroll="true" RootVisible="false">
                            <Root>
                            </Root>
                            <Buttons>
                                <ext:Button ID="Button2" Icon="Decline" runat="server" Text="Đóng lại">
                                    <Listeners>
                                        <Click Handler="#{ddfDonVi}.collapse();" />
                                    </Listeners>
                                </ext:Button>
                            </Buttons>
                        </ext:TreePanel>
                    </Component>
                    <Listeners>
                        <Expand Handler="this.component.getRootNode().expand(true);" Single="false" Delay="10" />
                    </Listeners>
                </ext:DropDownField>
                <ext:CompositeField runat="server" FieldLabel="Thời gian<span style='color:red;'>*</span>"
                    Height="30">
                    <Items>
                        <ext:DisplayField runat="server" Text="Tháng" />
                        <ext:ComboBox Editable="false" ID="cbThang" Width="100" runat="server">
                            <Items>
                                <ext:ListItem Text="Tháng 1" Value="1" />
                                <ext:ListItem Text="Tháng 2" Value="2" />
                                <ext:ListItem Text="Tháng 3" Value="3" />
                                <ext:ListItem Text="Tháng 4" Value="4" />
                                <ext:ListItem Text="Tháng 5" Value="5" />
                                <ext:ListItem Text="Tháng 6" Value="6" />
                                <ext:ListItem Text="Tháng 7" Value="7" />
                                <ext:ListItem Text="Tháng 8" Value="8" />
                                <ext:ListItem Text="Tháng 9" Value="9" />
                                <ext:ListItem Text="Tháng 10" Value="10" />
                                <ext:ListItem Text="Tháng 11" Value="11" />
                                <ext:ListItem Text="Tháng 12" Value="12" />
                            </Items>
                        </ext:ComboBox>
                        <ext:DisplayField ID="DisplayField1" runat="server" Text="Năm" />
                        <ext:SpinnerField ID="spfYear" AllowBlank="false" Width="100" runat="server" />
                    </Items>
                </ext:CompositeField>
                <ext:Checkbox runat="server" ID="chkLayTuThangTruoc" BoxLabel="Sao chép lịch phân ca từ bảng phân ca khác"
                    Checked="false" FieldLabel="Dữ liệu phân ca" Height="30" Hidden="true">
                </ext:Checkbox>
                <ext:TextField runat="server" ID="txtTenBangPhanCa" Height="60" FieldLabel="Tên bảng phân ca"
                    AnchorHorizontal="100%" />
            </Items>
            <Listeners>
                <BeforeShow Handler="cbThang.setValue(new Date().getMonth()+1);spfYear.setValue(new Date().getFullYear());" />
                <Hide Handler="resetTaoBangPhanCa();" />
            </Listeners>
            <Buttons>
                <ext:Button ID="btnTaoBangPhanCaThang" runat="server" Text="Đồng ý" Icon="Accept">
                    <Listeners>
                        <Click Handler="return validateForm(); GetSelectedNodeDonVi(TreePanelDonVi,hdfStringAllMaDonVi,hdfStringMaDonVi);" />
                    </Listeners>
                    <DirectEvents>
                        <Click OnEvent="btnTaoBangPhanCaThang_Click">
                            <EventMask ShowMask="true" Msg="Chờ trong giây lát..." />
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button ID="Button8" runat="server" Text="Đóng lại" Icon="Decline">
                    <Listeners>
                        <Click Handler="wdTaoBangPhanCa.hide();" />
                    </Listeners>
                </ext:Button>
            </Buttons>
        </ext:Window>
        <ext:Window Modal="true" Hidden="true" runat="server" ID="wdThietLapCaNhanh" Layout="FormLayout"
            Constrain="true" Title="Thiết lập ca nhanh" Resizable="false" Icon="DateAdd"
            Width="500" LabelWidth="120" Padding="6" AutoHeight="true">
            <Items>
                <ext:Container ID="Container1" runat="server" Layout="ColumnLayout" Height="30">
                    <Items>
                        <ext:DateField ID="FromDate" Format="dd/MM/yyyy" Editable="false" runat="server"
                            TodayText="Hôm nay" Vtype="daterange" FieldLabel="Từ ngày<span style='color:red;'>*</span>"
                            ColumnWidth="0.5" EnableKeyEvents="true">
                            <CustomConfig>
                                <ext:ConfigItem Name="endDateField" Value="#{ToDate}" Mode="Value" />
                            </CustomConfig>
                               <Listeners>
                                <KeyUp Fn="onKeyUp" />
                            </Listeners>
                        </ext:DateField>
                        <ext:DateField ID="ToDate" runat="server" Format="dd/MM/yyyy" Editable="false" TodayText="Hôm nay"
                            Vtype="daterange" FieldLabel="Đến ngày<span style='color:red;'>*</span>" ColumnWidth="0.5"
                            EnableKeyEvents="true">
                            <CustomConfig>
                                <ext:ConfigItem Name="startDateField" Value="#{FromDate}" Mode="Value" />
                            </CustomConfig>
                              <Listeners>
                                <KeyUp Fn="onKeyUp" />
                            </Listeners>
                        </ext:DateField>
                    </Items>
                </ext:Container>
                <ext:ComboBox ID="cbTinhTrangLamViec" runat="server" EmptyText="Chọn ca làm việc"
                    TypeAhead="true" AnchorHorizontal="100%" ForceSelection="true" StoreID="Store2"
                    Mode="Local" DisplayField="TenCa" ValueField="MaCa" FieldLabel="Chọn ca làm việc<span style='color:red;'>*</span>"
                    MinChars="1" ListWidth="300" PageSize="10" ItemSelector="tr.list-item" Editable="false">
                    <Template ID="Template1" runat="server">
                        <Html>
                            <tpl for=".">
						        <tpl if="[xindex] == 1">
							        <table class="cbStates-list">
								        <tr>
									        <th>Mã ca</th>
									        <th>Tên ca</th>
                                            <th>Giờ vào</th>
									        <th>Giờ ra</th>
								        </tr>
						        </tpl>
						        <tr class="list-item">
							        <td style="padding:3px 0px;">{MaCa}</td>
							        <td>{TenCa}</td>
                                    <td>{GioVao}</td>
                                    <td>{GioRa}</td>
						        </tr>
						        <tpl if="[xcount-xindex]==0">
							        </table>
						        </tpl>
					        </tpl>
                        </Html>
                    </Template>
                </ext:ComboBox>
                <ext:CompositeField ID="CompositeField1" AnchorHorizontal="100%" runat="server">
                    <Items>
                        <ext:Checkbox runat="server" ID="chkSaturday" FieldLabel="Bao gồm thứ 7">
                            <Listeners>
                                <Check Handler="if(chkSaturday.checked){
                                                            MultiComboSaturday.enable();
                                                        }else
                                                        {
                                                            MultiComboSaturday.disable();
                                                        }" />
                            </Listeners>
                        </ext:Checkbox>
                        <ext:ComboBox ID="MultiComboSaturday" runat="server"  TypeAhead="true"  Width="322"
                            AnchorHorizontal="100%" ForceSelection="true" StoreID="Store2" Mode="Local" DisplayField="TenCa"
                            ValueField="MaCa" EmptyText="Chọn ca làm việc cho thứ 7"
                            MinChars="1" ListWidth="300" PageSize="10" ItemSelector="tr.list-item" Editable="false">
                            <Template ID="Template4" runat="server">
                                <Html>
                                    <tpl for=".">
						        <tpl if="[xindex] == 1">
							        <table class="cbStates-list">
								        <tr>
									        <th>Mã ca</th>
									        <th>Tên ca</th>
                                            <th>Giờ vào</th>
									        <th>Giờ ra</th>
								        </tr>
						        </tpl>
						        <tr class="list-item">
							        <td style="padding:3px 0px;">{MaCa}</td>
							        <td>{TenCa}</td>
                                    <td>{GioVao}</td>
                                    <td>{GioRa}</td>
						        </tr>
						        <tpl if="[xcount-xindex]==0">
							        </table>
						        </tpl>
					        </tpl>
                                </Html>
                            </Template>
                        </ext:ComboBox>
                    </Items>
                </ext:CompositeField>
                <ext:CompositeField ID="CompositeField2" AnchorHorizontal="100%" runat="server">
                    <Items>
                        <ext:Checkbox runat="server" ID="chkSunday" FieldLabel="Bao gồm CN">
                            <Listeners>
                                <Check Handler="if(chkSunday.checked){
                                                            MultiComboSunday.enable();
                                                        }else
                                                        {
                                                            MultiComboSunday.disable();
                                                        }" />
                            </Listeners>
                        </ext:Checkbox>
                        <ext:ComboBox ID="MultiComboSunday" runat="server" EmptyText="Chọn ca làm việc cho chủ nhật" TypeAhead="true"  Width="322"
                            AnchorHorizontal="100%" ForceSelection="true" StoreID="Store2" Mode="Local" DisplayField="TenCa"
                            ValueField="MaCa" 
                            MinChars="1" ListWidth="300" PageSize="10" ItemSelector="tr.list-item" Editable="false">
                            <Template ID="Template2" runat="server">
                                <Html>
                                    <tpl for=".">
						        <tpl if="[xindex] == 1">
							        <table class="cbStates-list">
								        <tr>
									        <th>Mã ca</th>
									        <th>Tên ca</th>
                                            <th>Giờ vào</th>
									        <th>Giờ ra</th>
								        </tr>
						        </tpl>
						        <tr class="list-item">
							        <td style="padding:3px 0px;">{MaCa}</td>
							        <td>{TenCa}</td>
                                    <td>{GioVao}</td>
                                    <td>{GioRa}</td>
						        </tr>
						        <tpl if="[xcount-xindex]==0">
							        </table>
						        </tpl>
					        </tpl>
                                </Html>
                            </Template>
                        </ext:ComboBox>
                    </Items>
                </ext:CompositeField>
                <ext:RadioGroup runat="server" ColumnsNumber="1" FieldLabel="Đối tượng" AnchorHorizontal="100%">
                    <Items>
                        <ext:Radio runat="server" BoxLabel="Áp dụng cho bộ phận được chọn" ID="rdApplyforSelectedDepartment" />
                        <ext:Radio runat="server" BoxLabel="Chỉ áp dụng cho những nhân viên được chọn" ID="rdApplyforSelectedEmployee">
                            <Listeners>
                                <Check Handler="if(#{rdApplyforSelectedEmployee}.checked){
                                            if(grpDanhSachBangPhanCaThang.getSelectionModel().getCount() ==0)
                                            {
                                                btnThietLapCaNhanh.disable();                                                 
                                                Ext.Msg.alert('Thông báo','Bạn chưa chọn nhân viên nào, bạn phải chọn ít nhất một nhân viên để thực hiện chức năng này'); 
                                               
                                            }
                                        }else
                                        {
                                            btnThietLapCaNhanh.enable();
                                        }" />
                            </Listeners>
                        </ext:Radio>
                    </Items>
                </ext:RadioGroup>
            </Items>
            <Buttons>
                <ext:Button runat="server" ID="btnThietLapCaNhanh" Text="Đồng ý" Icon="Accept">
                    <Listeners>
                        <Click Handler="return validateFormThietLapNhanh();" />
                    </Listeners>
                    <DirectEvents>
                        <Click OnEvent="btnThietLapCaNhanh_Click">
                            <EventMask ShowMask="true" Msg="Đợi trong giây lát..." />
                        </Click>
                    </DirectEvents>
                </ext:Button>
                <ext:Button ID="Button3" runat="server" Text="Đóng lại" Icon="Decline">
                    <Listeners>
                        <Click Handler="#{wdThietLapCaNhanh}.hide();" />
                    </Listeners>
                </ext:Button>
            </Buttons>
            <Listeners>
                <Hide Handler="rdApplyforSelectedDepartment.reset();rdApplyforSelectedEmployee.reset();MultiComboSunday.reset();
                                MultiComboSaturday.reset();cbTinhTrangLamViec.reset();FromDate.reset();ToDate.reset();" />
            </Listeners>
        </ext:Window>
        <ext:Window runat="server" ID="wdChonBangPhanCa" Icon="Clock" Constrain="true" Resizable="false"
            Layout="FormLayout" Padding="6" Width="550" Hidden="true" Modal="true" Title="Chọn bảng phân ca"
            AutoHeight="true" LabelWidth="1">
            <Items>
                <ext:CompositeField runat="server" AnchorHorizontal="99%" Height="30">
                    <Items>
                        <ext:DisplayField runat="server" Text="Chọn năm" />
                        <ext:SpinnerField runat="server" ID="spnChonNam" Width="60">
                            <Listeners>
                                <Spin Handler="cbChonLaiBangPhanCaStore.reload();cbChonLaiBangPhanCa.reset();" />
                            </Listeners>
                        </ext:SpinnerField>
                        <ext:DisplayField runat="server" Text="Bảng phân ca" />
                        <ext:ComboBox runat="server" Width="300" ID="cbChonLaiBangPhanCa" StoreID="cbChonLaiBangPhanCaStore"
                            DisplayField="TenBangPhanCa" ValueField="ID" Editable="true" PageSize="100" ItemSelector="div.search-item">
                            <Template ID="Template7" runat="server">
                                <Html>
                                    <tpl for=".">
						                  <div class="search-item">
							                 <h3>{TenBangPhanCa}</h3> 
						                  </div>
					                   </tpl>
                                </Html>
                            </Template>
                            <Listeners>
                                <Select Handler="#{hdfIdBangPhanCa}.setValue(cbChonLaiBangPhanCa.getValue());" />
                                <Expand Handler="
                                                    cbChonLaiBangPhanCaStore.reload();
                                                 " />
                            </Listeners>
                        </ext:ComboBox>
                    </Items>
                </ext:CompositeField>
                <%-- <ext:Checkbox runat="server" ID="chkTaiDuLieu" BoxLabel="Tải dữ liệu ngay sau khi chọn ca">
                    <Listeners>
                        <Check Handler="if(chkTaiDuLieu.checked){
                                                txtSearchKey.reset();#{PagingToolbar1}.pageIndex = 0; 
                                                #{PagingToolbar1}.doLoad();grpDanhSachBangPhanCaThangStore.reload();
                                                changeGridpanelTitle(cbChonLaiBangPhanCa.getText());
                                            }" />
                    </Listeners>
                </ext:Checkbox>--%>
            </Items>
            <Listeners>
                <Show Handler="spnChonNam.setValue(new Date().getFullYear());" />
            </Listeners>
            <Buttons>
                <ext:Button runat="server" Text="Đồng ý" Icon="Accept">
                    <Listeners>
                        <Click Handler="if(cbChonLaiBangPhanCa.getValue()=='')
                                            {
                                                 Ext.Msg.alert('Thông báo','Bạn chưa chọn bảng phân ca nào');
                                            }
                                            else
                                            {
                                                    txtSearchKey.reset();#{PagingToolbar1}.pageIndex = 0; 
                                                    #{PagingToolbar1}.doLoad();grpDanhSachBangPhanCaThangStore.reload();wdChonBangPhanCa.hide();
                                                changeGridpanelTitle(cbChonLaiBangPhanCa.getText());
                                            }" />
                    </Listeners>
                </ext:Button>
                <ext:Button runat="server" Text="Đóng lại" Icon="Decline">
                    <Listeners>
                        <Click Handler="wdChonBangPhanCa.hide();" />
                    </Listeners>
                </ext:Button>
            </Buttons>
        </ext:Window>
        <ext:Viewport runat="server" ID="vp">
            <Items>
                <ext:BorderLayout runat="server" ID="br">
                    <Center>
                        <ext:GridPanel ID="grpDanhSachBangPhanCaThang" TrackMouseOver="true" runat="server"
                            Title="Bảng phân ca" StripeRows="true" ClicksToEdit="1" Width="600" Border="false"
                            Height="290" StoreID="grpDanhSachBangPhanCaThangStore">
                            <TopBar>
                                <ext:Toolbar runat="server" ID="tb">
                                    <Items>
                                        <ext:Button ID="Button6" runat="server" Text="Bảng phân ca" Icon="ClockAdd">
                                            <Menu>
                                                <ext:Menu runat="server">
                                                    <Items>
                                                        <ext:MenuItem Text="Tạo bảng phân ca">
                                                            <Listeners>
                                                                <Click Handler="wdTaoBangPhanCa.show();" />
                                                            </Listeners>
                                                        </ext:MenuItem>
                                                        <ext:MenuItem Text="Chọn bảng phân ca">
                                                            <Listeners>
                                                                <Click Handler="wdChonBangPhanCa.show();" />
                                                            </Listeners>
                                                        </ext:MenuItem>
                                                        <%--<ext:MenuItem Text="Quản lý bảng phân ca">
                                                        </ext:MenuItem>--%>
                                                    </Items>
                                                </ext:Menu>
                                            </Menu>
                                        </ext:Button>
                                        <ext:Button ID="Button1" Text="Quản lý giờ giấc" Icon="Clock" runat="server">
                                            <Menu>
                                                <ext:Menu ID="Menu1" runat="server">
                                                    <Items>
                                                        <ext:MenuItem Text="Thiết lập ca nhanh">
                                                            <Listeners>
                                                                <Click Handler="wdThietLapCaNhanh.show();" />
                                                            </Listeners>
                                                        </ext:MenuItem>
                                                        <ext:MenuItem ID="MenuItem1" runat="server" Text="Sao chép ca giữa 2 nhân viên" Hidden="true">
                                                        </ext:MenuItem>
                                                    </Items>
                                                </ext:Menu>
                                            </Menu>
                                        </ext:Button>
                                        <ext:Button Icon="User" Text="Quản lý nhân viên" runat="server">
                                            <Menu>
                                                <ext:Menu runat="server">
                                                    <Items>
                                                        <ext:MenuItem Text="Thêm nhân viên" ID="mnuThemNhanVien" Icon="UserAdd">
                                                            <Listeners>
                                                                <Click Handler="ucChooseEmployee1_wdChooseUser.show();" />
                                                            </Listeners>
                                                        </ext:MenuItem>
                                                        <ext:MenuItem ID="mnuLoaiBoNhanVien" Disabled="true" Text="Loại bỏ nhân viên" Icon="UserDelete">
                                                            <DirectEvents>
                                                                <Click OnEvent="mnuLoaiBoNhanVien_Click">
                                                                    <Confirmation Title="Cảnh báo" Message="Bạn có chắc chắn muốn xóa không ?" ConfirmRequest="true" />
                                                                    <EventMask ShowMask="true" Msg="Chờ trong giây lát..." />
                                                                </Click>
                                                            </DirectEvents>
                                                        </ext:MenuItem>
                                                    </Items>
                                                </ext:Menu>
                                            </Menu>
                                        </ext:Button>
                                        <ext:Button runat="server" ID="btnSave" Text="Lưu lại" Icon="Disk" Hidden="true">
                                            <%--  <listeners>
                                                <click handler="alert(document.getelementbyid('sqlquery').innerhtml);" />
                                            </listeners>--%>
                                            <DirectEvents>
                                                <Click OnEvent="btnSave_Click">
                                                    <EventMask ShowMask="true" Msg="Đang lưu dữ liệu..." />
                                                    <ExtraParams>
                                                        <ext:Parameter Name="sqlQuery" Value="document.getElementById('sqlQuery').innerHTML"
                                                            Mode="Raw" />
                                                    </ExtraParams>
                                                </Click>
                                            </DirectEvents>
                                        </ext:Button>
                                        <ext:ToolbarFill runat="server" ID="tbf" />
                                        <ext:TriggerField runat="server" Width="200" EnableKeyEvents="true" EmptyText="Nhập từ khóa để tìm kiếm"
                                            ID="txtSearchKey">
                                            <Triggers>
                                                <ext:FieldTrigger Icon="Clear" HideTrigger="true" />
                                            </Triggers>
                                            <Listeners>
                                                <KeyPress Fn="enterKeyPressHandler" />
                                                <TriggerClick Handler="if (index == 0) { this.reset(); this.triggers[0].hide(); PagingToolbar1.pageIndex = 0; PagingToolbar1.doLoad(); }" />
                                            </Listeners>
                                        </ext:TriggerField>
                                        <ext:Button Text="Tìm kiếm" Icon="Zoom" runat="server" ID="btnSearch">
                                            <Listeners>
                                                <Click Handler="PagingToolbar1.pageIndex = 0;  PagingToolbar1.doLoad();" />
                                            </Listeners>
                                        </ext:Button>
                                    </Items>
                                </ext:Toolbar>
                            </TopBar>
                            <ColumnModel ID="ColumnModel1" runat="server">
                                <Columns>
                                    <ext:RowNumbererColumn Header="STT" Locked="true" Width="35" />
                                    <ext:Column ColumnID="MaCB" Header="Mã NV" Locked="true" Width="70" DataIndex="MaCB" />
                                    <ext:Column ColumnID="TenCB" Header="Họ tên" Locked="true" Width="150" DataIndex="TenCB" />
                                    <ext:Column Width="150" ColumnID="BoPhan" Header="Phòng ban" DataIndex="BoPhan" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay1" Header="01" DataIndex="Ngay01" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay2" Header="02" DataIndex="Ngay02" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay3" Header="03" DataIndex="Ngay03" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay4" Header="04" DataIndex="Ngay04" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay5" Header="05" DataIndex="Ngay05" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay6" Header="06" DataIndex="Ngay06" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay7" Header="07" DataIndex="Ngay07" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay8" Header="08" DataIndex="Ngay08" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay9" Header="09" DataIndex="Ngay09" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay10" Header="10" DataIndex="Ngay10" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay11" Header="11" DataIndex="Ngay11" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay12" Header="12" DataIndex="Ngay12" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay13" Header="13" DataIndex="ngay13" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay14" Header="14" DataIndex="ngay14" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay15" Header="15" DataIndex="Ngay15" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay16" Header="16" DataIndex="Ngay16" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay17" Header="17" DataIndex="Ngay17" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay18" Header="18" DataIndex="Ngay18" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay19" Header="19" DataIndex="Ngay19" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay20" Header="20" DataIndex="Ngay20" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay21" Header="21" DataIndex="Ngay21" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay22" Header="22" DataIndex="Ngay22" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay23" Header="23" DataIndex="Ngay23" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay24" Header="24" DataIndex="Ngay24" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay25" Header="25" DataIndex="Ngay25" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay26" Header="26" DataIndex="Ngay26" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay27" Header="27" DataIndex="Ngay27" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay28" Header="28" DataIndex="Ngay28" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay29" Header="29" DataIndex="Ngay29" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay30" Header="30" DataIndex="Ngay30" />
                                    <ext:Column Resizable="false" Width="32" ColumnID="Ngay31" Header="31" DataIndex="Ngay31" />
                                </Columns>
                            </ColumnModel>
                            <View>
                                <ext:LockingGridView runat="server" ID="lkv">
                                </ext:LockingGridView>
                            </View>
                            <Listeners>
                                <AfterEdit Fn="afterEdit" />
                            </Listeners>
                            <SelectionModel>
                                <ext:RowSelectionModel ID="RowSelectionModel1" runat="server">
                                    <Listeners>
                                        <RowSelect Handler="mnuLoaiBoNhanVien.enable();" />
                                    </Listeners>
                                </ext:RowSelectionModel>
                            </SelectionModel>
                            <LoadMask ShowMask="true" Msg="Đang tải dữ liệu..." />
                            <BottomBar>
                                <ext:PagingToolbar ID="PagingToolbar1" runat="server" PageSize="25">
                                    <Items>
                                        <ext:Label ID="Label1" runat="server" Text="Page size:" />
                                        <ext:ToolbarSpacer ID="ToolbarSpacer1" runat="server" Width="30" />
                                        <ext:ComboBox ID="ComboBox1" Editable="false" runat="server" Width="80">
                                            <Items>
                                                <ext:ListItem Text="10" />
                                                <ext:ListItem Text="20" />
                                                <ext:ListItem Text="25" />
                                                <ext:ListItem Text="30" />
                                                <ext:ListItem Text="50" />
                                            </Items>
                                            <SelectedItem Value="25" />
                                            <Listeners>
                                                <Select Handler="#{PagingToolbar1}.pageSize = parseInt(this.getValue()); #{PagingToolbar1}.doLoad();" />
                                            </Listeners>
                                        </ext:ComboBox>
                                    </Items>
                                    <Listeners>
                                        <Change Handler="RowSelectionModel1.clearSelections();" />
                                    </Listeners>
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
