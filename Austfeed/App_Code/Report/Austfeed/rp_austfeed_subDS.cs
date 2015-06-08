using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

/// <summary>
/// Summary description for rp_austfeed_DS_LaoDongThamGiaBHXH
/// </summary>
public class rp_austfeed_subDS : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private XRTable xrTable33;
    private XRTableRow xrTableRow45;
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell90;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell93;
    private XRTableCell xrDotXetTuyen;
    private XRTableCell xrMucHuongSoMoi;
    private XRTableCell xrMucHuongSoChenhLech;
    private XRTableCell xrSoNgayThucSoChenhLech;
    private XRTableCell xrSoNgayThucNghiLuyKe;
    private XRTableCell xrTableCell94;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rp_austfeed_subDS()
    {
        InitializeComponent();
        //
        // TODO: Add constructor logic here
        //
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
    int STT = 1;
    
    public void BindData(string DonVi, string DK, int Thang, int Nam)
    {
        DataTable dt1 = DataController.DataHandler.GetInstance().ExecuteDataTable("sp_BH_C70aNew1",
           "@MaBoPhan", "@WhereClause", "@Month", "@Year",
          DonVi, DK, Thang, Nam);
        DataSource = dt1;
        xrTableCell89.DataBindings.Add("Text", DataSource, "STT");
        xrTableCell90.DataBindings.Add("Text", DataSource, "HoTen");
        xrTableCell91.DataBindings.Add("Text", DataSource, "NgaySinhNam");
        xrTableCell92.DataBindings.Add("Text", DataSource, "NgaySinhNu");
        xrTableCell93.DataBindings.Add("Text", DataSource, "SoSoBHXH");
        //xrDotXetTuyen.DataBindings.Add("Text", dt1, "STT");
        xrMucHuongSoMoi.DataBindings.Add("Text", DataSource, "LuongBaoHiem");
        //xrMucHuongSoChenhLech.DataBindings.Add("Text", dt1, "STT");
        xrSoNgayThucSoChenhLech.DataBindings.Add("Text", DataSource, "SoNgayNghi");
        xrSoNgayThucNghiLuyKe.DataBindings.Add("Text", DataSource, "LuyKeTuDauNam");
        //xrTableCell94.DataBindings.Add("Text", DataSource, "STT");
    }
    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            string resourceFileName = "rp_austfeed_subDS.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrTable33 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow45 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrDotXetTuyen = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrMucHuongSoMoi = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrMucHuongSoChenhLech = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrSoNgayThucSoChenhLech = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrSoNgayThucNghiLuyKe = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable33});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 14F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable33
            // 
            this.xrTable33.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable33.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrTable33.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable33.Name = "xrTable33";
            this.xrTable33.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow45});
            this.xrTable33.SizeF = new System.Drawing.SizeF(1079F, 25F);
            this.xrTable33.StylePriority.UseBorders = false;
            this.xrTable33.StylePriority.UseFont = false;
            // 
            // xrTableRow45
            // 
            this.xrTableRow45.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell89,
            this.xrTableCell90,
            this.xrTableCell91,
            this.xrTableCell92,
            this.xrTableCell93,
            this.xrDotXetTuyen,
            this.xrMucHuongSoMoi,
            this.xrMucHuongSoChenhLech,
            this.xrSoNgayThucSoChenhLech,
            this.xrSoNgayThucNghiLuyKe,
            this.xrTableCell94});
            this.xrTableRow45.Name = "xrTableRow45";
            this.xrTableRow45.Weight = 1D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell89.StylePriority.UsePadding = false;
            this.xrTableCell89.StylePriority.UseTextAlignment = false;
            this.xrTableCell89.Text = "....";
            this.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell89.Weight = 0.10043207922647165D;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell90.StylePriority.UsePadding = false;
            this.xrTableCell90.StylePriority.UseTextAlignment = false;
            this.xrTableCell90.Text = "....";
            this.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleJustify;
            this.xrTableCell90.Weight = 0.40496747393940768D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell91.StylePriority.UsePadding = false;
            this.xrTableCell91.StylePriority.UseTextAlignment = false;
            this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell91.Weight = 0.12956768302030336D;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell92.StylePriority.UsePadding = false;
            this.xrTableCell92.StylePriority.UseTextAlignment = false;
            this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell92.Weight = 0.12956773092580393D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell93.StylePriority.UsePadding = false;
            this.xrTableCell93.StylePriority.UseTextAlignment = false;
            this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell93.Weight = 0.21891468225523483D;
            // 
            // xrDotXetTuyen
            // 
            this.xrDotXetTuyen.Name = "xrDotXetTuyen";
            this.xrDotXetTuyen.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrDotXetTuyen.StylePriority.UsePadding = false;
            this.xrDotXetTuyen.StylePriority.UseTextAlignment = false;
            this.xrDotXetTuyen.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrDotXetTuyen.Weight = 0.38461252523023026D;
            // 
            // xrMucHuongSoMoi
            // 
            this.xrMucHuongSoMoi.Name = "xrMucHuongSoMoi";
            this.xrMucHuongSoMoi.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrMucHuongSoMoi.StylePriority.UsePadding = false;
            this.xrMucHuongSoMoi.StylePriority.UseTextAlignment = false;
            this.xrMucHuongSoMoi.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrMucHuongSoMoi.Weight = 0.24617714851044442D;
            // 
            // xrMucHuongSoChenhLech
            // 
            this.xrMucHuongSoChenhLech.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrMucHuongSoChenhLech.Name = "xrMucHuongSoChenhLech";
            this.xrMucHuongSoChenhLech.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrMucHuongSoChenhLech.StylePriority.UseBorders = false;
            this.xrMucHuongSoChenhLech.StylePriority.UsePadding = false;
            this.xrMucHuongSoChenhLech.StylePriority.UseTextAlignment = false;
            this.xrMucHuongSoChenhLech.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrMucHuongSoChenhLech.Weight = 0.24800883767573842D;
            // 
            // xrSoNgayThucSoChenhLech
            // 
            this.xrSoNgayThucSoChenhLech.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrSoNgayThucSoChenhLech.Name = "xrSoNgayThucSoChenhLech";
            this.xrSoNgayThucSoChenhLech.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrSoNgayThucSoChenhLech.SnapLineMargin = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrSoNgayThucSoChenhLech.StylePriority.UseBorders = false;
            this.xrSoNgayThucSoChenhLech.StylePriority.UsePadding = false;
            this.xrSoNgayThucSoChenhLech.StylePriority.UseTextAlignment = false;
            this.xrSoNgayThucSoChenhLech.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrSoNgayThucSoChenhLech.Weight = 0.28456218565815822D;
            // 
            // xrSoNgayThucNghiLuyKe
            // 
            this.xrSoNgayThucNghiLuyKe.Name = "xrSoNgayThucNghiLuyKe";
            this.xrSoNgayThucNghiLuyKe.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrSoNgayThucNghiLuyKe.StylePriority.UsePadding = false;
            this.xrSoNgayThucNghiLuyKe.StylePriority.UseTextAlignment = false;
            this.xrSoNgayThucNghiLuyKe.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrSoNgayThucNghiLuyKe.Weight = 0.28456134476887679D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell94.StylePriority.UsePadding = false;
            this.xrTableCell94.StylePriority.UseTextAlignment = false;
            this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell94.Weight = 0.56862830878933046D;
            // 
            // rp_austfeed_subDS
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(21, 69, 100, 14);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
