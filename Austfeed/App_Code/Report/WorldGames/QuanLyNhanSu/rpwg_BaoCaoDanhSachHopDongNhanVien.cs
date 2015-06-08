using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DataController;

/// <summary>
/// Summary description for rp_DienBienLuongCopy
/// </summary>
public class rpwg_BaoCaoDanhSachHopDongNhanVien : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private PageHeaderBand PageHeader;
    private ReportFooterBand ReportFooter;
    private PageFooterBand PageFooter;
    private XRLabel xrl_TitleBC;
    private XRLabel xrl_TenCongTy;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell12;
    private XRPageInfo xrPageInfo1;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrt_sttt;
    private XRTableCell xrt_sohopdong;
    private XRTableCell xrt_loaihopdong;
    private XRTableCell xrt_congviec;
    private XRTableCell xrt_ngayky;
    private XRTableCell xrt_ngayhethan;
    private XRTableCell xrt_tinhtrang;
    private XRLabel xrl_phongHCNS;
    private XRLabel xrl_chukyGiamDoc;
    private XRLabel xrtngayketxuat;
    private XRLabel xrl_titleHCNS;
    private XRLabel xrl_TongGiamDoc;
    private XRLabel xrl_HoTen;
    private XRLabel xrl_PhongBan;
    private XRLabel xrl_ViTriCongViec;
    private XRLabel xrl_ChucVu;
    private XRTableCell xrTableCell5;
    private XRLabel xr_TuyenChinhThuc;
    private XRLabel xrThamNien;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLabel3;
    private XRLabel xrLabel4;
    private XRLabel xrLabel5;
    private XRLabel xrLabel6;
    private XRTableCell xrTableCell6;
    private XRTableCell xrt_ngayhieuluc;
    private XRLabel xrl_chinhanh;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rpwg_BaoCaoDanhSachHopDongNhanVien()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
    }
    int STT = 1;
    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        xrt_sttt.Text = STT.ToString();
        STT++;
    }
    public void BindData(ReportFilter filter)
    {
        ReportController rpCtr = new ReportController();
        xrl_TenCongTy.Text = rpCtr.GetCompanyName(filter.SessionDepartment);
        xrtngayketxuat.Text = "dfdfdfdfdfdf";// rpCtr.GetFooterReport(filter.SessionDepartment, filter.ReportedDate);
        xrl_titleHCNS.Text = rpCtr.GetTitleOfSignature(xrl_titleHCNS.Text, filter.Title2);
        xrl_TongGiamDoc.Text = rpCtr.GetTitleOfSignature(xrl_TongGiamDoc.Text, filter.Title3);
        xrl_phongHCNS.Text = rpCtr.GetHeadOfHRroom(filter.SessionDepartment, filter.Name2);
        xrl_chukyGiamDoc.Text = rpCtr.GetDirectorName(filter.SessionDepartment, filter.Name3);
        if (!string.IsNullOrEmpty(filter.ReportTitle))
        {
            xrl_TitleBC.Text = filter.ReportTitle;
        }
        //    xrl_ngayBC.Text = rpCtr.GetFromDateToDate(filter.StartDate, filter.EndDate);

        DataTable tableHoSo = DataHandler.GetInstance().ExecuteDataTable("report_ThongTinHoSo", "@prKeyHoSo", filter.EmployeeCode);
        if (tableHoSo.Rows.Count > 0)
        {
            xrl_HoTen.Text += tableHoSo.Rows[0]["HO_TEN"].ToString();
            xrl_PhongBan.Text += tableHoSo.Rows[0]["TEN_DONVI"].ToString();
            xrl_ChucVu.Text += tableHoSo.Rows[0]["TEN_CHUCVU"].ToString();
            xrl_ViTriCongViec.Text += tableHoSo.Rows[0]["TEN_CONGVIEC"].ToString();
            xrThamNien.Text += tableHoSo.Rows[0]["ThamNien"].ToString();
            if (!string.IsNullOrEmpty(tableHoSo.Rows[0]["NGAY_TUYEN_CHINHTHUC"].ToString()))
            {
                xr_TuyenChinhThuc.Text += tableHoSo.Rows[0]["NGAY_TUYEN_CHINHTHUC"].ToString().Remove(tableHoSo.Rows[0]["NGAY_TUYEN_CHINHTHUC"].ToString().IndexOf(' '));
            }
            xrl_chinhanh.DataBindings.Add("Text", DataSource, "DIA_CHI");
        } 
        DataTable dt = DataController.DataHandler.GetInstance().ExecuteDataTable("report_wg_BaoCaoDanhSachHopDongCuaNhanVien", "@prkeyHoSo", filter.EmployeeCode);
        if (dt.Rows.Count > 0)
        {
            DataSource = dt;
            xrt_sohopdong.DataBindings.Add("Text", DataSource, "SO_HDONG");
            xrt_loaihopdong.DataBindings.Add("Text", DataSource, "TEN_LOAI_HDONG");
            xrt_congviec.DataBindings.Add("Text", DataSource, "TEN_CONGVIEC");
            xrt_ngayky.DataBindings.Add("Text", DataSource, "NGAY_HDONG", "{0:dd/MM/yyyy}");
            xrt_ngayhieuluc.DataBindings.Add("Text", DataSource, "NgayCoHieuLuc", "{0:dd/MM/yyyy}");
            xrt_ngayhethan.DataBindings.Add("Text", DataSource, "NGAYKT_HDONG", "{0:dd/MM/yyyy}");
            xrt_tinhtrang.DataBindings.Add("Text", DataSource, "TEN_TT_HDONG");
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
        string resourceFileName = "rpwg_BaoCaoDanhSachHopDongNhanVien.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrt_sttt = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_sohopdong = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_loaihopdong = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_congviec = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_ngayky = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_ngayhieuluc = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_ngayhethan = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_tinhtrang = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrl_chinhanh = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrThamNien = new DevExpress.XtraReports.UI.XRLabel();
        this.xr_TuyenChinhThuc = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_ViTriCongViec = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_ChucVu = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_PhongBan = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_HoTen = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_TitleBC = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_TenCongTy = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
        this.xrl_phongHCNS = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_chukyGiamDoc = new DevExpress.XtraReports.UI.XRLabel();
        this.xrtngayketxuat = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_titleHCNS = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_TongGiamDoc = new DevExpress.XtraReports.UI.XRLabel();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
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
        this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 10F);
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(1044.958F, 25F);
        this.xrTable2.StylePriority.UseBorders = false;
        this.xrTable2.StylePriority.UseFont = false;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrt_sttt,
            this.xrt_sohopdong,
            this.xrt_loaihopdong,
            this.xrt_congviec,
            this.xrt_ngayky,
            this.xrt_ngayhieuluc,
            this.xrt_ngayhethan,
            this.xrt_tinhtrang});
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrt_sttt
        // 
        this.xrt_sttt.Name = "xrt_sttt";
        this.xrt_sttt.StylePriority.UseTextAlignment = false;
        this.xrt_sttt.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrt_sttt.Weight = 0.096422348839708683D;
        this.xrt_sttt.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
        // 
        // xrt_sohopdong
        // 
        this.xrt_sohopdong.Name = "xrt_sohopdong";
        this.xrt_sohopdong.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrt_sohopdong.SnapLineMargin = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrt_sohopdong.StylePriority.UsePadding = false;
        this.xrt_sohopdong.StylePriority.UseTextAlignment = false;
        this.xrt_sohopdong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrt_sohopdong.Weight = 0.2954840395505004D;
        // 
        // xrt_loaihopdong
        // 
        this.xrt_loaihopdong.Name = "xrt_loaihopdong";
        this.xrt_loaihopdong.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrt_loaihopdong.StylePriority.UsePadding = false;
        this.xrt_loaihopdong.StylePriority.UseTextAlignment = false;
        this.xrt_loaihopdong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrt_loaihopdong.Weight = 0.6254364431133298D;
        // 
        // xrt_congviec
        // 
        this.xrt_congviec.Name = "xrt_congviec";
        this.xrt_congviec.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrt_congviec.StylePriority.UsePadding = false;
        this.xrt_congviec.StylePriority.UseTextAlignment = false;
        this.xrt_congviec.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrt_congviec.Weight = 0.456369945373317D;
        // 
        // xrt_ngayky
        // 
        this.xrt_ngayky.Name = "xrt_ngayky";
        this.xrt_ngayky.StylePriority.UseTextAlignment = false;
        this.xrt_ngayky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrt_ngayky.Weight = 0.24094738800203636D;
        // 
        // xrt_ngayhieuluc
        // 
        this.xrt_ngayhieuluc.Name = "xrt_ngayhieuluc";
        this.xrt_ngayhieuluc.StylePriority.UseTextAlignment = false;
        this.xrt_ngayhieuluc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrt_ngayhieuluc.Weight = 0.24093636913793445D;
        // 
        // xrt_ngayhethan
        // 
        this.xrt_ngayhethan.Name = "xrt_ngayhethan";
        this.xrt_ngayhethan.StylePriority.UseTextAlignment = false;
        this.xrt_ngayhethan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrt_ngayhethan.Weight = 0.23548234874855148D;
        // 
        // xrt_tinhtrang
        // 
        this.xrt_tinhtrang.Name = "xrt_tinhtrang";
        this.xrt_tinhtrang.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
        this.xrt_tinhtrang.StylePriority.UsePadding = false;
        this.xrt_tinhtrang.StylePriority.UseTextAlignment = false;
        this.xrt_tinhtrang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrt_tinhtrang.Weight = 0.54441424295042706D;
        // 
        // TopMargin
        // 
        this.TopMargin.HeightF = 50F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BottomMargin
        // 
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrl_chinhanh,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel1,
            this.xrThamNien,
            this.xr_TuyenChinhThuc,
            this.xrl_ViTriCongViec,
            this.xrl_ChucVu,
            this.xrl_PhongBan,
            this.xrl_HoTen,
            this.xrl_TitleBC,
            this.xrl_TenCongTy,
            this.xrLabel2});
        this.ReportHeader.HeightF = 170F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // xrl_chinhanh
        // 
        this.xrl_chinhanh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
        this.xrl_chinhanh.LocationFloat = new DevExpress.Utils.PointFloat(0F, 31.87501F);
        this.xrl_chinhanh.Name = "xrl_chinhanh";
        this.xrl_chinhanh.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_chinhanh.SizeF = new System.Drawing.SizeF(499.3446F, 23F);
        this.xrl_chinhanh.StylePriority.UseFont = false;
        this.xrl_chinhanh.StylePriority.UseTextAlignment = false;
        this.xrl_chinhanh.Text = "Chi nhánh : ";
        this.xrl_chinhanh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel6
        // 
        this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(670.4173F, 137.4167F);
        this.xrLabel6.Name = "xrLabel6";
        this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel6.SizeF = new System.Drawing.SizeF(156.1577F, 23F);
        this.xrLabel6.StylePriority.UseFont = false;
        this.xrLabel6.StylePriority.UseTextAlignment = false;
        this.xrLabel6.Text = "Thâm niên :";
        this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel5
        // 
        this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(670.4172F, 114.4167F);
        this.xrLabel5.Name = "xrLabel5";
        this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel5.SizeF = new System.Drawing.SizeF(156.1578F, 22.99998F);
        this.xrLabel5.StylePriority.UseFont = false;
        this.xrLabel5.StylePriority.UseTextAlignment = false;
        this.xrLabel5.Text = "Ngày tuyển chính thức :";
        this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel4
        // 
        this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(314.3752F, 137.4167F);
        this.xrLabel4.Name = "xrLabel4";
        this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel4.SizeF = new System.Drawing.SizeF(114.5833F, 23F);
        this.xrLabel4.StylePriority.UseFont = false;
        this.xrLabel4.StylePriority.UseTextAlignment = false;
        this.xrLabel4.Text = "Vị trí công việc :";
        this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel3
        // 
        this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(314.3752F, 114.4167F);
        this.xrLabel3.Name = "xrLabel3";
        this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel3.SizeF = new System.Drawing.SizeF(114.5832F, 23F);
        this.xrLabel3.StylePriority.UseFont = false;
        this.xrLabel3.StylePriority.UseTextAlignment = false;
        this.xrLabel3.Text = "Phòng ban :";
        this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 114.4167F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(80.20834F, 23F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "Họ tên : ";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrThamNien
        // 
        this.xrThamNien.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrThamNien.LocationFloat = new DevExpress.Utils.PointFloat(826.5751F, 137.4167F);
        this.xrThamNien.Name = "xrThamNien";
        this.xrThamNien.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrThamNien.SizeF = new System.Drawing.SizeF(218.3829F, 23F);
        this.xrThamNien.StylePriority.UseFont = false;
        this.xrThamNien.StylePriority.UseTextAlignment = false;
        this.xrThamNien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xr_TuyenChinhThuc
        // 
        this.xr_TuyenChinhThuc.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xr_TuyenChinhThuc.LocationFloat = new DevExpress.Utils.PointFloat(826.5751F, 114.4167F);
        this.xr_TuyenChinhThuc.Name = "xr_TuyenChinhThuc";
        this.xr_TuyenChinhThuc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xr_TuyenChinhThuc.SizeF = new System.Drawing.SizeF(218.3829F, 23F);
        this.xr_TuyenChinhThuc.StylePriority.UseFont = false;
        this.xr_TuyenChinhThuc.StylePriority.UseTextAlignment = false;
        this.xr_TuyenChinhThuc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrl_ViTriCongViec
        // 
        this.xrl_ViTriCongViec.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrl_ViTriCongViec.LocationFloat = new DevExpress.Utils.PointFloat(428.9585F, 137.4167F);
        this.xrl_ViTriCongViec.Name = "xrl_ViTriCongViec";
        this.xrl_ViTriCongViec.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ViTriCongViec.SizeF = new System.Drawing.SizeF(241.4586F, 23F);
        this.xrl_ViTriCongViec.StylePriority.UseFont = false;
        this.xrl_ViTriCongViec.StylePriority.UseTextAlignment = false;
        this.xrl_ViTriCongViec.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrl_ChucVu
        // 
        this.xrl_ChucVu.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrl_ChucVu.LocationFloat = new DevExpress.Utils.PointFloat(80.20834F, 137.4167F);
        this.xrl_ChucVu.Name = "xrl_ChucVu";
        this.xrl_ChucVu.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ChucVu.SizeF = new System.Drawing.SizeF(234.1669F, 23F);
        this.xrl_ChucVu.StylePriority.UseFont = false;
        this.xrl_ChucVu.StylePriority.UseTextAlignment = false;
        this.xrl_ChucVu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrl_PhongBan
        // 
        this.xrl_PhongBan.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrl_PhongBan.LocationFloat = new DevExpress.Utils.PointFloat(428.9585F, 114.4167F);
        this.xrl_PhongBan.Name = "xrl_PhongBan";
        this.xrl_PhongBan.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_PhongBan.SizeF = new System.Drawing.SizeF(241.4586F, 23F);
        this.xrl_PhongBan.StylePriority.UseFont = false;
        this.xrl_PhongBan.StylePriority.UseTextAlignment = false;
        this.xrl_PhongBan.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrl_HoTen
        // 
        this.xrl_HoTen.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrl_HoTen.LocationFloat = new DevExpress.Utils.PointFloat(80.20834F, 114.4167F);
        this.xrl_HoTen.Name = "xrl_HoTen";
        this.xrl_HoTen.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_HoTen.SizeF = new System.Drawing.SizeF(234.1669F, 23F);
        this.xrl_HoTen.StylePriority.UseFont = false;
        this.xrl_HoTen.StylePriority.UseTextAlignment = false;
        this.xrl_HoTen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // xrl_TitleBC
        // 
        this.xrl_TitleBC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_TitleBC.LocationFloat = new DevExpress.Utils.PointFloat(0F, 75F);
        this.xrl_TitleBC.Name = "xrl_TitleBC";
        this.xrl_TitleBC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_TitleBC.SizeF = new System.Drawing.SizeF(1044.958F, 23F);
        this.xrl_TitleBC.StylePriority.UseFont = false;
        this.xrl_TitleBC.StylePriority.UseTextAlignment = false;
        this.xrl_TitleBC.Text = "BÁO CÁO DANH SÁCH HỢP ĐỒNG CỦA NHÂN VIÊN";
        this.xrl_TitleBC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrl_TenCongTy
        // 
        this.xrl_TenCongTy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_TenCongTy.LocationFloat = new DevExpress.Utils.PointFloat(0F, 10.00001F);
        this.xrl_TenCongTy.Name = "xrl_TenCongTy";
        this.xrl_TenCongTy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_TenCongTy.SizeF = new System.Drawing.SizeF(499.3446F, 21.875F);
        this.xrl_TenCongTy.StylePriority.UseFont = false;
        this.xrl_TenCongTy.StylePriority.UseTextAlignment = false;
        this.xrl_TenCongTy.Text = "CÔNG TY CỔ PHẦN THẾ GIỚI GIẢI TRÍ";
        this.xrl_TenCongTy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrLabel2
        // 
        this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 137.4167F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(80.20834F, 23F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.Text = "Chức vụ : ";
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.PageHeader.HeightF = 35F;
        this.PageHeader.Name = "PageHeader";
        // 
        // xrTable1
        // 
        this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
                    | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(1044.958F, 34.625F);
        this.xrTable1.StylePriority.UseBorders = false;
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell1,
            this.xrTableCell7,
            this.xrTableCell2,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell3,
            this.xrTableCell12});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Text = "STT";
        this.xrTableCell4.Weight = 0.096422355212466268D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.Text = "Số hợp đồng";
        this.xrTableCell1.Weight = 0.2954839803715959D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Text = "Loại hợp đồng";
        this.xrTableCell7.Weight = 0.62543627430773951D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.Text = "Công việc";
        this.xrTableCell2.Weight = 0.45637012307178776D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.Text = "Ngày ký";
        this.xrTableCell5.Weight = 0.24094738231432739D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Text = "Ngày hiệu lực";
        this.xrTableCell6.Weight = 0.24093636541416669D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Text = "Ngày hết hạn";
        this.xrTableCell3.Weight = 0.23548234502478369D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.Text = "Tình trạng hợp đồng";
        this.xrTableCell12.Weight = 0.544414299998938D;
        // 
        // ReportFooter
        // 
        this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrl_phongHCNS,
            this.xrl_chukyGiamDoc,
            this.xrtngayketxuat,
            this.xrl_titleHCNS,
            this.xrl_TongGiamDoc});
        this.ReportFooter.HeightF = 175F;
        this.ReportFooter.Name = "ReportFooter";
        // 
        // xrl_phongHCNS
        // 
        this.xrl_phongHCNS.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_phongHCNS.LocationFloat = new DevExpress.Utils.PointFloat(395.1666F, 131.25F);
        this.xrl_phongHCNS.Name = "xrl_phongHCNS";
        this.xrl_phongHCNS.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_phongHCNS.SizeF = new System.Drawing.SizeF(245.7076F, 23F);
        this.xrl_phongHCNS.StylePriority.UseFont = false;
        this.xrl_phongHCNS.StylePriority.UseTextAlignment = false;
        this.xrl_phongHCNS.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_chukyGiamDoc
        // 
        this.xrl_chukyGiamDoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_chukyGiamDoc.LocationFloat = new DevExpress.Utils.PointFloat(795.1666F, 131.25F);
        this.xrl_chukyGiamDoc.Name = "xrl_chukyGiamDoc";
        this.xrl_chukyGiamDoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_chukyGiamDoc.SizeF = new System.Drawing.SizeF(240.752F, 23F);
        this.xrl_chukyGiamDoc.StylePriority.UseFont = false;
        this.xrl_chukyGiamDoc.StylePriority.UseTextAlignment = false;
        this.xrl_chukyGiamDoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrtngayketxuat
        // 
        this.xrtngayketxuat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
        this.xrtngayketxuat.LocationFloat = new DevExpress.Utils.PointFloat(795.1666F, 6.25F);
        this.xrtngayketxuat.Name = "xrtngayketxuat";
        this.xrtngayketxuat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrtngayketxuat.SizeF = new System.Drawing.SizeF(241.8331F, 23F);
        this.xrtngayketxuat.StylePriority.UseFont = false;
        this.xrtngayketxuat.StylePriority.UseTextAlignment = false;
        this.xrtngayketxuat.Text = "ngày 15 tháng 4 năm 2013";
        this.xrtngayketxuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_titleHCNS
        // 
        this.xrl_titleHCNS.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_titleHCNS.LocationFloat = new DevExpress.Utils.PointFloat(395.1666F, 31.25F);
        this.xrl_titleHCNS.Name = "xrl_titleHCNS";
        this.xrl_titleHCNS.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_titleHCNS.SizeF = new System.Drawing.SizeF(247.7086F, 23F);
        this.xrl_titleHCNS.StylePriority.UseFont = false;
        this.xrl_titleHCNS.StylePriority.UseTextAlignment = false;
        this.xrl_titleHCNS.Text = "PHÒNG HCNS";
        this.xrl_titleHCNS.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrl_TongGiamDoc
        // 
        this.xrl_TongGiamDoc.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_TongGiamDoc.LocationFloat = new DevExpress.Utils.PointFloat(795.1666F, 31.25F);
        this.xrl_TongGiamDoc.Name = "xrl_TongGiamDoc";
        this.xrl_TongGiamDoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_TongGiamDoc.SizeF = new System.Drawing.SizeF(241.8334F, 23F);
        this.xrl_TongGiamDoc.StylePriority.UseFont = false;
        this.xrl_TongGiamDoc.StylePriority.UseTextAlignment = false;
        this.xrl_TongGiamDoc.Text = "TỔNG GIÁM ĐỐC";
        this.xrl_TongGiamDoc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
        this.PageFooter.HeightF = 214F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrPageInfo1
        // 
        this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrPageInfo1.Format = "Trang {0} của {1}";
        this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(955.3746F, 38.54167F);
        this.xrPageInfo1.Name = "xrPageInfo1";
        this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrPageInfo1.SizeF = new System.Drawing.SizeF(89.58374F, 23.00001F);
        this.xrPageInfo1.StylePriority.UseFont = false;
        this.xrPageInfo1.StylePriority.UseTextAlignment = false;
        this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        // 
        // rpwg_BaoCaoDanhSachHopDongNhanVien
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter});
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(58, 64, 50, 100);
        this.PageHeight = 827;
        this.PageWidth = 1169;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        this.Version = "10.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
