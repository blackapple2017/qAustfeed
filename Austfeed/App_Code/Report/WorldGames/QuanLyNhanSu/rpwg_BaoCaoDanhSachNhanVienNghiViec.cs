using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DataController;

/// <summary>
/// Summary description for rpwg_BaoCaoDanhSachNhanVienNghiViec
/// </summary>
public class rpwg_BaoCaoDanhSachNhanVienNghiViec : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private XRLabel xrReportTitle;
    private XRLabel xrCompanyName;
    private PageHeaderBand PageHeader;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell8;
    private PageFooterBand PageFooter;
    private XRPageInfo xrPageInfo1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrSTT;
    private XRTableCell xrLyDoNghi;
    private XRTableCell xrQuyetDinhSo;
    private XRTableCell xrNgayThoiViec;
    private XRTableCell xrFullName;
    private XRTableCell xrTinhTrangBanGiao;
    private XRTableCell xrTinhTrangBH;
    private ReportFooterBand ReportFooter;
    private XRLabel xrLabel3;
    private XRLabel xrlNguoiKy;
    private XRLabel xrThoiGian;
    private XRTableCell xrTableCell10;
    private XRTableCell xrEmail;
    private XRLabel xrl_ThoiGianBaoCao;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell9;
    private XRTableCell xrt_TenPhongBan;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rpwg_BaoCaoDanhSachNhanVienNghiViec()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }
    int STT = 1;
    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {

        xrSTT.Text = STT.ToString();
        STT++;
    }
    public void BindData(ReportFilter filter)
    {
        ReportController rpCtr = new ReportController();
        xrCompanyName.Text = rpCtr.GetCompanyName(filter.SessionDepartment);
        xrThoiGian.Text = rpCtr.GetFooterReport(filter.SessionDepartment, filter.ReportedDate);
        xrlNguoiKy.Text = rpCtr.GetHeadOfHRroom(filter.SessionDepartment,filter.Name1);
        if (SoftCore.Util.GetInstance().IsDateNull(filter.StartDate))
        {
            filter.StartDate = new DateTime(1900, 1, 1);
        }
        if (SoftCore.Util.GetInstance().IsDateNull(filter.EndDate))
        {
            filter.EndDate = DateTime.Now;
        }
        xrl_ThoiGianBaoCao.Text = string.Format(xrl_ThoiGianBaoCao.Text, CommonUtil.GetInstance().GetDateFormat(filter.StartDate.Value), CommonUtil.GetInstance().GetDateFormat(filter.EndDate.Value));
        if (!string.IsNullOrEmpty(filter.ReportTitle))
        {
            xrReportTitle.Text = filter.ReportTitle.ToUpper();
        }
        DataSource = DataHandler.GetInstance().ExecuteDataTable("report_DanhSachThoiViec", "@startMonth", "@endMonth", "@year", "@maboPhan", filter.StartMonth, filter.EndMonth, filter.Year, filter.SelectedDepartment);
        xrFullName.DataBindings.Add("Text", DataSource, "HO_TEN");
        //  xrDepartment.DataBindings.Add("Text", DataSource, "TEN_DONVI");
        xrEmail.DataBindings.Add("Text", DataSource, "EMAIL");
        xrNgayThoiViec.DataBindings.Add("Text", DataSource, "NgayNghi", "{0:dd/MM/yyyy}");
        xrLyDoNghi.DataBindings.Add("Text", DataSource, "TEN_LYDO_NGHI", "{0:dd/MM/yyyy}");
        xrTinhTrangBanGiao.DataBindings.Add("Text", DataSource, "BanGiao");
        xrQuyetDinhSo.DataBindings.Add("Text", DataSource, "SoQuyetDinh");
        xrTinhTrangBH.DataBindings.Add("Text", DataSource, "BaoHiem");

        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("TEN_DONVI", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        xrt_TenPhongBan.DataBindings.Add("Text", DataSource, "TEN_DONVI");
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        string resourceFileName = "rpwg_BaoCaoDanhSachNhanVienNghiViec.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrSTT = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrFullName = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrEmail = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrNgayThoiViec = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrLyDoNghi = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTinhTrangBanGiao = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrQuyetDinhSo = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTinhTrangBH = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrReportTitle = new DevExpress.XtraReports.UI.XRLabel();
        this.xrCompanyName = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_ThoiGianBaoCao = new DevExpress.XtraReports.UI.XRLabel();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
        this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
        this.xrThoiGian = new DevExpress.XtraReports.UI.XRLabel();
        this.xrlNguoiKy = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_TenPhongBan = new DevExpress.XtraReports.UI.XRTableCell();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
        this.Detail.HeightF = 25F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable2
        // 
        this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(1069F, 25F);
        this.xrTable2.StylePriority.UseBorders = false;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrSTT,
            this.xrFullName,
            this.xrEmail,
            this.xrNgayThoiViec,
            this.xrLyDoNghi,
            this.xrTinhTrangBanGiao,
            this.xrQuyetDinhSo,
            this.xrTinhTrangBH});
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrSTT
        // 
        this.xrSTT.Name = "xrSTT";
        this.xrSTT.StylePriority.UseTextAlignment = false;
        this.xrSTT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrSTT.Weight = 0.11522952144080202D;
        this.xrSTT.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
        // 
        // xrFullName
        // 
        this.xrFullName.Name = "xrFullName";
        this.xrFullName.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
        this.xrFullName.StylePriority.UsePadding = false;
        this.xrFullName.StylePriority.UseTextAlignment = false;
        this.xrFullName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrFullName.Weight = 0.40355253266788D;
        // 
        // xrEmail
        // 
        this.xrEmail.Name = "xrEmail";
        this.xrEmail.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
        this.xrEmail.StylePriority.UsePadding = false;
        this.xrEmail.StylePriority.UseTextAlignment = false;
        this.xrEmail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrEmail.Weight = 0.60175497565171687D;
        // 
        // xrNgayThoiViec
        // 
        this.xrNgayThoiViec.Name = "xrNgayThoiViec";
        this.xrNgayThoiViec.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
        this.xrNgayThoiViec.StylePriority.UsePadding = false;
        this.xrNgayThoiViec.StylePriority.UseTextAlignment = false;
        this.xrNgayThoiViec.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrNgayThoiViec.Weight = 0.297006493488571D;
        // 
        // xrLyDoNghi
        // 
        this.xrLyDoNghi.Name = "xrLyDoNghi";
        this.xrLyDoNghi.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
        this.xrLyDoNghi.StylePriority.UsePadding = false;
        this.xrLyDoNghi.StylePriority.UseTextAlignment = false;
        this.xrLyDoNghi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrLyDoNghi.Weight = 0.487709841572044D;
        // 
        // xrTinhTrangBanGiao
        // 
        this.xrTinhTrangBanGiao.Name = "xrTinhTrangBanGiao";
        this.xrTinhTrangBanGiao.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
        this.xrTinhTrangBanGiao.StylePriority.UsePadding = false;
        this.xrTinhTrangBanGiao.StylePriority.UseTextAlignment = false;
        this.xrTinhTrangBanGiao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTinhTrangBanGiao.Weight = 0.401458998056023D;
        // 
        // xrQuyetDinhSo
        // 
        this.xrQuyetDinhSo.Name = "xrQuyetDinhSo";
        this.xrQuyetDinhSo.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
        this.xrQuyetDinhSo.StylePriority.UsePadding = false;
        this.xrQuyetDinhSo.StylePriority.UseTextAlignment = false;
        this.xrQuyetDinhSo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrQuyetDinhSo.Weight = 0.30425654383637557D;
        // 
        // xrTinhTrangBH
        // 
        this.xrTinhTrangBH.Name = "xrTinhTrangBH";
        this.xrTinhTrangBH.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
        this.xrTinhTrangBH.StylePriority.UsePadding = false;
        this.xrTinhTrangBH.StylePriority.UseTextAlignment = false;
        this.xrTinhTrangBH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTinhTrangBH.Weight = 0.38903109328658758D;
        // 
        // TopMargin
        // 
        this.TopMargin.HeightF = 61F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BottomMargin
        // 
        this.BottomMargin.HeightF = 0F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrReportTitle,
            this.xrCompanyName,
            this.xrl_ThoiGianBaoCao});
        this.ReportHeader.HeightF = 111F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // xrReportTitle
        // 
        this.xrReportTitle.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
        this.xrReportTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 57.20835F);
        this.xrReportTitle.Name = "xrReportTitle";
        this.xrReportTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrReportTitle.SizeF = new System.Drawing.SizeF(1069F, 23F);
        this.xrReportTitle.StylePriority.UseFont = false;
        this.xrReportTitle.StylePriority.UseTextAlignment = false;
        this.xrReportTitle.Text = "BÁO CÁO NGHỈ VIỆC/ THÔI VIỆC";
        this.xrReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrCompanyName
        // 
        this.xrCompanyName.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
        this.xrCompanyName.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
        this.xrCompanyName.Name = "xrCompanyName";
        this.xrCompanyName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrCompanyName.SizeF = new System.Drawing.SizeF(351.0417F, 23F);
        this.xrCompanyName.StylePriority.UseFont = false;
        this.xrCompanyName.StylePriority.UseTextAlignment = false;
        this.xrCompanyName.Text = "PHÒNG HÀNH CHÍNH NHÂN SỰ";
        this.xrCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_ThoiGianBaoCao
        // 
        this.xrl_ThoiGianBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
        this.xrl_ThoiGianBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 80.20834F);
        this.xrl_ThoiGianBaoCao.Name = "xrl_ThoiGianBaoCao";
        this.xrl_ThoiGianBaoCao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ThoiGianBaoCao.SizeF = new System.Drawing.SizeF(1059F, 23F);
        this.xrl_ThoiGianBaoCao.StylePriority.UseFont = false;
        this.xrl_ThoiGianBaoCao.StylePriority.UseTextAlignment = false;
        this.xrl_ThoiGianBaoCao.Text = "Từ ngày {0} đến ngày {1}";
        this.xrl_ThoiGianBaoCao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.PageHeader.HeightF = 28F;
        this.PageHeader.Name = "PageHeader";
        // 
        // xrTable1
        // 
        this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                    | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(1069F, 27.5F);
        this.xrTable1.StylePriority.UseBorders = false;
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell4,
            this.xrTableCell10,
            this.xrTableCell5,
            this.xrTableCell3,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.Text = "STT";
        this.xrTableCell1.Weight = 0.11522950116237446D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Text = "Họ và tên";
        this.xrTableCell4.Weight = 0.40355256579133675D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.Text = "Email";
        this.xrTableCell10.Weight = 0.60175504723861628D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.Text = "Ngày nghỉ việc";
        this.xrTableCell5.Weight = 0.297006495952428D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Text = "Lý do nghỉ";
        this.xrTableCell3.Weight = 0.48770975296205249D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Text = "Tình trạng bàn giao";
        this.xrTableCell6.Weight = 0.40145883104813718D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Text = "Quyết định số";
        this.xrTableCell7.Weight = 0.30425654989792406D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.Multiline = true;
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.Text = "Tình trạng \r\nBHXH/...";
        this.xrTableCell8.Weight = 0.38903125594713034D;
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
        this.PageFooter.HeightF = 90F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrPageInfo1
        // 
        this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrPageInfo1.Format = "Trang {0} của {1}";
        this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(942.9586F, 25F);
        this.xrPageInfo1.Name = "xrPageInfo1";
        this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrPageInfo1.SizeF = new System.Drawing.SizeF(126.0414F, 23.00001F);
        this.xrPageInfo1.StylePriority.UseFont = false;
        this.xrPageInfo1.StylePriority.UseTextAlignment = false;
        this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        // 
        // ReportFooter
        // 
        this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrThoiGian,
            this.xrlNguoiKy,
            this.xrLabel3});
        this.ReportFooter.HeightF = 164F;
        this.ReportFooter.Name = "ReportFooter";
        // 
        // xrThoiGian
        // 
        this.xrThoiGian.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
        this.xrThoiGian.LocationFloat = new DevExpress.Utils.PointFloat(713.5417F, 6.791687F);
        this.xrThoiGian.Name = "xrThoiGian";
        this.xrThoiGian.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrThoiGian.SizeF = new System.Drawing.SizeF(355.4583F, 23F);
        this.xrThoiGian.StylePriority.UseFont = false;
        this.xrThoiGian.StylePriority.UseTextAlignment = false;
        this.xrThoiGian.Text = "Hà Nội, ngày....";
        this.xrThoiGian.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrlNguoiKy
        // 
        this.xrlNguoiKy.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
        this.xrlNguoiKy.LocationFloat = new DevExpress.Utils.PointFloat(713.5417F, 131F);
        this.xrlNguoiKy.Name = "xrlNguoiKy";
        this.xrlNguoiKy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrlNguoiKy.SizeF = new System.Drawing.SizeF(355.4583F, 23F);
        this.xrlNguoiKy.StylePriority.UseFont = false;
        this.xrlNguoiKy.StylePriority.UseTextAlignment = false;
        this.xrlNguoiKy.Text = "Mai Thị Nga";
        this.xrlNguoiKy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel3
        // 
        this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(713.5417F, 29.79167F);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(355.4583F, 23F);
        this.xrLabel3.StylePriority.UseFont = false;
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.Text = "PHÒNG HCNS";
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
        this.GroupHeader1.HeightF = 25.41666F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // xrTable3
        // 
        this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(1069F, 25.41666F);
        this.xrTable3.StylePriority.UseBorders = false;
        this.xrTable3.StylePriority.UseTextAlignment = false;
        this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrt_TenPhongBan});
        this.xrTableRow3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.StylePriority.UseFont = false;
        this.xrTableRow3.StylePriority.UseTextAlignment = false;
        this.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.StylePriority.UseBorders = false;
        this.xrTableCell9.Weight = 0.093749659522817774D;
        // 
        // xrt_TenPhongBan
        // 
        this.xrt_TenPhongBan.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrt_TenPhongBan.Name = "xrt_TenPhongBan";
        this.xrt_TenPhongBan.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100F);
        this.xrt_TenPhongBan.StylePriority.UseBorders = false;
        this.xrt_TenPhongBan.StylePriority.UsePadding = false;
        this.xrt_TenPhongBan.StylePriority.UseTextAlignment = false;
        this.xrt_TenPhongBan.Text = "Phòng lập trình";
        this.xrt_TenPhongBan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrt_TenPhongBan.Weight = 10.73625507595513D;
        // 
        // rpwg_BaoCaoDanhSachNhanVienNghiViec
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.PageFooter,
            this.ReportFooter,
            this.GroupHeader1});
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(52, 48, 61, 0);
        this.PageHeight = 827;
        this.PageWidth = 1169;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        this.Version = "10.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
