using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DAL;
using System.Collections.Generic;
using System.Data;
using DataController;

/// <summary>
/// Summary description for rp_SinhNhatNhanVien
/// </summary>
public class rp_SinhNhatNhanVien : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private XRLabel xrl_TitleBC;
    private PageHeaderBand PageHeader;
    private ReportFooterBand ReportFooter;
    private XRLabel xrl_ten1;
    private XRLabel xrl_ten2;
    private XRLabel xrl_ten3;
    private XRLabel xrtngayketxuat;
    private XRLabel xrl_footer2;
    private XRLabel xrl_footer3;
    private XRLabel xrl_footer1;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell10;
    private XRTableCell xrt_TenPhongBan;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrt_STT;
    private XRTableCell xrt_macb;
    private XRTableCell xrtHoTen;
    private XRTableCell xrtNgaySinh;
    private XRTableCell xrtGioiTinh;
    private XRTableCell xrtDienThoai;
    private XRTableCell xrtDiaChi;
    private XRLabel xrl_TenCongTy;
    /// <summary>
    /// Nguyễn Văn Khởi
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rp_SinhNhatNhanVien()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }

    int STT = 1;
    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        xrt_STT.Text = STT.ToString();
        STT++;
    }
    public void BindData(ReportFilter filter)
    {
        try
        {
            if (string.IsNullOrEmpty(filter.Gender))
            {
                filter.Gender = "";
            }
            if (filter.MaxSeniority == 0)
                filter.MaxSeniority = 1000;
            xrtngayketxuat.Text = new ReportController().GetFooterReport(filter.SessionDepartment, filter.ReportedDate);
            xrl_TenCongTy.Text = ReportController.GetInstance().GetCompanyName(filter.SessionDepartment);
            DataTable table = DataHandler.GetInstance().ExecuteDataTable("report_BirthdayOfEmployee", "@MaBoPhan", "@Gender", "@TinhTrang", "@MinSeniority", "@MaxSeniority", "@Month", "@WhereClause", filter.SelectedDepartment, filter.Gender, filter.WorkingStatus, filter.MinSeniority, filter.MaxSeniority, filter.StartMonth, filter.WhereClause);
            DataSource = table;
            xrtHoTen.DataBindings.Add("Text", DataSource, "HO_TEN");
            xrt_macb.DataBindings.Add("Text", DataSource, "MA_CB");
            xrtNgaySinh.DataBindings.Add("Text", DataSource, "NGAY_SINH", "{0:dd/MM/yyyy}");
            xrtGioiTinh.DataBindings.Add("Text", DataSource, "TEN_GIOITINH");
            xrtDienThoai.DataBindings.Add("Text", DataSource, "DI_DONG");
            xrtDiaChi.DataBindings.Add("Text", DataSource, "DIA_CHI_LH");

            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("MA_DONVI", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            xrt_TenPhongBan.DataBindings.Add("Text", DataSource, "TEN_PHONG");

            ReportController rpCtr = new ReportController();
            if (!string.IsNullOrEmpty(filter.Title1))
            {
                xrl_footer1.Text = filter.Title1;
            }
            else
            {
                xrl_footer1.Text = rpCtr.GetTitleOfSignature(xrl_footer1.Text, filter.Title1);
            }
            if (!string.IsNullOrEmpty(filter.Title2))
            {
                xrl_footer2.Text = filter.Title2;
            }
            else
            {
                xrl_footer2.Text = rpCtr.GetTitleOfSignature(xrl_footer2.Text, filter.Title2);
            }
            if (!string.IsNullOrEmpty(filter.Title3))
            {
                xrl_footer3.Text = filter.Title3;
            }
            else
            {
                xrl_footer3.Text = rpCtr.GetTitleOfSignature(xrl_footer3.Text, filter.Title3);
            }
            if (!string.IsNullOrEmpty(filter.Name1))
            {
                xrl_ten1.Text = filter.Name1;
            }
            else
            {
                xrl_ten1.Text = rpCtr.GetCreatedReporterName(filter.SessionDepartment, filter.Reporter);
            }
            if (!string.IsNullOrEmpty(filter.Name2))
            {
                xrl_ten2.Text = filter.Name2;
            }
            else
            {
                xrl_ten2.Text = rpCtr.GetHeadOfHRroom(filter.SessionDepartment, filter.Name2);
            }
            if (!string.IsNullOrEmpty(filter.Name3))
            {
                xrl_ten3.Text = filter.Name3;
            }
            else
            {
                xrl_ten3.Text = rpCtr.GetDirectorName(filter.SessionDepartment, filter.Name3);
            }

            if (!string.IsNullOrEmpty(filter.ReportTitle))
            {
                xrl_TitleBC.Text = filter.ReportTitle;
            }
            else
            {
                xrl_TitleBC.Text += " THÁNG " + filter.StartMonth;
            }
        }
        catch (Exception ex)
        {
            ExtMessage.Dialog.Alert("Có lỗi xảy ra: " + ex.Message);
        }
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
        string resourceFileName = "rp_SinhNhatNhanVien.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrt_STT = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_macb = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrtHoTen = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrtNgaySinh = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrtGioiTinh = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrtDienThoai = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrtDiaChi = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrl_TitleBC = new DevExpress.XtraReports.UI.XRLabel();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
        this.xrl_ten1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_ten2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_ten3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrtngayketxuat = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_footer2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_footer3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_footer1 = new DevExpress.XtraReports.UI.XRLabel();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_TenPhongBan = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrl_TenCongTy = new DevExpress.XtraReports.UI.XRLabel();
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
        this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(776.9993F, 25F);
        this.xrTable2.StylePriority.UseBorders = false;
        this.xrTable2.StylePriority.UseFont = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                    | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrt_STT,
            this.xrt_macb,
            this.xrtHoTen,
            this.xrtNgaySinh,
            this.xrtGioiTinh,
            this.xrtDienThoai,
            this.xrtDiaChi});
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.StylePriority.UseBorders = false;
        this.xrTableRow2.Weight = 1D;
        // 
        // xrt_STT
        // 
        this.xrt_STT.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrt_STT.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.xrt_STT.Name = "xrt_STT";
        this.xrt_STT.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrt_STT.StylePriority.UseBorders = false;
        this.xrt_STT.StylePriority.UseFont = false;
        this.xrt_STT.StylePriority.UsePadding = false;
        this.xrt_STT.StylePriority.UseTextAlignment = false;
        this.xrt_STT.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrt_STT.Weight = 0.40056802944779607D;
        this.xrt_STT.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
        // 
        // xrt_macb
        // 
        this.xrt_macb.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrt_macb.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.xrt_macb.Name = "xrt_macb";
        this.xrt_macb.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrt_macb.StylePriority.UseBorders = false;
        this.xrt_macb.StylePriority.UseFont = false;
        this.xrt_macb.StylePriority.UsePadding = false;
        this.xrt_macb.StylePriority.UseTextAlignment = false;
        this.xrt_macb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrt_macb.Weight = 0.72095917452654712D;
        // 
        // xrtHoTen
        // 
        this.xrtHoTen.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrtHoTen.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.xrtHoTen.Name = "xrtHoTen";
        this.xrtHoTen.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrtHoTen.StylePriority.UseBorders = false;
        this.xrtHoTen.StylePriority.UseFont = false;
        this.xrtHoTen.StylePriority.UsePadding = false;
        this.xrtHoTen.StylePriority.UseTextAlignment = false;
        this.xrtHoTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrtHoTen.Weight = 1.5795452449555081D;
        // 
        // xrtNgaySinh
        // 
        this.xrtNgaySinh.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrtNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.xrtNgaySinh.Name = "xrtNgaySinh";
        this.xrtNgaySinh.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrtNgaySinh.StylePriority.UseBorders = false;
        this.xrtNgaySinh.StylePriority.UseFont = false;
        this.xrtNgaySinh.StylePriority.UsePadding = false;
        this.xrtNgaySinh.StylePriority.UseTextAlignment = false;
        this.xrtNgaySinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrtNgaySinh.Weight = 0.84438150113376986D;
        // 
        // xrtGioiTinh
        // 
        this.xrtGioiTinh.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrtGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.xrtGioiTinh.Name = "xrtGioiTinh";
        this.xrtGioiTinh.StylePriority.UseBorders = false;
        this.xrtGioiTinh.StylePriority.UseFont = false;
        this.xrtGioiTinh.StylePriority.UseTextAlignment = false;
        this.xrtGioiTinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrtGioiTinh.Weight = 0.71444314122820818D;
        // 
        // xrtDienThoai
        // 
        this.xrtDienThoai.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrtDienThoai.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.xrtDienThoai.Name = "xrtDienThoai";
        this.xrtDienThoai.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrtDienThoai.StylePriority.UseBorders = false;
        this.xrtDienThoai.StylePriority.UseFont = false;
        this.xrtDienThoai.StylePriority.UsePadding = false;
        this.xrtDienThoai.StylePriority.UseTextAlignment = false;
        this.xrtDienThoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrtDienThoai.Weight = 1.0102012493232684D;
        // 
        // xrtDiaChi
        // 
        this.xrtDiaChi.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.xrtDiaChi.Name = "xrtDiaChi";
        this.xrtDiaChi.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrtDiaChi.StylePriority.UseBorders = false;
        this.xrtDiaChi.StylePriority.UseFont = false;
        this.xrtDiaChi.StylePriority.UsePadding = false;
        this.xrtDiaChi.StylePriority.UseTextAlignment = false;
        this.xrtDiaChi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrtDiaChi.Weight = 2.4998953531952668D;
        // 
        // TopMargin
        // 
        this.TopMargin.HeightF = 44F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BottomMargin
        // 
        this.BottomMargin.HeightF = 48F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrl_TenCongTy,
            this.xrl_TitleBC});
        this.ReportHeader.HeightF = 121F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // xrl_TitleBC
        // 
        this.xrl_TitleBC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_TitleBC.LocationFloat = new DevExpress.Utils.PointFloat(0F, 87.99998F);
        this.xrl_TitleBC.Name = "xrl_TitleBC";
        this.xrl_TitleBC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_TitleBC.SizeF = new System.Drawing.SizeF(776.9993F, 23.00001F);
        this.xrl_TitleBC.StylePriority.UseFont = false;
        this.xrl_TitleBC.StylePriority.UseTextAlignment = false;
        this.xrl_TitleBC.Text = "DANH SÁCH NHÂN VIÊN SINH NHẬT";
        this.xrl_TitleBC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.PageHeader.HeightF = 32.29166F;
        this.PageHeader.Name = "PageHeader";
        // 
        // xrTable1
        // 
        this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(777F, 32.29166F);
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                    | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell7,
            this.xrTableCell4,
            this.xrTableCell3,
            this.xrTableCell5,
            this.xrTableCell6});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.StylePriority.UseBorders = false;
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.Text = "STT";
        this.xrTableCell1.Weight = 0.4130858994427955D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.Text = "Mã cán bộ";
        this.xrTableCell2.Weight = 0.74348945254694532D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Text = "Họ tên";
        this.xrTableCell7.Weight = 1.6289064787672134D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Text = "Ngày sinh";
        this.xrTableCell4.Weight = 0.87076836713048045D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Text = "Giới tính";
        this.xrTableCell3.Weight = 0.73677036421400577D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.Text = "Số điện thoại";
        this.xrTableCell5.Weight = 1.0417699780675109D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Text = "Địa chỉ";
        this.xrTableCell6.Weight = 2.5780254297309968D;
        // 
        // ReportFooter
        // 
        this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrl_ten1,
            this.xrl_ten2,
            this.xrl_ten3,
            this.xrtngayketxuat,
            this.xrl_footer2,
            this.xrl_footer3,
            this.xrl_footer1});
        this.ReportFooter.HeightF = 220F;
        this.ReportFooter.Name = "ReportFooter";
        // 
        // xrl_ten1
        // 
        this.xrl_ten1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_ten1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 151.0417F);
        this.xrl_ten1.Name = "xrl_ten1";
        this.xrl_ten1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ten1.SizeF = new System.Drawing.SizeF(209.375F, 23F);
        this.xrl_ten1.StylePriority.UseFont = false;
        this.xrl_ten1.StylePriority.UseTextAlignment = false;
        this.xrl_ten1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_ten2
        // 
        this.xrl_ten2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_ten2.LocationFloat = new DevExpress.Utils.PointFloat(224.2081F, 151.0417F);
        this.xrl_ten2.Name = "xrl_ten2";
        this.xrl_ten2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ten2.SizeF = new System.Drawing.SizeF(261.3069F, 23F);
        this.xrl_ten2.StylePriority.UseFont = false;
        this.xrl_ten2.StylePriority.UseTextAlignment = false;
        this.xrl_ten2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_ten3
        // 
        this.xrl_ten3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_ten3.LocationFloat = new DevExpress.Utils.PointFloat(499.4579F, 151.0417F);
        this.xrl_ten3.Name = "xrl_ten3";
        this.xrl_ten3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ten3.SizeF = new System.Drawing.SizeF(277.5413F, 23F);
        this.xrl_ten3.StylePriority.UseFont = false;
        this.xrl_ten3.StylePriority.UseTextAlignment = false;
        this.xrl_ten3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrtngayketxuat
        // 
        this.xrtngayketxuat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
        this.xrtngayketxuat.LocationFloat = new DevExpress.Utils.PointFloat(493.4578F, 23.54164F);
        this.xrtngayketxuat.Name = "xrtngayketxuat";
        this.xrtngayketxuat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrtngayketxuat.SizeF = new System.Drawing.SizeF(283.5415F, 23F);
        this.xrtngayketxuat.StylePriority.UseFont = false;
        this.xrtngayketxuat.StylePriority.UseTextAlignment = false;
        this.xrtngayketxuat.Text = "Hà Nội, ngày 15 tháng 4 năm 2013";
        this.xrtngayketxuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrl_footer2
        // 
        this.xrl_footer2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_footer2.LocationFloat = new DevExpress.Utils.PointFloat(224.2081F, 46.54166F);
        this.xrl_footer2.Name = "xrl_footer2";
        this.xrl_footer2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_footer2.SizeF = new System.Drawing.SizeF(261.3069F, 23F);
        this.xrl_footer2.StylePriority.UseFont = false;
        this.xrl_footer2.StylePriority.UseTextAlignment = false;
        this.xrl_footer2.Text = "PHÒNG HCNS";
        this.xrl_footer2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_footer3
        // 
        this.xrl_footer3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_footer3.LocationFloat = new DevExpress.Utils.PointFloat(499.4579F, 46.54166F);
        this.xrl_footer3.Name = "xrl_footer3";
        this.xrl_footer3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_footer3.SizeF = new System.Drawing.SizeF(277.5417F, 23F);
        this.xrl_footer3.StylePriority.UseFont = false;
        this.xrl_footer3.StylePriority.UseTextAlignment = false;
        this.xrl_footer3.Text = "TỔNG GIÁM ĐỐC";
        this.xrl_footer3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_footer1
        // 
        this.xrl_footer1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_footer1.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 46.54166F);
        this.xrl_footer1.Name = "xrl_footer1";
        this.xrl_footer1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_footer1.SizeF = new System.Drawing.SizeF(209.375F, 23F);
        this.xrl_footer1.StylePriority.UseFont = false;
        this.xrl_footer1.StylePriority.UseTextAlignment = false;
        this.xrl_footer1.Text = "NGƯỜI LẬP";
        this.xrl_footer1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
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
        this.xrTable3.SizeF = new System.Drawing.SizeF(777F, 25.41666F);
        this.xrTable3.StylePriority.UseBorders = false;
        this.xrTable3.StylePriority.UseTextAlignment = false;
        this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrt_TenPhongBan});
        this.xrTableRow3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.StylePriority.UseFont = false;
        this.xrTableRow3.StylePriority.UseTextAlignment = false;
        this.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.StylePriority.UseBorders = false;
        this.xrTableCell10.Weight = 0.093749659522817774D;
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
        this.xrt_TenPhongBan.Weight = 10.424898057374074D;
        // 
        // xrl_TenCongTy
        // 
        this.xrl_TenCongTy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_TenCongTy.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23F);
        this.xrl_TenCongTy.Name = "xrl_TenCongTy";
        this.xrl_TenCongTy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_TenCongTy.SizeF = new System.Drawing.SizeF(485.5154F, 23F);
        this.xrl_TenCongTy.StylePriority.UseFont = false;
        this.xrl_TenCongTy.StylePriority.UseTextAlignment = false;
        this.xrl_TenCongTy.Text = "CÔNG TY CỔ PHẦN CÔNG NGHỆ DTH VÀ GIẢI PHÁP SỐ";
        this.xrl_TenCongTy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // rp_SinhNhatNhanVien
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.GroupHeader1});
        this.Margins = new System.Drawing.Printing.Margins(25, 25, 44, 48);
        this.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.PageHeight = 1169;
        this.PageWidth = 827;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        this.Version = "10.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
