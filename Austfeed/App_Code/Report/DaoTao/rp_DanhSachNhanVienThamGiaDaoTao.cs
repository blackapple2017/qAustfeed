﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DataController;

/// <summary>
/// Summary description for rp_DanhSachNhanVienThamGiaDaoTao
/// </summary>
public class rp_DanhSachNhanVienThamGiaDaoTao : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
	private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private PageHeaderBand PageHeader;
    private XRLabel xrl_TitleBC;
    private XRLabel xrl_NgayBaoCao;
    private XRLabel xrl_TenCongTy;
    private XRLabel xrl_TenThanhPho;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private ReportFooterBand ReportFooter;
    private PageFooterBand PageFooter;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrt_stt;
    private XRTableCell xrt_hoten;
    private XRTableCell xrt_Email;
    private XRTableCell xrtNhanXetGiaoVien;
    private XRLabel xrl_ten1;
    private XRLabel xrl_ten2;
    private XRLabel xrl_ten3;
    private XRLabel xrtngayketxuat;
    private XRLabel xrl_footer3;
    private XRLabel xrl_footer2;
    private XRLabel xrl_footer1;
    private XRPageInfo xrPageInfo1;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrl_groupphongban;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell10;
    private XRLabel xrLabel1;
    private XRLabel xrLabel2;
    private XRLabel xrLTenKhoaDaoTao;
    private XRLabel xrLMaKhoaHoc;
    private XRLabel xrLThoiGianBatDau;
    private XRLabel xrLThoiGianKetThuc;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;
    private XRTableCell xrTDienThoai;
    private XRTableCell xrTChucVu;
    private XRTableCell xrTDiem;
    private XRTableCell xrTKetQua;
    private XRTableCell xrTableCell6;
    private XRTableCell xrMaCB;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public rp_DanhSachNhanVienThamGiaDaoTao()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}
    int STT = 1;
    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        xrt_stt.Text = STT.ToString();
        STT++;
    }
    public void BindData(ReportFilter filter)
    { 
        try
        {
            ReportController rpCtr = new ReportController();
            xrl_NgayBaoCao.Text = "Ngày báo cáo: " + string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            
            xrl_TitleBC.Text = new ReportWorldgame().GetLocationName(filter.SelectedDepartment);
            xrl_TenCongTy.Text = rpCtr.GetCompanyName(filter.SessionDepartment);
            xrl_TenThanhPho.Text = rpCtr.GetCityName(filter.SessionDepartment);
            DataTable table = DataHandler.GetInstance().ExecuteDataTable("GetDanhSachNhanVienThamGiaDaoTao", "@MaDonVi",
                                                                                             "@MaBoPhan",
                                                                                             "@Gender",
                                                                                             "@WorkingStatus",
                                                                                             "@MinSeniority",
                                                                                             "@MaxSeniority",
                                                                                             "@WhereClause",
                                                                                            filter.SessionDepartment,
                                                                                            filter.SelectedDepartment,
                                                                                            filter.Gender,
                                                                                            filter.WorkingStatus,
                                                                                            filter.MinSeniority,
                                                                                            filter.MaxSeniority,
                                                                                            filter.WhereClause);
            DataSource = table;
            xrLTenKhoaDaoTao.DataBindings.Add("Text", DataSource, "TEN_KHOA_HOC"); 
            xrLThoiGianBatDau.DataBindings.Add("Text", DataSource, "TU_NGAY", "{0:dd/MM/yyyy}");
            xrLThoiGianKetThuc.DataBindings.Add("Text", DataSource, "DEN_NGAY", "{0:dd/MM/yyyy}"); 
            xrLMaKhoaHoc.DataBindings.Add("Text", DataSource, "MA");
            xrt_hoten.DataBindings.Add("Text", DataSource, "HO_TEN");
            xrTDienThoai.DataBindings.Add("Text", DataSource, "DI_DONG");
            xrMaCB.DataBindings.Add("Text", DataSource, "MaCanBo");
            xrt_Email.DataBindings.Add("Text", DataSource, "EMAIL");
            xrTChucVu.DataBindings.Add("Text", DataSource, "TEN_CHUCVU"); 
            xrTDiem.DataBindings.Add("Text", DataSource, "SoDiem");
            xrTKetQua.DataBindings.Add("Text", DataSource, "KetQua");
            xrtNhanXetGiaoVien.DataBindings.Add("Text", DataSource, "NhanXetCuaGiaoVien");

            this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ChuoiSX", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
            xrl_groupphongban.DataBindings.Add("Text", DataSource, "TEN_PHONG").ToString().ToUpper();

            if (!string.IsNullOrEmpty(filter.ReportTitle))
            {
                xrl_TitleBC.Text = filter.ReportTitle;
            }
            else
            {
                xrl_TitleBC.Text = "DANH SÁCH NHÂN VIÊN THAM GIA ĐÀO TẠO";
            }
            if (!string.IsNullOrEmpty(filter.Name1))
            {
                xrl_ten1.Text = filter.Name1;
            }
            else
            {
                xrl_ten1.Text = rpCtr.GetCreatedReporterName(filter.SessionDepartment, filter.Reporter);
            }
            xrl_ten2.Text = rpCtr.GetHeadOfHRroom(filter.SessionDepartment, filter.Name2);
            xrl_ten3.Text = rpCtr.GetDirectorName(filter.SessionDepartment, filter.Name3);
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
	protected override void Dispose(bool disposing) {
		if (disposing && (components != null)) {
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent() {
        string resourceFileName = "rp_DanhSachNhanVienThamGiaDaoTao.resx";
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrt_stt = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_hoten = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTDienThoai = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrt_Email = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTChucVu = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTDiem = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTKetQua = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrtNhanXetGiaoVien = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrLThoiGianBatDau = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLThoiGianKetThuc = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLMaKhoaHoc = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLTenKhoaDaoTao = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_TitleBC = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_NgayBaoCao = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_TenCongTy = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_TenThanhPho = new DevExpress.XtraReports.UI.XRLabel();
        this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
        this.xrl_ten1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_ten2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_ten3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrtngayketxuat = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_footer3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_footer2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_footer1 = new DevExpress.XtraReports.UI.XRLabel();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrl_groupphongban = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrMaCB = new DevExpress.XtraReports.UI.XRTableCell();
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
        this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(1093F, 25F);
        this.xrTable2.StylePriority.UseBorders = false;
        this.xrTable2.StylePriority.UseFont = false;
        this.xrTable2.StylePriority.UseTextAlignment = false;
        this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrt_stt,
            this.xrMaCB,
            this.xrt_hoten,
            this.xrTDienThoai,
            this.xrt_Email,
            this.xrTChucVu,
            this.xrTDiem,
            this.xrTKetQua,
            this.xrtNhanXetGiaoVien});
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrt_stt
        // 
        this.xrt_stt.Name = "xrt_stt";
        this.xrt_stt.Weight = 0.13613175372688136D;
        this.xrt_stt.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
        // 
        // xrt_hoten
        // 
        this.xrt_hoten.Name = "xrt_hoten";
        this.xrt_hoten.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
        this.xrt_hoten.StylePriority.UsePadding = false;
        this.xrt_hoten.StylePriority.UseTextAlignment = false;
        this.xrt_hoten.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrt_hoten.Weight = 0.46089932092531016D;
        // 
        // xrTDienThoai
        // 
        this.xrTDienThoai.Name = "xrTDienThoai";
        this.xrTDienThoai.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
        this.xrTDienThoai.StylePriority.UsePadding = false;
        this.xrTDienThoai.StylePriority.UseTextAlignment = false;
        this.xrTDienThoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTDienThoai.Weight = 0.33039299900487928D;
        // 
        // xrt_Email
        // 
        this.xrt_Email.Name = "xrt_Email";
        this.xrt_Email.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
        this.xrt_Email.StylePriority.UsePadding = false;
        this.xrt_Email.StylePriority.UseTextAlignment = false;
        this.xrt_Email.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrt_Email.Weight = 0.55867836312391117D;
        // 
        // xrTChucVu
        // 
        this.xrTChucVu.Name = "xrTChucVu";
        this.xrTChucVu.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
        this.xrTChucVu.StylePriority.UsePadding = false;
        this.xrTChucVu.StylePriority.UseTextAlignment = false;
        this.xrTChucVu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTChucVu.Weight = 0.38716324782905237D;
        // 
        // xrTDiem
        // 
        this.xrTDiem.Name = "xrTDiem";
        this.xrTDiem.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 3, 0, 0, 100F);
        this.xrTDiem.StylePriority.UsePadding = false;
        this.xrTDiem.StylePriority.UseTextAlignment = false;
        this.xrTDiem.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
        this.xrTDiem.Weight = 0.15821034992683383D;
        // 
        // xrTKetQua
        // 
        this.xrTKetQua.Name = "xrTKetQua";
        this.xrTKetQua.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
        this.xrTKetQua.StylePriority.UsePadding = false;
        this.xrTKetQua.StylePriority.UseTextAlignment = false;
        this.xrTKetQua.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTKetQua.Weight = 0.23893339168611685D;
        // 
        // xrtNhanXetGiaoVien
        // 
        this.xrtNhanXetGiaoVien.Name = "xrtNhanXetGiaoVien";
        this.xrtNhanXetGiaoVien.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
        this.xrtNhanXetGiaoVien.StylePriority.UsePadding = false;
        this.xrtNhanXetGiaoVien.StylePriority.UseTextAlignment = false;
        this.xrtNhanXetGiaoVien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrtNhanXetGiaoVien.Weight = 0.43996080658023834D;
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
            this.xrLThoiGianBatDau,
            this.xrLThoiGianKetThuc,
            this.xrLabel7,
            this.xrLabel8,
            this.xrLMaKhoaHoc,
            this.xrLTenKhoaDaoTao,
            this.xrLabel2,
            this.xrLabel1,
            this.xrl_TitleBC,
            this.xrl_NgayBaoCao,
            this.xrl_TenCongTy,
            this.xrl_TenThanhPho});
        this.ReportHeader.HeightF = 209F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // xrLThoiGianBatDau
        // 
        this.xrLThoiGianBatDau.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLThoiGianBatDau.LocationFloat = new DevExpress.Utils.PointFloat(762.4998F, 143.7917F);
        this.xrLThoiGianBatDau.Name = "xrLThoiGianBatDau";
        this.xrLThoiGianBatDau.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLThoiGianBatDau.SizeF = new System.Drawing.SizeF(305.5002F, 23F);
        this.xrLThoiGianBatDau.StylePriority.UseFont = false;
        // 
        // xrLThoiGianKetThuc
        // 
        this.xrLThoiGianKetThuc.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLThoiGianKetThuc.LocationFloat = new DevExpress.Utils.PointFloat(762.4998F, 168.7917F);
        this.xrLThoiGianKetThuc.Name = "xrLThoiGianKetThuc";
        this.xrLThoiGianKetThuc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLThoiGianKetThuc.SizeF = new System.Drawing.SizeF(305.4998F, 23F);
        this.xrLThoiGianKetThuc.StylePriority.UseFont = false;
        // 
        // xrLabel7
        // 
        this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(624.0417F, 143.7917F);
        this.xrLabel7.Name = "xrLabel7";
        this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel7.SizeF = new System.Drawing.SizeF(138.4581F, 23F);
        this.xrLabel7.StylePriority.UseFont = false;
        this.xrLabel7.Text = "Thời gian bắt đầu:";
        // 
        // xrLabel8
        // 
        this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(624.0417F, 168.7917F);
        this.xrLabel8.Name = "xrLabel8";
        this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel8.SizeF = new System.Drawing.SizeF(138.4582F, 23F);
        this.xrLabel8.StylePriority.UseFont = false;
        this.xrLabel8.Text = "Thời gian kết thúc:";
        // 
        // xrLMaKhoaHoc
        // 
        this.xrLMaKhoaHoc.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLMaKhoaHoc.LocationFloat = new DevExpress.Utils.PointFloat(161.9167F, 168.7917F);
        this.xrLMaKhoaHoc.Name = "xrLMaKhoaHoc";
        this.xrLMaKhoaHoc.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLMaKhoaHoc.SizeF = new System.Drawing.SizeF(369.7917F, 23F);
        this.xrLMaKhoaHoc.StylePriority.UseFont = false;
        // 
        // xrLTenKhoaDaoTao
        // 
        this.xrLTenKhoaDaoTao.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrLTenKhoaDaoTao.LocationFloat = new DevExpress.Utils.PointFloat(161.9167F, 145.7917F);
        this.xrLTenKhoaDaoTao.Name = "xrLTenKhoaDaoTao";
        this.xrLTenKhoaDaoTao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLTenKhoaDaoTao.SizeF = new System.Drawing.SizeF(369.7917F, 23F);
        this.xrLTenKhoaDaoTao.StylePriority.UseFont = false;
        // 
        // xrLabel2
        // 
        this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(32.75F, 168.7917F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(129.1667F, 23F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.Text = "Mã khoa học: ";
        // 
        // xrLabel1
        // 
        this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(32.75F, 145.7917F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(129.1667F, 23F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.Text = "Tên khóa đào tạo: ";
        // 
        // xrl_TitleBC
        // 
        this.xrl_TitleBC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_TitleBC.LocationFloat = new DevExpress.Utils.PointFloat(0F, 82.29166F);
        this.xrl_TitleBC.Name = "xrl_TitleBC";
        this.xrl_TitleBC.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_TitleBC.SizeF = new System.Drawing.SizeF(1093F, 23F);
        this.xrl_TitleBC.StylePriority.UseFont = false;
        this.xrl_TitleBC.StylePriority.UseTextAlignment = false;
        this.xrl_TitleBC.Text = "DANH SÁCH NHÂN VIÊN THAM GIA ĐÀO TẠO";
        this.xrl_TitleBC.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_NgayBaoCao
        // 
        this.xrl_NgayBaoCao.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic);
        this.xrl_NgayBaoCao.LocationFloat = new DevExpress.Utils.PointFloat(0F, 107.2917F);
        this.xrl_NgayBaoCao.Name = "xrl_NgayBaoCao";
        this.xrl_NgayBaoCao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_NgayBaoCao.SizeF = new System.Drawing.SizeF(1093F, 23F);
        this.xrl_NgayBaoCao.StylePriority.UseFont = false;
        this.xrl_NgayBaoCao.StylePriority.UseTextAlignment = false;
        this.xrl_NgayBaoCao.Text = "Từ ngày 14/3/2013 đến ngày 14/3/2013";
        this.xrl_NgayBaoCao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_TenCongTy
        // 
        this.xrl_TenCongTy.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_TenCongTy.LocationFloat = new DevExpress.Utils.PointFloat(0F, 32.29167F);
        this.xrl_TenCongTy.Name = "xrl_TenCongTy";
        this.xrl_TenCongTy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_TenCongTy.SizeF = new System.Drawing.SizeF(444.0417F, 23F);
        this.xrl_TenCongTy.StylePriority.UseFont = false;
        this.xrl_TenCongTy.StylePriority.UseTextAlignment = false;
        this.xrl_TenCongTy.Text = "CÔNG TY CỔ PHẦN CÔNG NGHỆ DTH VÀ GIẢI PHÁP SỐ";
        this.xrl_TenCongTy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_TenThanhPho
        // 
        this.xrl_TenThanhPho.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrl_TenThanhPho.LocationFloat = new DevExpress.Utils.PointFloat(0F, 7.291667F);
        this.xrl_TenThanhPho.Name = "xrl_TenThanhPho";
        this.xrl_TenThanhPho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_TenThanhPho.SizeF = new System.Drawing.SizeF(444.0416F, 23F);
        this.xrl_TenThanhPho.StylePriority.UseFont = false;
        this.xrl_TenThanhPho.StylePriority.UseTextAlignment = false;
        this.xrl_TenThanhPho.Text = "THÀNH PHỐ HÀ NỘI";
        this.xrl_TenThanhPho.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // PageHeader
        // 
        this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
        this.PageHeader.HeightF = 25F;
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
        this.xrTable1.SizeF = new System.Drawing.SizeF(1093F, 25F);
        this.xrTable1.StylePriority.UseBorders = false;
        this.xrTable1.StylePriority.UseFont = false;
        this.xrTable1.StylePriority.UseTextAlignment = false;
        this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell6,
            this.xrTableCell4,
            this.xrTableCell7,
            this.xrTableCell5,
            this.xrTableCell2,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell3});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.Text = "STT";
        this.xrTableCell1.Weight = 0.13613175372688136D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.Text = "Họ tên";
        this.xrTableCell4.Weight = 0.49082785987419281D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.Text = "Số điện thoại";
        this.xrTableCell7.Weight = 0.35184709476637027D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.Text = "Email";
        this.xrTableCell5.Weight = 0.594956224155548D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.Text = "Chức vụ";
        this.xrTableCell2.Weight = 0.41230389978927434D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.Text = "Điểm";
        this.xrTableCell9.Weight = 0.1684835734883807D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.Text = "Kết quả";
        this.xrTableCell10.Weight = 0.25444873707875026D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.Text = "Giáo viên nhận xét";
        this.xrTableCell3.Weight = 0.46852950003606963D;
        // 
        // ReportFooter
        // 
        this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrl_ten1,
            this.xrl_ten2,
            this.xrl_ten3,
            this.xrtngayketxuat,
            this.xrl_footer3,
            this.xrl_footer2,
            this.xrl_footer1});
        this.ReportFooter.HeightF = 167F;
        this.ReportFooter.Name = "ReportFooter";
        // 
        // xrl_ten1
        // 
        this.xrl_ten1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_ten1.LocationFloat = new DevExpress.Utils.PointFloat(2.001031F, 134F);
        this.xrl_ten1.Name = "xrl_ten1";
        this.xrl_ten1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ten1.SizeF = new System.Drawing.SizeF(295.9319F, 23F);
        this.xrl_ten1.StylePriority.UseFont = false;
        this.xrl_ten1.StylePriority.UseTextAlignment = false;
        this.xrl_ten1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_ten2
        // 
        this.xrl_ten2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_ten2.LocationFloat = new DevExpress.Utils.PointFloat(377.0009F, 134F);
        this.xrl_ten2.Name = "xrl_ten2";
        this.xrl_ten2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ten2.SizeF = new System.Drawing.SizeF(295.9319F, 23F);
        this.xrl_ten2.StylePriority.UseFont = false;
        this.xrl_ten2.StylePriority.UseTextAlignment = false;
        this.xrl_ten2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_ten3
        // 
        this.xrl_ten3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_ten3.LocationFloat = new DevExpress.Utils.PointFloat(789.5009F, 134F);
        this.xrl_ten3.Name = "xrl_ten3";
        this.xrl_ten3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ten3.SizeF = new System.Drawing.SizeF(289.2498F, 23F);
        this.xrl_ten3.StylePriority.UseFont = false;
        this.xrl_ten3.StylePriority.UseTextAlignment = false;
        this.xrl_ten3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrtngayketxuat
        // 
        this.xrtngayketxuat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
        this.xrtngayketxuat.LocationFloat = new DevExpress.Utils.PointFloat(787.5F, 12.5F);
        this.xrtngayketxuat.Name = "xrtngayketxuat";
        this.xrtngayketxuat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrtngayketxuat.SizeF = new System.Drawing.SizeF(289.2498F, 23F);
        this.xrtngayketxuat.StylePriority.UseFont = false;
        this.xrtngayketxuat.StylePriority.UseTextAlignment = false;
        this.xrtngayketxuat.Text = "Hà Nội, ngày 15 tháng 4 năm 2013";
        this.xrtngayketxuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_footer3
        // 
        this.xrl_footer3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_footer3.LocationFloat = new DevExpress.Utils.PointFloat(787.5F, 37.5F);
        this.xrl_footer3.Multiline = true;
        this.xrl_footer3.Name = "xrl_footer3";
        this.xrl_footer3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_footer3.SizeF = new System.Drawing.SizeF(289.25F, 23F);
        this.xrl_footer3.StylePriority.UseFont = false;
        this.xrl_footer3.StylePriority.UseTextAlignment = false;
        this.xrl_footer3.Text = "PHÒNG HCNS";
        this.xrl_footer3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_footer2
        // 
        this.xrl_footer2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_footer2.LocationFloat = new DevExpress.Utils.PointFloat(375F, 37.5F);
        this.xrl_footer2.Name = "xrl_footer2";
        this.xrl_footer2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_footer2.SizeF = new System.Drawing.SizeF(297.9328F, 23F);
        this.xrl_footer2.StylePriority.UseFont = false;
        this.xrl_footer2.StylePriority.UseTextAlignment = false;
        this.xrl_footer2.Text = "KẾ TOÁN TRƯỞNG";
        this.xrl_footer2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_footer1
        // 
        this.xrl_footer1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_footer1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 37.5F);
        this.xrl_footer1.Name = "xrl_footer1";
        this.xrl_footer1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_footer1.SizeF = new System.Drawing.SizeF(297.9328F, 23F);
        this.xrl_footer1.StylePriority.UseFont = false;
        this.xrl_footer1.StylePriority.UseTextAlignment = false;
        this.xrl_footer1.Text = "NGƯỜI LẬP";
        this.xrl_footer1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
        this.PageFooter.HeightF = 68F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrPageInfo1
        // 
        this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrPageInfo1.Format = "Trang {0} của {1}";
        this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(932.7075F, 10.00001F);
        this.xrPageInfo1.Name = "xrPageInfo1";
        this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrPageInfo1.SizeF = new System.Drawing.SizeF(126.0417F, 23.00001F);
        this.xrPageInfo1.StylePriority.UseFont = false;
        this.xrPageInfo1.StylePriority.UseTextAlignment = false;
        this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
        // 
        // GroupHeader1
        // 
        this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
        this.GroupHeader1.HeightF = 25F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // xrTable3
        // 
        this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
                    | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(1093F, 25F);
        this.xrTable3.StylePriority.UseBorders = false;
        this.xrTable3.StylePriority.UseFont = false;
        this.xrTable3.StylePriority.UseTextAlignment = false;
        this.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrl_groupphongban});
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrl_groupphongban
        // 
        this.xrl_groupphongban.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_groupphongban.Name = "xrl_groupphongban";
        this.xrl_groupphongban.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
        this.xrl_groupphongban.StylePriority.UseFont = false;
        this.xrl_groupphongban.StylePriority.UsePadding = false;
        this.xrl_groupphongban.StylePriority.UseTextAlignment = false;
        this.xrl_groupphongban.Text = "Phòng ban";
        this.xrl_groupphongban.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrl_groupphongban.Weight = 3D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.Text = "Mã nhân viên";
        this.xrTableCell6.Weight = 0.31727655188972725D;
        // 
        // xrMaCB
        // 
        this.xrMaCB.Name = "xrMaCB";
        this.xrMaCB.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 0, 0, 0, 100F);
        this.xrMaCB.StylePriority.UsePadding = false;
        this.xrMaCB.StylePriority.UseTextAlignment = false;
        this.xrMaCB.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrMaCB.Weight = 0.28962976719677647D;
        // 
        // rp_DanhSachNhanVienThamGiaDaoTao
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter,
            this.GroupHeader1});
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(34, 42, 50, 100);
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
