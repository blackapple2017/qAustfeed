﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DataController;

/// <summary>
/// Summary description for rp_DanhSachNhanVienNghiViec
/// </summary>
public class rp_DanhSachNhanVienNghiViec : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
	private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private PageHeaderBand PageHeader;
    private ReportFooterBand ReportFooter;
    private XRLabel xrt_tenbaocao;
    private XRLabel xrt_tungay;
    private XRLabel xrl_TenThanhPho;
    private XRLabel xrl_TenCongTy;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrt_stt;
    private XRTableCell xrt_macbnv;
    private XRTableCell xrt_hovaten;
    private XRTableCell xrt_gioitinh;
    private XRTableCell xrt_chucvu;
    private XRTableCell xrt_thamnien;
    private XRTableCell xrt_loaihopdong;
    private XRTableCell xrt_lydo;
    private XRTableCell xrt_ngayvaolamviec;
    private XRTableCell xrt_ngaylamvieccuoicung;
    private XRLabel xrl_ten2;
    private XRLabel xrl_footer2;
    private XRLabel xrl_ngayketxuat;
    private XRLabel xrl_footer3;
    private XRLabel xrl_ten3;
    private XRLabel xrl_footer1;
    private XRLabel xrl_ten1;
    private PageFooterBand PageFooter;
    private XRPageInfo xrPageInfo1;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public rp_DanhSachNhanVienNghiViec()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
    }  int STT = 1;
    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        xrt_stt.Text = STT.ToString();
        STT++;
    }
    public void BinData( ReportFilter filter)
    {
        // xrt_tungay.Text = "Từ ngày " + Convert.ToDateTime(filter.TuNgay).ToString("dd/MM/yyyy") + " Đến ngày " + Convert.ToDateTime(filter.DenNgay).ToString("dd/MM/yyyy");
        //xrl_TenCongTy.Text = filter.TenDonVi;
        //xrl_TenThanhPho.Text = filter.TenThanhPho.ToUpper();
        DataTable dt = new DataTable();// DataHandler.GetInstance().ExecuteDataTable("GetDanhSachLaoDongNghiViec", "@MaDonVi", "@MaBoPhan", "@TuNgay", "@DenNgay", filter.MaDonVi, filter.MaBoPhan, filter.TuNgay, filter.DenNgay);
        if (dt.Rows.Count > 0)
        {
            DataSource = dt;
            xrt_macbnv.DataBindings.Add("Text", DataSource, "MA_CB");
            xrt_hovaten.DataBindings.Add("Text", DataSource, "HO_TEN");
            xrt_gioitinh.DataBindings.Add("Text", DataSource, "GioiTinh");
            xrt_chucvu.DataBindings.Add("Text", DataSource, "TEN_CHUCVU");
            xrt_loaihopdong.DataBindings.Add("Text", DataSource, "TEN_LOAI_HDONG");
            xrt_lydo.DataBindings.Add("Text", DataSource, "TEN_LYDO_NGHI");
            xrt_ngayvaolamviec.DataBindings.Add("Text", DataSource, "NgayVaoLamViec", "{0:dd/MM/yyyy}");
            xrt_ngaylamvieccuoicung.DataBindings.Add("Text", DataSource, "NgayCuoiCung", "{0:dd/MM/yyyy}");
            xrt_thamnien.DataBindings.Add("Text", DataSource, "thamnien");
            
        }
        xrl_ngayketxuat.Text = "Ngày " + DateTime.Now.Day + " tháng " + DateTime.Now.Month + " năm " + DateTime.Now.Year;
        //if (!string.IsNullOrEmpty(filter.TenBaoCao))
        //{
        //    xrt_tenbaocao.Text = filter.TenBaoCao.ToUpper();
        //}
        //if (!string.IsNullOrEmpty(filter.Footer1))
        //{
        //    xrl_footer1.Text = filter.Footer1;
        //}
        //if (!string.IsNullOrEmpty(filter.Footer2))
        //{
        //    xrl_footer2.Text = filter.Footer2;
        //}
        //if (!string.IsNullOrEmpty(filter.Footer3))
        //{
        //    xrl_footer3.Text = filter.Footer3;
        //}
        //if (!string.IsNullOrEmpty(filter.Ten1))
        //{
        //    xrl_ten1.Text = filter.Ten1;
        //}
        //else
        //{
        //    xrl_ten1.Text = filter.NguoiLapBaoCao.ToString();
        //}
        //if (!string.IsNullOrEmpty(filter.Ten2))
        //{
        //    xrl_ten2.Text = filter.Ten2;
        //}
        //if (!string.IsNullOrEmpty(filter.Ten3))
        //{
        //    xrl_ten3.Text = filter.Ten3;
        //}

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
            string resourceFileName = "rp_DanhSachNhanVienNghiViec.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrt_stt = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_macbnv = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_hovaten = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_gioitinh = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_chucvu = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_thamnien = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_loaihopdong = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_lydo = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_ngayvaolamviec = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrt_ngaylamvieccuoicung = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrl_TenCongTy = new DevExpress.XtraReports.UI.XRLabel();
            this.xrt_tungay = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_TenThanhPho = new DevExpress.XtraReports.UI.XRLabel();
            this.xrt_tenbaocao = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrl_ten2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_footer2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_ngayketxuat = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_footer3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_ten3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_footer1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrl_ten1 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable3});
            this.Detail.HeightF = 27.08335F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(1.999879F, 0F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(1142F, 27.08335F);
            this.xrTable3.StylePriority.UseBorders = false;
            this.xrTable3.StylePriority.UseFont = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrt_stt,
            this.xrt_macbnv,
            this.xrt_hovaten,
            this.xrt_gioitinh,
            this.xrt_chucvu,
            this.xrt_thamnien,
            this.xrt_loaihopdong,
            this.xrt_lydo,
            this.xrt_ngayvaolamviec,
            this.xrt_ngaylamvieccuoicung});
            this.xrTableRow3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.StylePriority.UseFont = false;
            this.xrTableRow3.StylePriority.UseTextAlignment = false;
            this.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow3.Weight = 1D;
            // 
            // xrt_stt
            // 
            this.xrt_stt.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_stt.Name = "xrt_stt";
            this.xrt_stt.StylePriority.UseFont = false;
            this.xrt_stt.Weight = 0.33333328247070315D;
            this.xrt_stt.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrt_macbnv
            // 
            this.xrt_macbnv.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_macbnv.Name = "xrt_macbnv";
            this.xrt_macbnv.StylePriority.UseFont = false;
            this.xrt_macbnv.Weight = 0.82291671752929685D;
            // 
            // xrt_hovaten
            // 
            this.xrt_hovaten.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_hovaten.Name = "xrt_hovaten";
            this.xrt_hovaten.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrt_hovaten.StylePriority.UseFont = false;
            this.xrt_hovaten.StylePriority.UsePadding = false;
            this.xrt_hovaten.StylePriority.UseTextAlignment = false;
            this.xrt_hovaten.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrt_hovaten.Weight = 1.3479165649414062D;
            // 
            // xrt_gioitinh
            // 
            this.xrt_gioitinh.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_gioitinh.Name = "xrt_gioitinh";
            this.xrt_gioitinh.StylePriority.UseFont = false;
            this.xrt_gioitinh.Weight = 0.53541656494140621D;
            // 
            // xrt_chucvu
            // 
            this.xrt_chucvu.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_chucvu.Name = "xrt_chucvu";
            this.xrt_chucvu.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrt_chucvu.StylePriority.UseFont = false;
            this.xrt_chucvu.StylePriority.UsePadding = false;
            this.xrt_chucvu.StylePriority.UseTextAlignment = false;
            this.xrt_chucvu.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrt_chucvu.Weight = 1.2333337402343747D;
            // 
            // xrt_thamnien
            // 
            this.xrt_thamnien.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_thamnien.Name = "xrt_thamnien";
            this.xrt_thamnien.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrt_thamnien.StylePriority.UseFont = false;
            this.xrt_thamnien.StylePriority.UsePadding = false;
            this.xrt_thamnien.StylePriority.UseTextAlignment = false;
            this.xrt_thamnien.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrt_thamnien.Weight = 0.792029346175591D;
            // 
            // xrt_loaihopdong
            // 
            this.xrt_loaihopdong.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_loaihopdong.Name = "xrt_loaihopdong";
            this.xrt_loaihopdong.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrt_loaihopdong.StylePriority.UseFont = false;
            this.xrt_loaihopdong.StylePriority.UsePadding = false;
            this.xrt_loaihopdong.StylePriority.UseTextAlignment = false;
            this.xrt_loaihopdong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrt_loaihopdong.Weight = 2.0266694574748811D;
            // 
            // xrt_lydo
            // 
            this.xrt_lydo.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_lydo.Name = "xrt_lydo";
            this.xrt_lydo.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrt_lydo.StylePriority.UseFont = false;
            this.xrt_lydo.StylePriority.UsePadding = false;
            this.xrt_lydo.StylePriority.UseTextAlignment = false;
            this.xrt_lydo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrt_lydo.Weight = 2.0493088616855717D;
            // 
            // xrt_ngayvaolamviec
            // 
            this.xrt_ngayvaolamviec.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_ngayvaolamviec.Name = "xrt_ngayvaolamviec";
            this.xrt_ngayvaolamviec.StylePriority.UseFont = false;
            this.xrt_ngayvaolamviec.Weight = 1.1609084141166779D;
            // 
            // xrt_ngaylamvieccuoicung
            // 
            this.xrt_ngaylamvieccuoicung.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrt_ngaylamvieccuoicung.Name = "xrt_ngaylamvieccuoicung";
            this.xrt_ngaylamvieccuoicung.StylePriority.UseFont = false;
            this.xrt_ngaylamvieccuoicung.Weight = 1.1481670504300912D;
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
            this.xrl_TenCongTy,
            this.xrt_tungay,
            this.xrl_TenThanhPho,
            this.xrt_tenbaocao});
            this.ReportHeader.HeightF = 115F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrl_TenCongTy
            // 
            this.xrl_TenCongTy.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_TenCongTy.LocationFloat = new DevExpress.Utils.PointFloat(0F, 23.95833F);
            this.xrl_TenCongTy.Name = "xrl_TenCongTy";
            this.xrl_TenCongTy.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_TenCongTy.SizeF = new System.Drawing.SizeF(484.7656F, 23F);
            this.xrl_TenCongTy.StylePriority.UseFont = false;
            this.xrl_TenCongTy.StylePriority.UseTextAlignment = false;
            this.xrl_TenCongTy.Text = "CÔNG TY CỔ PHẦN CÔNG NGHỆ DTH VÀ GIẢI PHÁP SỐ";
            this.xrl_TenCongTy.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrt_tungay
            // 
            this.xrt_tungay.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrt_tungay.LocationFloat = new DevExpress.Utils.PointFloat(0F, 86.45834F);
            this.xrt_tungay.Name = "xrt_tungay";
            this.xrt_tungay.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrt_tungay.SizeF = new System.Drawing.SizeF(1144F, 17.95835F);
            this.xrt_tungay.StylePriority.UseFont = false;
            this.xrt_tungay.StylePriority.UseTextAlignment = false;
            this.xrt_tungay.Text = "Từ ngày ....... Đến ngày ..........";
            this.xrt_tungay.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_TenThanhPho
            // 
            this.xrl_TenThanhPho.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrl_TenThanhPho.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrl_TenThanhPho.Name = "xrl_TenThanhPho";
            this.xrl_TenThanhPho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_TenThanhPho.SizeF = new System.Drawing.SizeF(484.7656F, 23F);
            this.xrl_TenThanhPho.StylePriority.UseFont = false;
            this.xrl_TenThanhPho.StylePriority.UseTextAlignment = false;
            this.xrl_TenThanhPho.Text = "THÀNH PHỐ HÀ NỘI";
            this.xrl_TenThanhPho.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrt_tenbaocao
            // 
            this.xrt_tenbaocao.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.xrt_tenbaocao.LocationFloat = new DevExpress.Utils.PointFloat(0F, 61.45833F);
            this.xrt_tenbaocao.Name = "xrt_tenbaocao";
            this.xrt_tenbaocao.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrt_tenbaocao.SizeF = new System.Drawing.SizeF(1144F, 21.95834F);
            this.xrt_tenbaocao.StylePriority.UseFont = false;
            this.xrt_tenbaocao.StylePriority.UseTextAlignment = false;
            this.xrt_tenbaocao.Text = "DANH SÁCH NHÂN VIÊN THÔI VIỆC";
            this.xrt_tenbaocao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrTable1});
            this.PageHeader.HeightF = 65.62502F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(1.999998F, 38.54167F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(1142F, 27.08335F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21});
            this.xrTableRow2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.StylePriority.UseFont = false;
            this.xrTableRow2.StylePriority.UseTextAlignment = false;
            this.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Text = "1";
            this.xrTableCell12.Weight = 0.33333328247070315D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Text = "2";
            this.xrTableCell13.Weight = 0.82291671752929685D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Text = "3";
            this.xrTableCell14.Weight = 1.3479165649414062D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Text = "4";
            this.xrTableCell15.Weight = 0.53541656494140621D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Text = "5";
            this.xrTableCell16.Weight = 1.2333337402343747D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Text = "6";
            this.xrTableCell17.Weight = 0.792029346175591D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.Text = "7";
            this.xrTableCell18.Weight = 2.0266694574748811D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.Text = "8";
            this.xrTableCell19.Weight = 2.0493088616855717D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.Text = "9";
            this.xrTableCell20.Weight = 1.1609084141166779D;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Text = "10";
            this.xrTableCell21.Weight = 1.1481670504300912D;
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(1.999958F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1142F, 38.54167F);
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell7,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell4,
            this.xrTableCell9,
            this.xrTableCell8,
            this.xrTableCell10,
            this.xrTableCell11});
            this.xrTableRow1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.StylePriority.UseFont = false;
            this.xrTableRow1.StylePriority.UseTextAlignment = false;
            this.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "STT";
            this.xrTableCell1.Weight = 0.33333328247070315D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Mã CBNV";
            this.xrTableCell2.Weight = 0.82291671752929685D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Họ và tên";
            this.xrTableCell7.Weight = 1.3479165649414062D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Giới tính ";
            this.xrTableCell5.Weight = 0.53541656494140621D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Chức vụ";
            this.xrTableCell6.Weight = 1.2333337402343747D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Thâm niên ";
            this.xrTableCell4.Weight = 0.79202911450441138D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "Loại hợp đồng";
            this.xrTableCell9.Weight = 2.0266696020684183D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Lý do";
            this.xrTableCell8.Weight = 2.0493090034658561D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.Text = "Ngày vào làm việc";
            this.xrTableCell10.Weight = 1.1609078987509069D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Text = "Ngày làm việc cuối cùng";
            this.xrTableCell11.Weight = 1.1481675110932192D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrl_ten2,
            this.xrl_footer2,
            this.xrl_ngayketxuat,
            this.xrl_footer3,
            this.xrl_ten3,
            this.xrl_footer1,
            this.xrl_ten1});
            this.ReportFooter.HeightF = 211F;
            this.ReportFooter.Name = "ReportFooter";
            this.ReportFooter.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.ReportFooter.StylePriority.UsePadding = false;
            // 
            // xrl_ten2
            // 
            this.xrl_ten2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_ten2.LocationFloat = new DevExpress.Utils.PointFloat(484.5308F, 184.9999F);
            this.xrl_ten2.Multiline = true;
            this.xrl_ten2.Name = "xrl_ten2";
            this.xrl_ten2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_ten2.SizeF = new System.Drawing.SizeF(167.7083F, 23F);
            this.xrl_ten2.StylePriority.UseFont = false;
            this.xrl_ten2.StylePriority.UseTextAlignment = false;
            this.xrl_ten2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_footer2
            // 
            this.xrl_footer2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_footer2.LocationFloat = new DevExpress.Utils.PointFloat(484.5308F, 72.49998F);
            this.xrl_footer2.Name = "xrl_footer2";
            this.xrl_footer2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_footer2.SizeF = new System.Drawing.SizeF(167.7083F, 23F);
            this.xrl_footer2.StylePriority.UseFont = false;
            this.xrl_footer2.StylePriority.UseTextAlignment = false;
            this.xrl_footer2.Text = "TRƯỞNG BỘ PHẬN";
            this.xrl_footer2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_ngayketxuat
            // 
            this.xrl_ngayketxuat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
            this.xrl_ngayketxuat.LocationFloat = new DevExpress.Utils.PointFloat(913.6975F, 37.08334F);
            this.xrl_ngayketxuat.Name = "xrl_ngayketxuat";
            this.xrl_ngayketxuat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_ngayketxuat.SizeF = new System.Drawing.SizeF(201.0416F, 23F);
            this.xrl_ngayketxuat.StylePriority.UseFont = false;
            this.xrl_ngayketxuat.StylePriority.UseTextAlignment = false;
            this.xrl_ngayketxuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_footer3
            // 
            this.xrl_footer3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_footer3.LocationFloat = new DevExpress.Utils.PointFloat(934.5307F, 72.49998F);
            this.xrl_footer3.Name = "xrl_footer3";
            this.xrl_footer3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_footer3.SizeF = new System.Drawing.SizeF(167.7083F, 23F);
            this.xrl_footer3.StylePriority.UseFont = false;
            this.xrl_footer3.StylePriority.UseTextAlignment = false;
            this.xrl_footer3.Text = "BAN GIÁM ĐỐC";
            this.xrl_footer3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_ten3
            // 
            this.xrl_ten3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_ten3.LocationFloat = new DevExpress.Utils.PointFloat(934.5307F, 184.9999F);
            this.xrl_ten3.Multiline = true;
            this.xrl_ten3.Name = "xrl_ten3";
            this.xrl_ten3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_ten3.SizeF = new System.Drawing.SizeF(167.7083F, 23F);
            this.xrl_ten3.StylePriority.UseFont = false;
            this.xrl_ten3.StylePriority.UseTextAlignment = false;
            this.xrl_ten3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_footer1
            // 
            this.xrl_footer1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_footer1.LocationFloat = new DevExpress.Utils.PointFloat(47.03077F, 72.49998F);
            this.xrl_footer1.Name = "xrl_footer1";
            this.xrl_footer1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_footer1.SizeF = new System.Drawing.SizeF(167.7083F, 23F);
            this.xrl_footer1.StylePriority.UseFont = false;
            this.xrl_footer1.StylePriority.UseTextAlignment = false;
            this.xrl_footer1.Text = "NGƯỜI LẬP";
            this.xrl_footer1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrl_ten1
            // 
            this.xrl_ten1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrl_ten1.LocationFloat = new DevExpress.Utils.PointFloat(47.03077F, 184.9999F);
            this.xrl_ten1.Multiline = true;
            this.xrl_ten1.Name = "xrl_ten1";
            this.xrl_ten1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrl_ten1.SizeF = new System.Drawing.SizeF(167.7083F, 23F);
            this.xrl_ten1.StylePriority.UseFont = false;
            this.xrl_ten1.StylePriority.UseTextAlignment = false;
            this.xrl_ten1.Text = "demo\r\n";
            this.xrl_ten1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
            this.PageFooter.Name = "PageFooter";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrPageInfo1.Format = "Trang {0} của {1}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(1017.958F, 25F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(126.0417F, 23.00001F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            this.xrPageInfo1.StylePriority.UseTextAlignment = false;
            this.xrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // rp_DanhSachNhanVienNghiViec
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
            this.Margins = new System.Drawing.Printing.Margins(11, 11, 50, 100);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion
}
