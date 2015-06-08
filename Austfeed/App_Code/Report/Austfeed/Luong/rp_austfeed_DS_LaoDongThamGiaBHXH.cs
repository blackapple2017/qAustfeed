﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DataController;

/// <summary>
/// Summary description for rp_austfeed_DS_LaoDongThamGiaBHXH
/// </summary>
public class rp_austfeed_DS_LaoDongThamGiaBHXH : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private XRLabel xrLabel1;
    private PageHeaderBand PageHeader;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrBoPhan;
    private XRTableCell xrYT_NV;
    private XRTableCell xrTongCongRow;
    private XRTableCell xrTableCell28;
    private XRTableCell xrMaCB;
    private XRTableCell xrHoTen;
    private XRTableCell xrSoSo;
    private XRTableCell xrThoiGianDongBH;
    private XRTableCell xrLuongDongBH;
    private XRTableCell xrBH_Cty;
    private XRTableCell xrYT_Cty;
    private XRTableCell xrTN_Cty;
    private XRTableCell xrBH_NV;
    private XRTableCell xrTN_NV;
    private XRTableCell xrBH_T;
    private XRTableCell xrYT_T;
    private XRTableCell xrTN_T;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell44;
    private ReportFooterBand ReportFooter;
    private XRLabel xrLabel6;
    private XRLabel xrLabel7;
    private XRLabel xrLabel8;
    private XRLabel xrLabel9;
    private GroupHeaderBand GroupHeader1;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell47;
    private XRTableCell xrTableCell48;
    private XRTableCell xrTableCell49;
    private XRTableCell xrTableCell50;
    private XRTableCell xrTableCell51;
    private XRTableCell xrTableCell52;
    private XRTableCell xrTableCell53;
    private XRTableCell xrTableCell54;
    private XRTableCell xrTableCell55;
    private XRTableCell xrTableCell56;
    private XRTableCell xrTableCell57;
    private XRTableCell xrTableCell58;
    private XRTableCell xrTableCell59;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell64;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell70;
    private XRTableCell xrTableCell71;
    private XRTableCell xrTableCell72;
    private XRTableCell xrTableCell73;
    private XRTableCell xrTableCell74;
    private XRTableCell xrTableCell75;
    private XRTableCell xrTableCell76;
    private XRTableCell xrTableCell77;
    private XRTableCell xrTableCell78;
    private XRTableCell xrTableCell79;
    private XRTableCell xrTableCell80;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell82;
    private XRTableCell xrTableCell83;
    private XRTableCell xrTableCell84;
    private XRTable xrTable9;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
    private XRTableCell xrTableCell85;
    private XRTableCell xrTableCell86;
    private XRTableCell xrTableCell87;
    private XRTableCell xrTableCell88;
    private XRTableCell xrTableCell89;
    private XRTableCell xrTableCell90;
    private XRTableCell xrTableCell91;
    private XRTableCell xrTableCell92;
    private XRTableCell xrTableCell93;
    private XRTableCell xrTableCell94;
    private XRTable xrTable10;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell95;
    private XRTableCell xrTableCell96;
    private XRTableCell xrTableCell97;
    private XRTableCell xrTableCell98;
    private XRTableCell xrTableCell99;
    private XRTableCell xrTableCell100;
    private XRTableCell xrTableCell101;
    private XRTableCell xrTableCell102;
    private XRTableCell xrTableCell103;
    private XRTableCell xrTableCell104;
    private XRTableCell xrTableCell105;
    private XRTableCell xrTableCell106;
    private XRTableCell xrTableCell107;
    private XRTableCell xrTableCell108;
    private XRTableCell xrTableCell109;
    private XRTable xrTable11;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell110;
    private XRTableCell xrTableCell111;
    private XRTableCell xrTableCell112;
    private XRTableCell xrTableCell117;
    private XRTableCell xrTableCell118;
    private XRTableCell xrTableCell119;
    private XRTableCell xrTableCell120;
    private XRTableCell xrTableCell121;
    private XRTableCell xrTableCell122;
    private XRTableCell xrTableCell123;
    private XRTableCell xrTableCell124;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell125;
    private XRTableCell xrTableCell126;
    private XRTableCell xrTableCell127;
    private XRTableCell xrTableCell130;
    private XRTableCell xrTableCell132;
    private XRTableCell xrTableCell133;
    private XRTableCell xrTableCell134;
    private XRTableCell xrTableCell135;
    private XRTableCell xrTableCell136;
    private XRTableCell xrTableCell137;
    private XRTableCell xrTableCell138;
    private XRTableCell xrTableCell139;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell25;
    private XRTableCell xrTableCell26;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell33;
    private XRTableCell xrTableCell34;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell140;
    private XRTableCell xrTableCell141;
    private XRTableCell xrTableCell144;
    private XRTableCell xrTableCell146;
    private XRTableCell xrTableCell147;
    private XRTableCell xrTableCell148;
    private XRTableCell xrTableCell149;
    private XRTableCell xrTableCell150;
    private XRTableCell xrTableCell151;
    private XRTableCell xrTableCell152;
    private XRTableCell xrTableCell153;
    private XRTableRow xrTableRow15;
    private XRTableCell xrTableCell154;
    private XRTableCell xrTableCell155;
    private XRTableCell xrTableCell156;
    private XRTableCell xrTableCell159;
    private XRTableCell xrTableCell161;
    private XRTableCell xrTableCell162;
    private XRTableCell xrTableCell163;
    private XRTableCell xrTableCell164;
    private XRTableCell xrTableCell165;
    private XRTableCell xrTableCell166;
    private XRTableCell xrTableCell167;
    private XRTableCell xrTableCell168;
    private XRTableRow xrTableRow16;
    private XRTableCell xrTableCell169;
    private XRTableCell xrTableCell174;
    private XRTableCell xrTableCell176;
    private XRTableCell xrTableCell177;
    private XRTableCell xrTableCell178;
    private XRTableCell xrTableCell179;
    private XRTableCell xrTableCell180;
    private XRTableCell xrTableCell181;
    private XRTableCell xrTableCell182;
    private XRTableCell xrTableCell183;
    private XRTableRow xrTableRow17;
    private XRTableCell xrTableCell184;
    private XRTableCell xrTableCell185;
    private XRTableCell xrTableCell186;
    private XRTableCell xrTableCell189;
    private XRTableCell xrTableCell190;
    private XRTableCell xrTableCell191;
    private XRTableCell xrTableCell192;
    private XRTableCell xrTableCell193;
    private XRTableCell xrTableCell194;
    private XRTableCell xrTableCell195;
    private XRTableCell xrTableCell196;
    private XRTableCell xrTableCell197;
    private XRTableCell xrTableCell198;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell175;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell8;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell9;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell13;
    private XRTableCell xrTableCell14;
    private XRLabel xrLabel2;
    private XRTableCell xrTableCell6;
    private XRLabel xrLabel3;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell11;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell19;
    private XRTableCell xrTableCell20;
    private XRLabel xrLabel4;
    private XRTableCell xrTableCell21;
    private XRLabel xrLabel5;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTableCell xrTableCell24;
    private XRTableCell xrTableCell3;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rp_austfeed_DS_LaoDongThamGiaBHXH()
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
    private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
    {
        xrTableCell28.Text = STT.ToString();
        STT++;
    }
    public void BindData(ReportFilter filter)
    {
        if (!string.IsNullOrEmpty(filter.ReportTitle))
        {
            xrLabel1.Text = filter.ReportTitle.ToUpper();
        }        
        xrLabel1.Text += " " + filter.StartMonth + "/" + filter.Year;
        xrTableCell10.Text = "T"+ filter.StartMonth + "/" + filter.Year;
        if (!string.IsNullOrEmpty(filter.Title1))
        {
            xrLabel6.Text = filter.Title1;
        }
        if (!string.IsNullOrEmpty(filter.Title2))
        {
            xrLabel8.Text = filter.Title2;
        }
        if (!string.IsNullOrEmpty(filter.Name1))
        {
            xrLabel7.Text = filter.Name1;
        }
        if (!string.IsNullOrEmpty(filter.Name3))
        {
            xrLabel9.Text = filter.Name3;
        }
        DataSource = DataHandler.GetInstance().ExecuteDataTable("rp_DanhSachLaoDongThamGiaBHXHTheoThang", "@Month", "@Year", "@MaDonVi", "@MaBoPhan", "@PRKEY", "@WhereClause", filter.StartMonth, filter.Year, filter.SessionDepartment, filter.SelectedDepartment, filter.EmployeeCode, filter.WhereClause);
        xrMaCB.DataBindings.Add("Text", DataSource, "MA_CB");
        xrHoTen.DataBindings.Add("Text", DataSource, "HO_TEN");
        xrBoPhan.DataBindings.Add("Text", DataSource, "BoPhan");
        xrSoSo.DataBindings.Add("Text", DataSource, "SOSO");
        xrThoiGianDongBH.DataBindings.Add("Text", DataSource, "THOIGIAN_DONGBAOHIEM");
        xrLuongDongBH.DataBindings.Add("Text", DataSource, "LuongDongBH", "{0:n0}");
        xrBH_Cty.DataBindings.Add("Text", DataSource, "BHXH_CongTy",  "{0:n0}");
        xrYT_Cty.DataBindings.Add("Text", DataSource, "BHYT_CongTy", "{0:n0}");
        xrTN_Cty.DataBindings.Add("Text", DataSource, "BHTN_CongTy", "{0:n0}");
        xrBH_NV.DataBindings.Add("Text", DataSource, "BHXH_LaoDong", "{0:n0}");
        xrYT_NV.DataBindings.Add("Text", DataSource, "BHYT_LaoDong", "{0:n0}");
        xrTN_NV.DataBindings.Add("Text", DataSource, "BHTN_LaoDong", "{0:n0}");
        xrBH_T.DataBindings.Add("Text", DataSource, "BHXH_Tong", "{0:n0}");
        xrYT_T.DataBindings.Add("Text", DataSource, "BHYT_Tong", "{0:n0}");
        xrTN_T.DataBindings.Add("Text", DataSource, "BHTN_Tong", "{0:n0}");
        //xrTableCell44.DataBindings.Add("Text", DataSource, "");
        //xrTableCell45.DataBindings.Add("Text", DataSource, "");
        //xrTableCell46.DataBindings.Add("Text", DataSource, "");
        xrTongCongRow.DataBindings.Add("Text", DataSource, "TongCong", "{0:n0}");
        this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("BoPhan", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
        xrTableCell47.DataBindings.Add("Text", DataSource, "BoPhan");
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary13 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell51.DataBindings.Add("Text", DataSource, "LuongDongBH");
        xrSummary13.FormatString = "{0:n0}";
        xrSummary13.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary13.Func = SummaryFunc.Sum;
        xrTableCell51.Summary = xrSummary13;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary14 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell52.DataBindings.Add("Text", DataSource, "BHXH_CongTy");
        xrSummary14.FormatString = "{0:n0}";
        xrSummary14.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary14.Func = SummaryFunc.Sum;
        xrTableCell52.Summary = xrSummary14;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary15 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell53.DataBindings.Add("Text", DataSource, "BHYT_CongTy");
        xrSummary15.FormatString = "{0:n0}";
        xrSummary15.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary15.Func = SummaryFunc.Sum;
        xrTableCell53.Summary = xrSummary15;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary16 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell54.DataBindings.Add("Text", DataSource, "BHTN_CongTy");
        xrSummary16.FormatString = "{0:n0}";
        xrSummary16.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary16.Func = SummaryFunc.Sum;
        xrTableCell54.Summary = xrSummary16;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary17 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell55.DataBindings.Add("Text", DataSource, "BHXH_LaoDong");
        xrSummary17.FormatString = "{0:n0}";
        xrSummary17.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary17.Func = SummaryFunc.Sum;
        xrTableCell55.Summary = xrSummary17;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary18 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell56.DataBindings.Add("Text", DataSource, "BHYT_LaoDong");
        xrSummary18.FormatString = "{0:n0}";
        xrSummary18.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary18.Func = SummaryFunc.Sum;
        xrTableCell56.Summary = xrSummary18;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary19 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell57.DataBindings.Add("Text", DataSource, "BHTN_LaoDong");
        xrSummary19.FormatString = "{0:n0}";
        xrSummary19.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary19.Func = SummaryFunc.Sum;
        xrTableCell57.Summary = xrSummary19;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary20 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell58.DataBindings.Add("Text", DataSource, "BHXH_Tong");
        xrSummary20.FormatString = "{0:n0}";
        xrSummary20.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary20.Func = SummaryFunc.Sum;
        xrTableCell58.Summary = xrSummary20;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary21 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell59.DataBindings.Add("Text", DataSource, "BHYT_Tong");
        xrSummary21.FormatString = "{0:n0}";
        xrSummary21.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary21.Func = SummaryFunc.Sum;
        xrTableCell59.Summary = xrSummary21;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary22 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell60.DataBindings.Add("Text", DataSource, "BHTN_Tong");
        xrSummary22.FormatString = "{0:n0}";
        xrSummary22.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary22.Func = SummaryFunc.Sum;
        xrTableCell60.Summary = xrSummary22;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary23 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell64.DataBindings.Add("Text", DataSource, "TongCong");
        xrSummary23.FormatString = "{0:n0}";
        xrSummary23.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
        xrSummary23.Func = SummaryFunc.Sum;
        xrTableCell64.Summary = xrSummary23;

        // sum report
        DevExpress.XtraReports.UI.XRSummary xrSummary24 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell71.DataBindings.Add("Text", DataSource, "LuongDongBH");
        xrSummary24.FormatString = "{0:n0}";
        xrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary24.Func = SummaryFunc.Sum;
        xrTableCell71.Summary = xrSummary24;
        // sum group
        DevExpress.XtraReports.UI.XRSummary xrSummary25 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell72.DataBindings.Add("Text", DataSource, "BHXH_CongTy");
        xrSummary25.FormatString = "{0:n0}";
        xrSummary25.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary25.Func = SummaryFunc.Sum;
        xrTableCell72.Summary = xrSummary25;
        // sum Report
        DevExpress.XtraReports.UI.XRSummary xrSummary26 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell73.DataBindings.Add("Text", DataSource, "BHYT_CongTy");
        xrSummary26.FormatString = "{0:n0}";
        xrSummary26.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary26.Func = SummaryFunc.Sum;
        xrTableCell73.Summary = xrSummary26;
        // sum Report
        DevExpress.XtraReports.UI.XRSummary xrSummary27 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell74.DataBindings.Add("Text", DataSource, "BHTN_CongTy");
        xrSummary27.FormatString = "{0:n0}";
        xrSummary27.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary27.Func = SummaryFunc.Sum;
        xrTableCell74.Summary = xrSummary27;
        // sum Report
        DevExpress.XtraReports.UI.XRSummary xrSummary28 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell75.DataBindings.Add("Text", DataSource, "BHXH_LaoDong");
        xrSummary28.FormatString = "{0:n0}";
        xrSummary28.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary28.Func = SummaryFunc.Sum;
        xrTableCell75.Summary = xrSummary28;
        // sum Report
        DevExpress.XtraReports.UI.XRSummary xrSummary29 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell76.DataBindings.Add("Text", DataSource, "BHYT_LaoDong");
        xrSummary29.FormatString = "{0:n0}";
        xrSummary29.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary29.Func = SummaryFunc.Sum;
        xrTableCell76.Summary = xrSummary29;
        // sum Report
        DevExpress.XtraReports.UI.XRSummary xrSummary30 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell77.DataBindings.Add("Text", DataSource, "BHTN_LaoDong");
        xrSummary30.FormatString = "{0:n0}";
        xrSummary30.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary30.Func = SummaryFunc.Sum;
        xrTableCell77.Summary = xrSummary30;
        // sum Report
        DevExpress.XtraReports.UI.XRSummary xrSummary31 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell78.DataBindings.Add("Text", DataSource, "BHXH_Tong");
        xrSummary31.FormatString = "{0:n0}";
        xrSummary31.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary31.Func = SummaryFunc.Sum;
        xrTableCell78.Summary = xrSummary31;
        // sum Report
        DevExpress.XtraReports.UI.XRSummary xrSummary32 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell79.DataBindings.Add("Text", DataSource, "BHYT_Tong");
        xrSummary32.FormatString = "{0:n0}";
        xrSummary32.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary32.Func = SummaryFunc.Sum;
        xrTableCell79.Summary = xrSummary32;
        // sum Report
        DevExpress.XtraReports.UI.XRSummary xrSummary33 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell80.DataBindings.Add("Text", DataSource, "BHTN_Tong");
        xrSummary33.FormatString = "{0:n0}";
        xrSummary33.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary33.Func = SummaryFunc.Sum;
        xrTableCell80.Summary = xrSummary33;
        // sum Report
        DevExpress.XtraReports.UI.XRSummary xrSummary34 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell84.DataBindings.Add("Text", DataSource, "TongCong");
        xrSummary34.FormatString = "{0:n0}";
        xrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary34.Func = SummaryFunc.Sum;
        xrTableCell84.Summary = xrSummary34;
        // tong luong bh
        xrTableCell111.DataBindings.Add("Text", DataSource, "LuongDongBH");
        xrSummary24.FormatString = "{0:n0}";
        xrSummary24.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary24.Func = SummaryFunc.Sum;
        xrTableCell111.Summary = xrSummary24;
        // tongtien bh 
        xrTableCell126.DataBindings.Add("Text", DataSource, "TongCong");
        xrSummary34.FormatString = "{0:n0}";
        xrSummary34.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary34.Func = SummaryFunc.Sum;
        xrTableCell126.Summary = xrSummary34;
        // tổng số lao động
        DevExpress.XtraReports.UI.XRSummary xrSummary35 = new DevExpress.XtraReports.UI.XRSummary();
        xrTableCell26.DataBindings.Add("Text", DataSource, "MA_CB");
        xrSummary35.FormatString = "{0:n0}";
        xrSummary35.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
        xrSummary35.Func = SummaryFunc.Count;
        xrTableCell26.Summary = xrSummary35;
        
    }
    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            string resourceFileName = "rp_austfeed_DS_LaoDongThamGiaBHXH.resx";
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrMaCB = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrHoTen = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBoPhan = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrSoSo = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrThoiGianDongBH = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLuongDongBH = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBH_Cty = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrYT_Cty = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTN_Cty = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBH_NV = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrYT_NV = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTN_NV = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrBH_T = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrYT_T = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTN_T = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTongCongRow = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell110 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell111 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell112 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell117 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell118 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell119 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell120 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell121 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell122 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell123 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell124 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell125 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell126 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell127 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell130 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell132 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell133 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell134 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell135 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell136 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell137 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell138 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell139 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell140 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell141 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell144 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell146 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell147 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell148 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell149 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell150 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell151 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell152 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell153 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow15 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell154 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell155 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell156 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell159 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell161 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell162 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell163 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell164 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell165 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell166 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell167 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell168 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow17 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell184 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell185 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell186 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell189 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell190 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell191 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell192 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell193 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell194 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell195 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell196 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell197 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell198 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow16 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell169 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell174 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell175 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell176 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell177 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell178 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell179 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell180 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell181 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell182 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell183 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell101 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell102 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell103 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell104 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell105 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell106 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell107 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell108 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell109 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell85 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell86 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell87 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell88 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell89 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell90 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell91 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell92 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell93 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell94 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell71 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell72 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell73 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell74 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell75 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell76 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell77 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell78 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell79 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
            this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6});
            this.Detail.HeightF = 30F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable6
            // 
            this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable6.Name = "xrTable6";
            this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
            this.xrTable6.SizeF = new System.Drawing.SizeF(1128F, 30F);
            this.xrTable6.StylePriority.UseBorders = false;
            // 
            // xrTableRow6
            // 
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell28,
            this.xrMaCB,
            this.xrHoTen,
            this.xrBoPhan,
            this.xrSoSo,
            this.xrThoiGianDongBH,
            this.xrLuongDongBH,
            this.xrBH_Cty,
            this.xrYT_Cty,
            this.xrTN_Cty,
            this.xrBH_NV,
            this.xrYT_NV,
            this.xrTN_NV,
            this.xrBH_T,
            this.xrYT_T,
            this.xrTN_T,
            this.xrTableCell42,
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTongCongRow});
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.Weight = 1D;
            // 
            // xrTableCell28
            // 
            this.xrTableCell28.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell28.Name = "xrTableCell28";
            this.xrTableCell28.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell28.StylePriority.UseFont = false;
            this.xrTableCell28.StylePriority.UsePadding = false;
            this.xrTableCell28.Weight = 0.080213922333137413D;
            this.xrTableCell28.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrMaCB
            // 
            this.xrMaCB.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrMaCB.Name = "xrMaCB";
            this.xrMaCB.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrMaCB.StylePriority.UseFont = false;
            this.xrMaCB.StylePriority.UsePadding = false;
            this.xrMaCB.Weight = 0.15104770199767634D;
            // 
            // xrHoTen
            // 
            this.xrHoTen.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrHoTen.Name = "xrHoTen";
            this.xrHoTen.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrHoTen.StylePriority.UseFont = false;
            this.xrHoTen.StylePriority.UsePadding = false;
            this.xrHoTen.Weight = 0.30085890255642417D;
            // 
            // xrBoPhan
            // 
            this.xrBoPhan.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrBoPhan.Name = "xrBoPhan";
            this.xrBoPhan.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrBoPhan.StylePriority.UseFont = false;
            this.xrBoPhan.StylePriority.UsePadding = false;
            this.xrBoPhan.Weight = 0.24891384304416639D;
            // 
            // xrSoSo
            // 
            this.xrSoSo.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrSoSo.Name = "xrSoSo";
            this.xrSoSo.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrSoSo.StylePriority.UseFont = false;
            this.xrSoSo.StylePriority.UsePadding = false;
            this.xrSoSo.Weight = 0.17895474803052666D;
            // 
            // xrThoiGianDongBH
            // 
            this.xrThoiGianDongBH.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrThoiGianDongBH.Name = "xrThoiGianDongBH";
            this.xrThoiGianDongBH.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrThoiGianDongBH.StylePriority.UseFont = false;
            this.xrThoiGianDongBH.StylePriority.UsePadding = false;
            this.xrThoiGianDongBH.Weight = 0.12723135240693348D;
            // 
            // xrLuongDongBH
            // 
            this.xrLuongDongBH.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrLuongDongBH.Name = "xrLuongDongBH";
            this.xrLuongDongBH.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrLuongDongBH.StylePriority.UseFont = false;
            this.xrLuongDongBH.StylePriority.UsePadding = false;
            this.xrLuongDongBH.StylePriority.UseTextAlignment = false;
            this.xrLuongDongBH.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLuongDongBH.Weight = 0.1672226950177908D;
            // 
            // xrBH_Cty
            // 
            this.xrBH_Cty.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrBH_Cty.Name = "xrBH_Cty";
            this.xrBH_Cty.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrBH_Cty.StylePriority.UseFont = false;
            this.xrBH_Cty.StylePriority.UsePadding = false;
            this.xrBH_Cty.StylePriority.UseTextAlignment = false;
            this.xrBH_Cty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrBH_Cty.Weight = 0.13313829757467929D;
            // 
            // xrYT_Cty
            // 
            this.xrYT_Cty.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrYT_Cty.Name = "xrYT_Cty";
            this.xrYT_Cty.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrYT_Cty.StylePriority.UseFont = false;
            this.xrYT_Cty.StylePriority.UsePadding = false;
            this.xrYT_Cty.StylePriority.UseTextAlignment = false;
            this.xrYT_Cty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrYT_Cty.Weight = 0.13314543617218461D;
            // 
            // xrTN_Cty
            // 
            this.xrTN_Cty.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTN_Cty.Name = "xrTN_Cty";
            this.xrTN_Cty.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTN_Cty.StylePriority.UseFont = false;
            this.xrTN_Cty.StylePriority.UsePadding = false;
            this.xrTN_Cty.StylePriority.UseTextAlignment = false;
            this.xrTN_Cty.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTN_Cty.Weight = 0.13314202254000154D;
            // 
            // xrBH_NV
            // 
            this.xrBH_NV.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrBH_NV.Name = "xrBH_NV";
            this.xrBH_NV.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrBH_NV.StylePriority.UseFont = false;
            this.xrBH_NV.StylePriority.UsePadding = false;
            this.xrBH_NV.StylePriority.UseTextAlignment = false;
            this.xrBH_NV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrBH_NV.Weight = 0.13313845110544068D;
            // 
            // xrYT_NV
            // 
            this.xrYT_NV.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrYT_NV.Name = "xrYT_NV";
            this.xrYT_NV.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrYT_NV.StylePriority.UseFont = false;
            this.xrYT_NV.StylePriority.UsePadding = false;
            this.xrYT_NV.StylePriority.UseTextAlignment = false;
            this.xrYT_NV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrYT_NV.Weight = 0.13313813168672664D;
            // 
            // xrTN_NV
            // 
            this.xrTN_NV.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTN_NV.Name = "xrTN_NV";
            this.xrTN_NV.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTN_NV.StylePriority.UseFont = false;
            this.xrTN_NV.StylePriority.UsePadding = false;
            this.xrTN_NV.StylePriority.UseTextAlignment = false;
            this.xrTN_NV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTN_NV.Weight = 0.13313861374341213D;
            // 
            // xrBH_T
            // 
            this.xrBH_T.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrBH_T.Name = "xrBH_T";
            this.xrBH_T.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrBH_T.StylePriority.UseFont = false;
            this.xrBH_T.StylePriority.UsePadding = false;
            this.xrBH_T.StylePriority.UseTextAlignment = false;
            this.xrBH_T.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrBH_T.Weight = 0.13313796880330003D;
            // 
            // xrYT_T
            // 
            this.xrYT_T.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrYT_T.Name = "xrYT_T";
            this.xrYT_T.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrYT_T.StylePriority.UseFont = false;
            this.xrYT_T.StylePriority.UsePadding = false;
            this.xrYT_T.StylePriority.UseTextAlignment = false;
            this.xrYT_T.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrYT_T.Weight = 0.13313813145811662D;
            // 
            // xrTN_T
            // 
            this.xrTN_T.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTN_T.Name = "xrTN_T";
            this.xrTN_T.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTN_T.StylePriority.UseFont = false;
            this.xrTN_T.StylePriority.UsePadding = false;
            this.xrTN_T.StylePriority.UseTextAlignment = false;
            this.xrTN_T.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTN_T.Weight = 0.13313862055839681D;
            // 
            // xrTableCell42
            // 
            this.xrTableCell42.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell42.Name = "xrTableCell42";
            this.xrTableCell42.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell42.StylePriority.UseFont = false;
            this.xrTableCell42.StylePriority.UsePadding = false;
            this.xrTableCell42.StylePriority.UseTextAlignment = false;
            this.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell42.Weight = 0.13313829553753442D;
            // 
            // xrTableCell43
            // 
            this.xrTableCell43.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell43.Name = "xrTableCell43";
            this.xrTableCell43.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell43.StylePriority.UseFont = false;
            this.xrTableCell43.StylePriority.UsePadding = false;
            this.xrTableCell43.StylePriority.UseTextAlignment = false;
            this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell43.Weight = 0.13313845747042455D;
            // 
            // xrTableCell44
            // 
            this.xrTableCell44.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell44.Name = "xrTableCell44";
            this.xrTableCell44.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell44.StylePriority.UseFont = false;
            this.xrTableCell44.StylePriority.UsePadding = false;
            this.xrTableCell44.StylePriority.UseTextAlignment = false;
            this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell44.Weight = 0.13313763803109122D;
            // 
            // xrTongCongRow
            // 
            this.xrTongCongRow.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTongCongRow.Name = "xrTongCongRow";
            this.xrTongCongRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTongCongRow.StylePriority.UseFont = false;
            this.xrTongCongRow.StylePriority.UsePadding = false;
            this.xrTongCongRow.StylePriority.UseTextAlignment = false;
            this.xrTongCongRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTongCongRow.Weight = 0.14788676993203609D;
            // 
            // TopMargin
            // 
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
            this.xrLabel1});
            this.ReportHeader.HeightF = 71.95834F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(1128F, 71.95834F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "DANH SÁCH LAO ĐỘNG THAM GIA BHXH 03/2014";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // PageHeader
            // 
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.PageHeader.HeightF = 62.5F;
            this.PageHeader.Name = "PageHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(1128F, 62.5F);
            this.xrTable1.StylePriority.UseBorders = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell7,
            this.xrTableCell1,
            this.xrTableCell5,
            this.xrTableCell2,
            this.xrTableCell8,
            this.xrTableCell10,
            this.xrTableCell9,
            this.xrTableCell6,
            this.xrTableCell11,
            this.xrTableCell21,
            this.xrTableCell3});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.Text = "STT";
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell4.Weight = 0.0845877435518297D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseFont = false;
            this.xrTableCell7.StylePriority.UseTextAlignment = false;
            this.xrTableCell7.Text = "Mã NV";
            this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell7.Weight = 0.1592839384619833D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Họ và tên";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell1.Weight = 0.32026461886216739D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.Text = "Bộ phận";
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell5.Weight = 0.26389017029618522D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.StylePriority.UseFont = false;
            this.xrTableCell2.StylePriority.UseTextAlignment = false;
            this.xrTableCell2.Text = "soso";
            this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell2.Weight = 0.18972180487989235D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.StylePriority.UseFont = false;
            this.xrTableCell8.StylePriority.UseTextAlignment = false;
            this.xrTableCell8.Text = "Thời gian đóng BHXH";
            this.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell8.Weight = 0.13488641171191718D;
            // 
            // xrTableCell10
            // 
            this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UseFont = false;
            this.xrTableCell10.StylePriority.UseTextAlignment = false;
            this.xrTableCell10.Text = "T03/2014";
            this.xrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell10.Weight = 0.17728394194818331D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrLabel2});
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Weight = 0.4234576984196271D;
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.45832F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(150.184F, 36.04168F);
            this.xrTable2.StylePriority.UseBorders = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // xrTableCell12
            // 
            this.xrTableCell12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.StylePriority.UseBorders = false;
            this.xrTableCell12.StylePriority.UseFont = false;
            this.xrTableCell12.StylePriority.UseTextAlignment = false;
            this.xrTableCell12.Text = "BHXH 18%";
            this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell12.Weight = 1D;
            // 
            // xrTableCell13
            // 
            this.xrTableCell13.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.StylePriority.UseFont = false;
            this.xrTableCell13.StylePriority.UseTextAlignment = false;
            this.xrTableCell13.Text = "BHYT 3%";
            this.xrTableCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell13.Weight = 1D;
            // 
            // xrTableCell14
            // 
            this.xrTableCell14.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell14.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.StylePriority.UseBorders = false;
            this.xrTableCell14.StylePriority.UseFont = false;
            this.xrTableCell14.StylePriority.UseTextAlignment = false;
            this.xrTableCell14.Text = "BHTN 1%";
            this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell14.Weight = 1D;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(150.1842F, 26.45833F);
            this.xrLabel2.StylePriority.UseBorders = false;
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "Số tiền Công ty đóng";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel3,
            this.xrTable3});
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Weight = 0.42344621035401808D;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(150.1801F, 26.45832F);
            this.xrLabel3.StylePriority.UseBorders = false;
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "Số tiền người lao động đóng";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable3
            // 
            this.xrTable3.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 26.45832F);
            this.xrTable3.Name = "xrTable3";
            this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
            this.xrTable3.SizeF = new System.Drawing.SizeF(150.18F, 36.04168F);
            this.xrTable3.StylePriority.UseBorders = false;
            // 
            // xrTableRow3
            // 
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17});
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 1D;
            // 
            // xrTableCell15
            // 
            this.xrTableCell15.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.StylePriority.UseBorders = false;
            this.xrTableCell15.StylePriority.UseFont = false;
            this.xrTableCell15.StylePriority.UseTextAlignment = false;
            this.xrTableCell15.Text = "BHXH 8%";
            this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell15.Weight = 1.2340399546709158D;
            // 
            // xrTableCell16
            // 
            this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.StylePriority.UseFont = false;
            this.xrTableCell16.StylePriority.UseTextAlignment = false;
            this.xrTableCell16.Text = "BHYT 1,5%";
            this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell16.Weight = 1.2340399227546768D;
            // 
            // xrTableCell17
            // 
            this.xrTableCell17.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.StylePriority.UseBorders = false;
            this.xrTableCell17.StylePriority.UseFont = false;
            this.xrTableCell17.StylePriority.UseTextAlignment = false;
            this.xrTableCell17.Text = "BHTN 1%";
            this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell17.Weight = 1.2340399646678542D;
            // 
            // xrTableCell11
            // 
            this.xrTableCell11.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4,
            this.xrLabel4});
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Weight = 0.42344623586460128D;
            // 
            // xrTable4
            // 
            this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.45832F);
            this.xrTable4.Name = "xrTable4";
            this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
            this.xrTable4.SizeF = new System.Drawing.SizeF(150.18F, 36.04168F);
            // 
            // xrTableRow4
            // 
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20});
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 1D;
            // 
            // xrTableCell18
            // 
            this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell18.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell18.Name = "xrTableCell18";
            this.xrTableCell18.StylePriority.UseBorders = false;
            this.xrTableCell18.StylePriority.UseFont = false;
            this.xrTableCell18.StylePriority.UseTextAlignment = false;
            this.xrTableCell18.Text = "BHXH 26%";
            this.xrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell18.Weight = 0.90516291676499339D;
            // 
            // xrTableCell19
            // 
            this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell19.Name = "xrTableCell19";
            this.xrTableCell19.StylePriority.UseFont = false;
            this.xrTableCell19.StylePriority.UseTextAlignment = false;
            this.xrTableCell19.Text = "BHYT 4,5%";
            this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell19.Weight = 0.90516286162501514D;
            // 
            // xrTableCell20
            // 
            this.xrTableCell20.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell20.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell20.Name = "xrTableCell20";
            this.xrTableCell20.StylePriority.UseBorders = false;
            this.xrTableCell20.StylePriority.UseFont = false;
            this.xrTableCell20.StylePriority.UseTextAlignment = false;
            this.xrTableCell20.Text = "BHTN 2%";
            this.xrTableCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell20.Weight = 0.90516287008112661D;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(150.18F, 26.45832F);
            this.xrLabel4.StylePriority.UseBorders = false;
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Tổng cộng";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTableCell21
            // 
            this.xrTableCell21.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel5,
            this.xrTable5});
            this.xrTableCell21.Name = "xrTableCell21";
            this.xrTableCell21.Weight = 0.42344624155625904D;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(150.1801F, 26.45832F);
            this.xrLabel5.StylePriority.UseBorders = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "Số tiền điều chỉnh truy thu";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrTable5
            // 
            this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 26.45832F);
            this.xrTable5.Name = "xrTable5";
            this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
            this.xrTable5.SizeF = new System.Drawing.SizeF(150.18F, 36.04168F);
            // 
            // xrTableRow5
            // 
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24});
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.Weight = 1D;
            // 
            // xrTableCell22
            // 
            this.xrTableCell22.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTableCell22.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell22.Name = "xrTableCell22";
            this.xrTableCell22.StylePriority.UseBorders = false;
            this.xrTableCell22.StylePriority.UseFont = false;
            this.xrTableCell22.StylePriority.UseTextAlignment = false;
            this.xrTableCell22.Text = "BHXH 26%";
            this.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell22.Weight = 1.1615440881644787D;
            // 
            // xrTableCell23
            // 
            this.xrTableCell23.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell23.Name = "xrTableCell23";
            this.xrTableCell23.StylePriority.UseFont = false;
            this.xrTableCell23.StylePriority.UseTextAlignment = false;
            this.xrTableCell23.Text = "BHYT 4,5%";
            this.xrTableCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell23.Weight = 1.1615441299624327D;
            // 
            // xrTableCell24
            // 
            this.xrTableCell24.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell24.Name = "xrTableCell24";
            this.xrTableCell24.StylePriority.UseFont = false;
            this.xrTableCell24.StylePriority.UseTextAlignment = false;
            this.xrTableCell24.Text = "BHTN 2%";
            this.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell24.Weight = 1.1615440736616645D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseFont = false;
            this.xrTableCell3.StylePriority.UseTextAlignment = false;
            this.xrTableCell3.Text = "Cộng (32.5% +truy thu)";
            this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell3.Weight = 0.15678417649752433D;
            // 
            // ReportFooter
            // 
            this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable11,
            this.xrTable10,
            this.xrTable9,
            this.xrTable8,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6});
            this.ReportFooter.HeightF = 477F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // xrTable11
            // 
            this.xrTable11.BackColor = System.Drawing.SystemColors.Control;
            this.xrTable11.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable11.LocationFloat = new DevExpress.Utils.PointFloat(3.973643E-05F, 97.75F);
            this.xrTable11.Name = "xrTable11";
            this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11,
            this.xrTableRow12,
            this.xrTableRow13,
            this.xrTableRow14,
            this.xrTableRow15,
            this.xrTableRow17,
            this.xrTableRow16});
            this.xrTable11.SizeF = new System.Drawing.SizeF(1128F, 228.0833F);
            this.xrTable11.StylePriority.UseBackColor = false;
            this.xrTable11.StylePriority.UseBorders = false;
            // 
            // xrTableRow11
            // 
            this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell110,
            this.xrTableCell111,
            this.xrTableCell112,
            this.xrTableCell117,
            this.xrTableCell118,
            this.xrTableCell119,
            this.xrTableCell120,
            this.xrTableCell121,
            this.xrTableCell122,
            this.xrTableCell123,
            this.xrTableCell124});
            this.xrTableRow11.Name = "xrTableRow11";
            this.xrTableRow11.Weight = 1D;
            // 
            // xrTableCell110
            // 
            this.xrTableCell110.Name = "xrTableCell110";
            this.xrTableCell110.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell110.StylePriority.UsePadding = false;
            this.xrTableCell110.StylePriority.UseTextAlignment = false;
            this.xrTableCell110.Text = "Tổng quỹ lương";
            this.xrTableCell110.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell110.Weight = 1.0872204703688644D;
            // 
            // xrTableCell111
            // 
            this.xrTableCell111.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell111.Name = "xrTableCell111";
            this.xrTableCell111.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell111.StylePriority.UseFont = false;
            this.xrTableCell111.StylePriority.UsePadding = false;
            this.xrTableCell111.StylePriority.UseTextAlignment = false;
            this.xrTableCell111.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell111.Weight = 0.1672226950177908D;
            // 
            // xrTableCell112
            // 
            this.xrTableCell112.Name = "xrTableCell112";
            this.xrTableCell112.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell112.StylePriority.UsePadding = false;
            this.xrTableCell112.StylePriority.UseTextAlignment = false;
            this.xrTableCell112.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell112.Weight = 0.13313829757467929D;
            // 
            // xrTableCell117
            // 
            this.xrTableCell117.Name = "xrTableCell117";
            this.xrTableCell117.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell117.StylePriority.UsePadding = false;
            this.xrTableCell117.StylePriority.UseTextAlignment = false;
            this.xrTableCell117.Text = "Số tiền điều chỉnh truy thu";
            this.xrTableCell117.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell117.Weight = 0.66570265524776562D;
            // 
            // xrTableCell118
            // 
            this.xrTableCell118.Name = "xrTableCell118";
            this.xrTableCell118.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell118.StylePriority.UsePadding = false;
            this.xrTableCell118.StylePriority.UseTextAlignment = false;
            this.xrTableCell118.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell118.Weight = 0.13313796880330003D;
            // 
            // xrTableCell119
            // 
            this.xrTableCell119.Name = "xrTableCell119";
            this.xrTableCell119.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell119.StylePriority.UsePadding = false;
            this.xrTableCell119.StylePriority.UseTextAlignment = false;
            this.xrTableCell119.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell119.Weight = 0.13313813145811662D;
            // 
            // xrTableCell120
            // 
            this.xrTableCell120.Name = "xrTableCell120";
            this.xrTableCell120.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell120.StylePriority.UsePadding = false;
            this.xrTableCell120.StylePriority.UseTextAlignment = false;
            this.xrTableCell120.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell120.Weight = 0.13313862055839681D;
            // 
            // xrTableCell121
            // 
            this.xrTableCell121.Name = "xrTableCell121";
            this.xrTableCell121.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell121.StylePriority.UsePadding = false;
            this.xrTableCell121.StylePriority.UseTextAlignment = false;
            this.xrTableCell121.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell121.Weight = 0.13313829553753442D;
            // 
            // xrTableCell122
            // 
            this.xrTableCell122.Name = "xrTableCell122";
            this.xrTableCell122.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell122.StylePriority.UsePadding = false;
            this.xrTableCell122.StylePriority.UseTextAlignment = false;
            this.xrTableCell122.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell122.Weight = 0.13313845747042455D;
            // 
            // xrTableCell123
            // 
            this.xrTableCell123.Name = "xrTableCell123";
            this.xrTableCell123.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell123.StylePriority.UsePadding = false;
            this.xrTableCell123.StylePriority.UseTextAlignment = false;
            this.xrTableCell123.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell123.Weight = 0.13313763803109122D;
            // 
            // xrTableCell124
            // 
            this.xrTableCell124.Name = "xrTableCell124";
            this.xrTableCell124.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell124.StylePriority.UsePadding = false;
            this.xrTableCell124.StylePriority.UseTextAlignment = false;
            this.xrTableCell124.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell124.Weight = 0.14788676993203609D;
            // 
            // xrTableRow12
            // 
            this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell125,
            this.xrTableCell126,
            this.xrTableCell127,
            this.xrTableCell130,
            this.xrTableCell132,
            this.xrTableCell133,
            this.xrTableCell134,
            this.xrTableCell135,
            this.xrTableCell136,
            this.xrTableCell137,
            this.xrTableCell138,
            this.xrTableCell139});
            this.xrTableRow12.Name = "xrTableRow12";
            this.xrTableRow12.Weight = 1D;
            // 
            // xrTableCell125
            // 
            this.xrTableCell125.Name = "xrTableCell125";
            this.xrTableCell125.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell125.StylePriority.UsePadding = false;
            this.xrTableCell125.Text = "Tổng số phải đóng BHXH:(*)";
            this.xrTableCell125.Weight = 1.0872204703688644D;
            // 
            // xrTableCell126
            // 
            this.xrTableCell126.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell126.Name = "xrTableCell126";
            this.xrTableCell126.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell126.StylePriority.UseFont = false;
            this.xrTableCell126.StylePriority.UsePadding = false;
            this.xrTableCell126.StylePriority.UseTextAlignment = false;
            this.xrTableCell126.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell126.Weight = 0.1672226950177908D;
            // 
            // xrTableCell127
            // 
            this.xrTableCell127.Name = "xrTableCell127";
            this.xrTableCell127.Weight = 0.13313829757467929D;
            // 
            // xrTableCell130
            // 
            this.xrTableCell130.Name = "xrTableCell130";
            this.xrTableCell130.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell130.StylePriority.UsePadding = false;
            this.xrTableCell130.Text = "Truy thu tăng: (1)";
            this.xrTableCell130.Weight = 0.39942590981762682D;
            // 
            // xrTableCell132
            // 
            this.xrTableCell132.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell132.Name = "xrTableCell132";
            this.xrTableCell132.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell132.StylePriority.UseFont = false;
            this.xrTableCell132.StylePriority.UsePadding = false;
            this.xrTableCell132.StylePriority.UseTextAlignment = false;
            this.xrTableCell132.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell132.Weight = 0.26627674543013879D;
            // 
            // xrTableCell133
            // 
            this.xrTableCell133.Name = "xrTableCell133";
            this.xrTableCell133.Weight = 0.13313796880330003D;
            // 
            // xrTableCell134
            // 
            this.xrTableCell134.Name = "xrTableCell134";
            this.xrTableCell134.Weight = 0.13313813145811662D;
            // 
            // xrTableCell135
            // 
            this.xrTableCell135.Name = "xrTableCell135";
            this.xrTableCell135.Weight = 0.13313862055839681D;
            // 
            // xrTableCell136
            // 
            this.xrTableCell136.Name = "xrTableCell136";
            this.xrTableCell136.Weight = 0.13313829553753442D;
            // 
            // xrTableCell137
            // 
            this.xrTableCell137.Name = "xrTableCell137";
            this.xrTableCell137.Weight = 0.13313845747042455D;
            // 
            // xrTableCell138
            // 
            this.xrTableCell138.Name = "xrTableCell138";
            this.xrTableCell138.Weight = 0.13313763803109122D;
            // 
            // xrTableCell139
            // 
            this.xrTableCell139.Name = "xrTableCell139";
            this.xrTableCell139.Weight = 0.14788676993203609D;
            // 
            // xrTableRow13
            // 
            this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell31,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40});
            this.xrTableRow13.Name = "xrTableRow13";
            this.xrTableRow13.Weight = 1D;
            // 
            // xrTableCell25
            // 
            this.xrTableCell25.Name = "xrTableCell25";
            this.xrTableCell25.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell25.StylePriority.UsePadding = false;
            this.xrTableCell25.Text = "Tổng số lao động:";
            this.xrTableCell25.Weight = 1.0872204703688644D;
            // 
            // xrTableCell26
            // 
            this.xrTableCell26.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell26.Name = "xrTableCell26";
            this.xrTableCell26.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell26.StylePriority.UseFont = false;
            this.xrTableCell26.StylePriority.UsePadding = false;
            this.xrTableCell26.StylePriority.UseTextAlignment = false;
            this.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell26.Weight = 0.1672226950177908D;
            // 
            // xrTableCell27
            // 
            this.xrTableCell27.Name = "xrTableCell27";
            this.xrTableCell27.Weight = 0.13313829757467929D;
            // 
            // xrTableCell31
            // 
            this.xrTableCell31.Name = "xrTableCell31";
            this.xrTableCell31.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell31.StylePriority.UsePadding = false;
            this.xrTableCell31.Text = "Truy thu giảm: (2)";
            this.xrTableCell31.Weight = 0.39942590981762682D;
            // 
            // xrTableCell33
            // 
            this.xrTableCell33.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell33.Name = "xrTableCell33";
            this.xrTableCell33.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell33.StylePriority.UseFont = false;
            this.xrTableCell33.StylePriority.UsePadding = false;
            this.xrTableCell33.StylePriority.UseTextAlignment = false;
            this.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell33.Weight = 0.26627674543013879D;
            // 
            // xrTableCell34
            // 
            this.xrTableCell34.Name = "xrTableCell34";
            this.xrTableCell34.Weight = 0.13313796880330003D;
            // 
            // xrTableCell35
            // 
            this.xrTableCell35.Name = "xrTableCell35";
            this.xrTableCell35.Weight = 0.13313813145811662D;
            // 
            // xrTableCell36
            // 
            this.xrTableCell36.Name = "xrTableCell36";
            this.xrTableCell36.Weight = 0.13313862055839681D;
            // 
            // xrTableCell37
            // 
            this.xrTableCell37.Name = "xrTableCell37";
            this.xrTableCell37.Weight = 0.13313829553753442D;
            // 
            // xrTableCell38
            // 
            this.xrTableCell38.Name = "xrTableCell38";
            this.xrTableCell38.Weight = 0.13313845747042455D;
            // 
            // xrTableCell39
            // 
            this.xrTableCell39.Name = "xrTableCell39";
            this.xrTableCell39.Weight = 0.13313763803109122D;
            // 
            // xrTableCell40
            // 
            this.xrTableCell40.Name = "xrTableCell40";
            this.xrTableCell40.Weight = 0.14788676993203609D;
            // 
            // xrTableRow14
            // 
            this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell41,
            this.xrTableCell140,
            this.xrTableCell141,
            this.xrTableCell144,
            this.xrTableCell146,
            this.xrTableCell147,
            this.xrTableCell148,
            this.xrTableCell149,
            this.xrTableCell150,
            this.xrTableCell151,
            this.xrTableCell152,
            this.xrTableCell153});
            this.xrTableRow14.Name = "xrTableRow14";
            this.xrTableRow14.Weight = 1D;
            // 
            // xrTableCell41
            // 
            this.xrTableCell41.Name = "xrTableCell41";
            this.xrTableCell41.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell41.StylePriority.UsePadding = false;
            this.xrTableCell41.Text = "Trong đó: Nghỉ thai sản:";
            this.xrTableCell41.Weight = 1.0872204703688644D;
            // 
            // xrTableCell140
            // 
            this.xrTableCell140.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell140.Name = "xrTableCell140";
            this.xrTableCell140.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell140.StylePriority.UseFont = false;
            this.xrTableCell140.StylePriority.UsePadding = false;
            this.xrTableCell140.StylePriority.UseTextAlignment = false;
            this.xrTableCell140.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell140.Weight = 0.1672226950177908D;
            // 
            // xrTableCell141
            // 
            this.xrTableCell141.Name = "xrTableCell141";
            this.xrTableCell141.Weight = 0.13313829757467929D;
            // 
            // xrTableCell144
            // 
            this.xrTableCell144.Name = "xrTableCell144";
            this.xrTableCell144.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell144.StylePriority.UsePadding = false;
            this.xrTableCell144.Text = "Tổng truy thu: (1) + (2)";
            this.xrTableCell144.Weight = 0.39942590981762682D;
            // 
            // xrTableCell146
            // 
            this.xrTableCell146.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell146.Name = "xrTableCell146";
            this.xrTableCell146.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell146.StylePriority.UseFont = false;
            this.xrTableCell146.StylePriority.UsePadding = false;
            this.xrTableCell146.StylePriority.UseTextAlignment = false;
            this.xrTableCell146.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell146.Weight = 0.26627674543013879D;
            // 
            // xrTableCell147
            // 
            this.xrTableCell147.Name = "xrTableCell147";
            this.xrTableCell147.Weight = 0.13313796880330003D;
            // 
            // xrTableCell148
            // 
            this.xrTableCell148.Name = "xrTableCell148";
            this.xrTableCell148.Weight = 0.13313813145811662D;
            // 
            // xrTableCell149
            // 
            this.xrTableCell149.Name = "xrTableCell149";
            this.xrTableCell149.Weight = 0.13313862055839681D;
            // 
            // xrTableCell150
            // 
            this.xrTableCell150.Name = "xrTableCell150";
            this.xrTableCell150.Weight = 0.13313829553753442D;
            // 
            // xrTableCell151
            // 
            this.xrTableCell151.Name = "xrTableCell151";
            this.xrTableCell151.Weight = 0.13313845747042455D;
            // 
            // xrTableCell152
            // 
            this.xrTableCell152.Name = "xrTableCell152";
            this.xrTableCell152.Weight = 0.13313763803109122D;
            // 
            // xrTableCell153
            // 
            this.xrTableCell153.Name = "xrTableCell153";
            this.xrTableCell153.Weight = 0.14788676993203609D;
            // 
            // xrTableRow15
            // 
            this.xrTableRow15.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell154,
            this.xrTableCell155,
            this.xrTableCell156,
            this.xrTableCell159,
            this.xrTableCell161,
            this.xrTableCell162,
            this.xrTableCell163,
            this.xrTableCell164,
            this.xrTableCell165,
            this.xrTableCell166,
            this.xrTableCell167,
            this.xrTableCell168});
            this.xrTableRow15.Name = "xrTableRow15";
            this.xrTableRow15.Weight = 1D;
            // 
            // xrTableCell154
            // 
            this.xrTableCell154.Name = "xrTableCell154";
            this.xrTableCell154.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell154.StylePriority.UsePadding = false;
            this.xrTableCell154.Text = "Số lao động có mặt hiện tại";
            this.xrTableCell154.Weight = 1.0872204703688644D;
            // 
            // xrTableCell155
            // 
            this.xrTableCell155.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell155.Name = "xrTableCell155";
            this.xrTableCell155.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell155.StylePriority.UseFont = false;
            this.xrTableCell155.StylePriority.UsePadding = false;
            this.xrTableCell155.StylePriority.UseTextAlignment = false;
            this.xrTableCell155.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell155.Weight = 0.1672226950177908D;
            // 
            // xrTableCell156
            // 
            this.xrTableCell156.Name = "xrTableCell156";
            this.xrTableCell156.Weight = 0.13313829757467929D;
            // 
            // xrTableCell159
            // 
            this.xrTableCell159.Name = "xrTableCell159";
            this.xrTableCell159.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell159.StylePriority.UsePadding = false;
            this.xrTableCell159.Text = "Phải nộp truy thu (**)";
            this.xrTableCell159.Weight = 0.39942590981762682D;
            // 
            // xrTableCell161
            // 
            this.xrTableCell161.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell161.Name = "xrTableCell161";
            this.xrTableCell161.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell161.StylePriority.UseFont = false;
            this.xrTableCell161.StylePriority.UsePadding = false;
            this.xrTableCell161.StylePriority.UseTextAlignment = false;
            this.xrTableCell161.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell161.Weight = 0.26627674543013879D;
            // 
            // xrTableCell162
            // 
            this.xrTableCell162.Name = "xrTableCell162";
            this.xrTableCell162.Weight = 0.13313796880330003D;
            // 
            // xrTableCell163
            // 
            this.xrTableCell163.Name = "xrTableCell163";
            this.xrTableCell163.Weight = 0.13313813145811662D;
            // 
            // xrTableCell164
            // 
            this.xrTableCell164.Name = "xrTableCell164";
            this.xrTableCell164.Weight = 0.13313862055839681D;
            // 
            // xrTableCell165
            // 
            this.xrTableCell165.Name = "xrTableCell165";
            this.xrTableCell165.Weight = 0.13313829553753442D;
            // 
            // xrTableCell166
            // 
            this.xrTableCell166.Name = "xrTableCell166";
            this.xrTableCell166.Weight = 0.13313845747042455D;
            // 
            // xrTableCell167
            // 
            this.xrTableCell167.Name = "xrTableCell167";
            this.xrTableCell167.Weight = 0.13313763803109122D;
            // 
            // xrTableCell168
            // 
            this.xrTableCell168.Name = "xrTableCell168";
            this.xrTableCell168.Weight = 0.14788676993203609D;
            // 
            // xrTableRow17
            // 
            this.xrTableRow17.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell184,
            this.xrTableCell185,
            this.xrTableCell186,
            this.xrTableCell189,
            this.xrTableCell190,
            this.xrTableCell191,
            this.xrTableCell192,
            this.xrTableCell193,
            this.xrTableCell194,
            this.xrTableCell195,
            this.xrTableCell196,
            this.xrTableCell197,
            this.xrTableCell198});
            this.xrTableRow17.Name = "xrTableRow17";
            this.xrTableRow17.Weight = 1D;
            // 
            // xrTableCell184
            // 
            this.xrTableCell184.Name = "xrTableCell184";
            this.xrTableCell184.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell184.StylePriority.UsePadding = false;
            this.xrTableCell184.Text = "2% BHXH Bắt buộc để lại";
            this.xrTableCell184.Weight = 1.0872204703688644D;
            // 
            // xrTableCell185
            // 
            this.xrTableCell185.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell185.Name = "xrTableCell185";
            this.xrTableCell185.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell185.StylePriority.UseFont = false;
            this.xrTableCell185.StylePriority.UsePadding = false;
            this.xrTableCell185.StylePriority.UseTextAlignment = false;
            this.xrTableCell185.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell185.Weight = 0.1672226950177908D;
            // 
            // xrTableCell186
            // 
            this.xrTableCell186.Name = "xrTableCell186";
            this.xrTableCell186.Weight = 0.13313829757467929D;
            // 
            // xrTableCell189
            // 
            this.xrTableCell189.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell189.Name = "xrTableCell189";
            this.xrTableCell189.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell189.StylePriority.UseFont = false;
            this.xrTableCell189.StylePriority.UsePadding = false;
            this.xrTableCell189.StylePriority.UseTextAlignment = false;
            this.xrTableCell189.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell189.Weight = 0.39942590981762682D;
            // 
            // xrTableCell190
            // 
            this.xrTableCell190.Name = "xrTableCell190";
            this.xrTableCell190.Weight = 0.13313813168672664D;
            // 
            // xrTableCell191
            // 
            this.xrTableCell191.Name = "xrTableCell191";
            this.xrTableCell191.Weight = 0.13313861374341213D;
            // 
            // xrTableCell192
            // 
            this.xrTableCell192.Name = "xrTableCell192";
            this.xrTableCell192.Weight = 0.13313796880330003D;
            // 
            // xrTableCell193
            // 
            this.xrTableCell193.Name = "xrTableCell193";
            this.xrTableCell193.Weight = 0.13313813145811662D;
            // 
            // xrTableCell194
            // 
            this.xrTableCell194.Name = "xrTableCell194";
            this.xrTableCell194.Weight = 0.13313862055839681D;
            // 
            // xrTableCell195
            // 
            this.xrTableCell195.Name = "xrTableCell195";
            this.xrTableCell195.Weight = 0.13313829553753442D;
            // 
            // xrTableCell196
            // 
            this.xrTableCell196.Name = "xrTableCell196";
            this.xrTableCell196.Weight = 0.13313845747042455D;
            // 
            // xrTableCell197
            // 
            this.xrTableCell197.Name = "xrTableCell197";
            this.xrTableCell197.Weight = 0.13313763803109122D;
            // 
            // xrTableCell198
            // 
            this.xrTableCell198.Name = "xrTableCell198";
            this.xrTableCell198.Weight = 0.14788676993203609D;
            // 
            // xrTableRow16
            // 
            this.xrTableRow16.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell169,
            this.xrTableCell174,
            this.xrTableCell175,
            this.xrTableCell176,
            this.xrTableCell177,
            this.xrTableCell178,
            this.xrTableCell179,
            this.xrTableCell180,
            this.xrTableCell181,
            this.xrTableCell182,
            this.xrTableCell183});
            this.xrTableRow16.Name = "xrTableRow16";
            this.xrTableRow16.Weight = 1D;
            // 
            // xrTableCell169
            // 
            this.xrTableCell169.Name = "xrTableCell169";
            this.xrTableCell169.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell169.StylePriority.UsePadding = false;
            this.xrTableCell169.Text = "Phải nộp trong tháng (*) + (**)";
            this.xrTableCell169.Weight = 1.0872204703688644D;
            // 
            // xrTableCell174
            // 
            this.xrTableCell174.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell174.Name = "xrTableCell174";
            this.xrTableCell174.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell174.StylePriority.UseFont = false;
            this.xrTableCell174.StylePriority.UsePadding = false;
            this.xrTableCell174.StylePriority.UseTextAlignment = false;
            this.xrTableCell174.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrTableCell174.Weight = 0.69978690241009689D;
            // 
            // xrTableCell175
            // 
            this.xrTableCell175.Name = "xrTableCell175";
            this.xrTableCell175.Weight = 0.13313813168672664D;
            // 
            // xrTableCell176
            // 
            this.xrTableCell176.Name = "xrTableCell176";
            this.xrTableCell176.Weight = 0.13313861374341213D;
            // 
            // xrTableCell177
            // 
            this.xrTableCell177.Name = "xrTableCell177";
            this.xrTableCell177.Weight = 0.13313796880330003D;
            // 
            // xrTableCell178
            // 
            this.xrTableCell178.Name = "xrTableCell178";
            this.xrTableCell178.Weight = 0.13313813145811662D;
            // 
            // xrTableCell179
            // 
            this.xrTableCell179.Name = "xrTableCell179";
            this.xrTableCell179.Weight = 0.13313862055839681D;
            // 
            // xrTableCell180
            // 
            this.xrTableCell180.Name = "xrTableCell180";
            this.xrTableCell180.Weight = 0.13313829553753442D;
            // 
            // xrTableCell181
            // 
            this.xrTableCell181.Name = "xrTableCell181";
            this.xrTableCell181.Weight = 0.13313845747042455D;
            // 
            // xrTableCell182
            // 
            this.xrTableCell182.Name = "xrTableCell182";
            this.xrTableCell182.Weight = 0.13313763803109122D;
            // 
            // xrTableCell183
            // 
            this.xrTableCell183.Name = "xrTableCell183";
            this.xrTableCell183.Weight = 0.14788676993203609D;
            // 
            // xrTable10
            // 
            this.xrTable10.BackColor = System.Drawing.Color.LightGray;
            this.xrTable10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(3.973643E-05F, 65.16666F);
            this.xrTable10.Name = "xrTable10";
            this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
            this.xrTable10.SizeF = new System.Drawing.SizeF(1128F, 32.58333F);
            this.xrTable10.StylePriority.UseBackColor = false;
            this.xrTable10.StylePriority.UseBorders = false;
            // 
            // xrTableRow10
            // 
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell95,
            this.xrTableCell96,
            this.xrTableCell97,
            this.xrTableCell98,
            this.xrTableCell99,
            this.xrTableCell100,
            this.xrTableCell101,
            this.xrTableCell102,
            this.xrTableCell103,
            this.xrTableCell104,
            this.xrTableCell105,
            this.xrTableCell106,
            this.xrTableCell107,
            this.xrTableCell108,
            this.xrTableCell109});
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.Weight = 1D;
            // 
            // xrTableCell95
            // 
            this.xrTableCell95.Name = "xrTableCell95";
            this.xrTableCell95.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell95.StylePriority.UsePadding = false;
            this.xrTableCell95.StylePriority.UseTextAlignment = false;
            this.xrTableCell95.Text = "Tổng truy thu giảm";
            this.xrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell95.Weight = 1.0872204703688644D;
            // 
            // xrTableCell96
            // 
            this.xrTableCell96.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell96.Name = "xrTableCell96";
            this.xrTableCell96.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell96.StylePriority.UseFont = false;
            this.xrTableCell96.StylePriority.UsePadding = false;
            this.xrTableCell96.StylePriority.UseTextAlignment = false;
            this.xrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell96.Weight = 0.1672226950177908D;
            // 
            // xrTableCell97
            // 
            this.xrTableCell97.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell97.Name = "xrTableCell97";
            this.xrTableCell97.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell97.StylePriority.UseFont = false;
            this.xrTableCell97.StylePriority.UsePadding = false;
            this.xrTableCell97.StylePriority.UseTextAlignment = false;
            this.xrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell97.Weight = 0.13313829757467929D;
            // 
            // xrTableCell98
            // 
            this.xrTableCell98.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell98.Name = "xrTableCell98";
            this.xrTableCell98.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell98.StylePriority.UseFont = false;
            this.xrTableCell98.StylePriority.UsePadding = false;
            this.xrTableCell98.StylePriority.UseTextAlignment = false;
            this.xrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell98.Weight = 0.13314543617218461D;
            // 
            // xrTableCell99
            // 
            this.xrTableCell99.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell99.Name = "xrTableCell99";
            this.xrTableCell99.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell99.StylePriority.UseFont = false;
            this.xrTableCell99.StylePriority.UsePadding = false;
            this.xrTableCell99.StylePriority.UseTextAlignment = false;
            this.xrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell99.Weight = 0.13314202254000154D;
            // 
            // xrTableCell100
            // 
            this.xrTableCell100.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell100.Name = "xrTableCell100";
            this.xrTableCell100.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell100.StylePriority.UseFont = false;
            this.xrTableCell100.StylePriority.UsePadding = false;
            this.xrTableCell100.StylePriority.UseTextAlignment = false;
            this.xrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell100.Weight = 0.13313845110544068D;
            // 
            // xrTableCell101
            // 
            this.xrTableCell101.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell101.Name = "xrTableCell101";
            this.xrTableCell101.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell101.StylePriority.UseFont = false;
            this.xrTableCell101.StylePriority.UsePadding = false;
            this.xrTableCell101.StylePriority.UseTextAlignment = false;
            this.xrTableCell101.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell101.Weight = 0.13313813168672664D;
            // 
            // xrTableCell102
            // 
            this.xrTableCell102.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell102.Name = "xrTableCell102";
            this.xrTableCell102.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell102.StylePriority.UseFont = false;
            this.xrTableCell102.StylePriority.UsePadding = false;
            this.xrTableCell102.StylePriority.UseTextAlignment = false;
            this.xrTableCell102.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell102.Weight = 0.13313861374341213D;
            // 
            // xrTableCell103
            // 
            this.xrTableCell103.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell103.Name = "xrTableCell103";
            this.xrTableCell103.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell103.StylePriority.UseFont = false;
            this.xrTableCell103.StylePriority.UsePadding = false;
            this.xrTableCell103.StylePriority.UseTextAlignment = false;
            this.xrTableCell103.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell103.Weight = 0.13313796880330003D;
            // 
            // xrTableCell104
            // 
            this.xrTableCell104.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell104.Name = "xrTableCell104";
            this.xrTableCell104.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell104.StylePriority.UseFont = false;
            this.xrTableCell104.StylePriority.UsePadding = false;
            this.xrTableCell104.StylePriority.UseTextAlignment = false;
            this.xrTableCell104.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell104.Weight = 0.13313813145811662D;
            // 
            // xrTableCell105
            // 
            this.xrTableCell105.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell105.Name = "xrTableCell105";
            this.xrTableCell105.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell105.StylePriority.UseFont = false;
            this.xrTableCell105.StylePriority.UsePadding = false;
            this.xrTableCell105.StylePriority.UseTextAlignment = false;
            this.xrTableCell105.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell105.Weight = 0.13313862055839681D;
            // 
            // xrTableCell106
            // 
            this.xrTableCell106.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell106.Name = "xrTableCell106";
            this.xrTableCell106.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell106.StylePriority.UseFont = false;
            this.xrTableCell106.StylePriority.UsePadding = false;
            this.xrTableCell106.StylePriority.UseTextAlignment = false;
            this.xrTableCell106.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell106.Weight = 0.13313829553753442D;
            // 
            // xrTableCell107
            // 
            this.xrTableCell107.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell107.Name = "xrTableCell107";
            this.xrTableCell107.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell107.StylePriority.UseFont = false;
            this.xrTableCell107.StylePriority.UsePadding = false;
            this.xrTableCell107.StylePriority.UseTextAlignment = false;
            this.xrTableCell107.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell107.Weight = 0.13313845747042455D;
            // 
            // xrTableCell108
            // 
            this.xrTableCell108.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell108.Name = "xrTableCell108";
            this.xrTableCell108.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell108.StylePriority.UseFont = false;
            this.xrTableCell108.StylePriority.UsePadding = false;
            this.xrTableCell108.StylePriority.UseTextAlignment = false;
            this.xrTableCell108.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell108.Weight = 0.13313763803109122D;
            // 
            // xrTableCell109
            // 
            this.xrTableCell109.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell109.Name = "xrTableCell109";
            this.xrTableCell109.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell109.StylePriority.UseFont = false;
            this.xrTableCell109.StylePriority.UsePadding = false;
            this.xrTableCell109.StylePriority.UseTextAlignment = false;
            this.xrTableCell109.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell109.Weight = 0.14788676993203609D;
            // 
            // xrTable9
            // 
            this.xrTable9.BackColor = System.Drawing.Color.LightGray;
            this.xrTable9.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 32.58333F);
            this.xrTable9.Name = "xrTable9";
            this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
            this.xrTable9.SizeF = new System.Drawing.SizeF(1128F, 32.58333F);
            this.xrTable9.StylePriority.UseBackColor = false;
            this.xrTable9.StylePriority.UseBorders = false;
            // 
            // xrTableRow9
            // 
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell65,
            this.xrTableCell66,
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell85,
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell88,
            this.xrTableCell89,
            this.xrTableCell90,
            this.xrTableCell91,
            this.xrTableCell92,
            this.xrTableCell93,
            this.xrTableCell94});
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.Weight = 1D;
            // 
            // xrTableCell65
            // 
            this.xrTableCell65.Name = "xrTableCell65";
            this.xrTableCell65.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell65.StylePriority.UsePadding = false;
            this.xrTableCell65.StylePriority.UseTextAlignment = false;
            this.xrTableCell65.Text = "Tổng truy thu tăng";
            this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell65.Weight = 1.0872204703688644D;
            // 
            // xrTableCell66
            // 
            this.xrTableCell66.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell66.Name = "xrTableCell66";
            this.xrTableCell66.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell66.StylePriority.UseFont = false;
            this.xrTableCell66.StylePriority.UsePadding = false;
            this.xrTableCell66.StylePriority.UseTextAlignment = false;
            this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell66.Weight = 0.1672226950177908D;
            // 
            // xrTableCell67
            // 
            this.xrTableCell67.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell67.Name = "xrTableCell67";
            this.xrTableCell67.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell67.StylePriority.UseFont = false;
            this.xrTableCell67.StylePriority.UsePadding = false;
            this.xrTableCell67.StylePriority.UseTextAlignment = false;
            this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell67.Weight = 0.13313829757467929D;
            // 
            // xrTableCell68
            // 
            this.xrTableCell68.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell68.Name = "xrTableCell68";
            this.xrTableCell68.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell68.StylePriority.UseFont = false;
            this.xrTableCell68.StylePriority.UsePadding = false;
            this.xrTableCell68.StylePriority.UseTextAlignment = false;
            this.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell68.Weight = 0.13314543617218461D;
            // 
            // xrTableCell69
            // 
            this.xrTableCell69.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell69.Name = "xrTableCell69";
            this.xrTableCell69.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell69.StylePriority.UseFont = false;
            this.xrTableCell69.StylePriority.UsePadding = false;
            this.xrTableCell69.StylePriority.UseTextAlignment = false;
            this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell69.Weight = 0.13314202254000154D;
            // 
            // xrTableCell85
            // 
            this.xrTableCell85.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell85.Name = "xrTableCell85";
            this.xrTableCell85.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell85.StylePriority.UseFont = false;
            this.xrTableCell85.StylePriority.UsePadding = false;
            this.xrTableCell85.StylePriority.UseTextAlignment = false;
            this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell85.Weight = 0.13313845110544068D;
            // 
            // xrTableCell86
            // 
            this.xrTableCell86.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell86.Name = "xrTableCell86";
            this.xrTableCell86.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell86.StylePriority.UseFont = false;
            this.xrTableCell86.StylePriority.UsePadding = false;
            this.xrTableCell86.StylePriority.UseTextAlignment = false;
            this.xrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell86.Weight = 0.13313813168672664D;
            // 
            // xrTableCell87
            // 
            this.xrTableCell87.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell87.Name = "xrTableCell87";
            this.xrTableCell87.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell87.StylePriority.UseFont = false;
            this.xrTableCell87.StylePriority.UsePadding = false;
            this.xrTableCell87.StylePriority.UseTextAlignment = false;
            this.xrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell87.Weight = 0.13313861374341213D;
            // 
            // xrTableCell88
            // 
            this.xrTableCell88.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell88.Name = "xrTableCell88";
            this.xrTableCell88.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell88.StylePriority.UseFont = false;
            this.xrTableCell88.StylePriority.UsePadding = false;
            this.xrTableCell88.StylePriority.UseTextAlignment = false;
            this.xrTableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell88.Weight = 0.13313796880330003D;
            // 
            // xrTableCell89
            // 
            this.xrTableCell89.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell89.Name = "xrTableCell89";
            this.xrTableCell89.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell89.StylePriority.UseFont = false;
            this.xrTableCell89.StylePriority.UsePadding = false;
            this.xrTableCell89.StylePriority.UseTextAlignment = false;
            this.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell89.Weight = 0.13313813145811662D;
            // 
            // xrTableCell90
            // 
            this.xrTableCell90.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell90.Name = "xrTableCell90";
            this.xrTableCell90.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell90.StylePriority.UseFont = false;
            this.xrTableCell90.StylePriority.UsePadding = false;
            this.xrTableCell90.StylePriority.UseTextAlignment = false;
            this.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell90.Weight = 0.13313862055839681D;
            // 
            // xrTableCell91
            // 
            this.xrTableCell91.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell91.Name = "xrTableCell91";
            this.xrTableCell91.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell91.StylePriority.UseFont = false;
            this.xrTableCell91.StylePriority.UsePadding = false;
            this.xrTableCell91.StylePriority.UseTextAlignment = false;
            this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell91.Weight = 0.13313829553753442D;
            // 
            // xrTableCell92
            // 
            this.xrTableCell92.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell92.Name = "xrTableCell92";
            this.xrTableCell92.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell92.StylePriority.UseFont = false;
            this.xrTableCell92.StylePriority.UsePadding = false;
            this.xrTableCell92.StylePriority.UseTextAlignment = false;
            this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell92.Weight = 0.13313845747042455D;
            // 
            // xrTableCell93
            // 
            this.xrTableCell93.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell93.Name = "xrTableCell93";
            this.xrTableCell93.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell93.StylePriority.UseFont = false;
            this.xrTableCell93.StylePriority.UsePadding = false;
            this.xrTableCell93.StylePriority.UseTextAlignment = false;
            this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell93.Weight = 0.13313763803109122D;
            // 
            // xrTableCell94
            // 
            this.xrTableCell94.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell94.Name = "xrTableCell94";
            this.xrTableCell94.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell94.StylePriority.UseFont = false;
            this.xrTableCell94.StylePriority.UsePadding = false;
            this.xrTableCell94.StylePriority.UseTextAlignment = false;
            this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell94.Weight = 0.14788676993203609D;
            // 
            // xrTable8
            // 
            this.xrTable8.BackColor = System.Drawing.Color.LightGray;
            this.xrTable8.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable8.Name = "xrTable8";
            this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
            this.xrTable8.SizeF = new System.Drawing.SizeF(1128F, 32.58333F);
            this.xrTable8.StylePriority.UseBackColor = false;
            this.xrTable8.StylePriority.UseBorders = false;
            // 
            // xrTableRow8
            // 
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell70,
            this.xrTableCell71,
            this.xrTableCell72,
            this.xrTableCell73,
            this.xrTableCell74,
            this.xrTableCell75,
            this.xrTableCell76,
            this.xrTableCell77,
            this.xrTableCell78,
            this.xrTableCell79,
            this.xrTableCell80,
            this.xrTableCell81,
            this.xrTableCell82,
            this.xrTableCell83,
            this.xrTableCell84});
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 1D;
            // 
            // xrTableCell70
            // 
            this.xrTableCell70.Name = "xrTableCell70";
            this.xrTableCell70.Padding = new DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 100F);
            this.xrTableCell70.StylePriority.UsePadding = false;
            this.xrTableCell70.StylePriority.UseTextAlignment = false;
            this.xrTableCell70.Text = "Tổng cộng";
            this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell70.Weight = 1.0872204703688644D;
            // 
            // xrTableCell71
            // 
            this.xrTableCell71.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell71.Name = "xrTableCell71";
            this.xrTableCell71.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell71.StylePriority.UseFont = false;
            this.xrTableCell71.StylePriority.UsePadding = false;
            this.xrTableCell71.StylePriority.UseTextAlignment = false;
            this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell71.Weight = 0.1672226950177908D;
            // 
            // xrTableCell72
            // 
            this.xrTableCell72.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell72.Name = "xrTableCell72";
            this.xrTableCell72.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell72.StylePriority.UseFont = false;
            this.xrTableCell72.StylePriority.UsePadding = false;
            this.xrTableCell72.StylePriority.UseTextAlignment = false;
            this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell72.Weight = 0.13313829757467929D;
            // 
            // xrTableCell73
            // 
            this.xrTableCell73.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell73.Name = "xrTableCell73";
            this.xrTableCell73.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell73.StylePriority.UseFont = false;
            this.xrTableCell73.StylePriority.UsePadding = false;
            this.xrTableCell73.StylePriority.UseTextAlignment = false;
            this.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell73.Weight = 0.13314543617218461D;
            // 
            // xrTableCell74
            // 
            this.xrTableCell74.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell74.Name = "xrTableCell74";
            this.xrTableCell74.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell74.StylePriority.UseFont = false;
            this.xrTableCell74.StylePriority.UsePadding = false;
            this.xrTableCell74.StylePriority.UseTextAlignment = false;
            this.xrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell74.Weight = 0.13314202254000154D;
            // 
            // xrTableCell75
            // 
            this.xrTableCell75.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell75.Name = "xrTableCell75";
            this.xrTableCell75.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell75.StylePriority.UseFont = false;
            this.xrTableCell75.StylePriority.UsePadding = false;
            this.xrTableCell75.StylePriority.UseTextAlignment = false;
            this.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell75.Weight = 0.13313845110544068D;
            // 
            // xrTableCell76
            // 
            this.xrTableCell76.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell76.Name = "xrTableCell76";
            this.xrTableCell76.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell76.StylePriority.UseFont = false;
            this.xrTableCell76.StylePriority.UsePadding = false;
            this.xrTableCell76.StylePriority.UseTextAlignment = false;
            this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell76.Weight = 0.13313813168672664D;
            // 
            // xrTableCell77
            // 
            this.xrTableCell77.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell77.Name = "xrTableCell77";
            this.xrTableCell77.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell77.StylePriority.UseFont = false;
            this.xrTableCell77.StylePriority.UsePadding = false;
            this.xrTableCell77.StylePriority.UseTextAlignment = false;
            this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell77.Weight = 0.13313861374341213D;
            // 
            // xrTableCell78
            // 
            this.xrTableCell78.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell78.Name = "xrTableCell78";
            this.xrTableCell78.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell78.StylePriority.UseFont = false;
            this.xrTableCell78.StylePriority.UsePadding = false;
            this.xrTableCell78.StylePriority.UseTextAlignment = false;
            this.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell78.Weight = 0.13313796880330003D;
            // 
            // xrTableCell79
            // 
            this.xrTableCell79.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell79.Name = "xrTableCell79";
            this.xrTableCell79.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell79.StylePriority.UseFont = false;
            this.xrTableCell79.StylePriority.UsePadding = false;
            this.xrTableCell79.StylePriority.UseTextAlignment = false;
            this.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell79.Weight = 0.13313813145811662D;
            // 
            // xrTableCell80
            // 
            this.xrTableCell80.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell80.Name = "xrTableCell80";
            this.xrTableCell80.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell80.StylePriority.UseFont = false;
            this.xrTableCell80.StylePriority.UsePadding = false;
            this.xrTableCell80.StylePriority.UseTextAlignment = false;
            this.xrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell80.Weight = 0.13313862055839681D;
            // 
            // xrTableCell81
            // 
            this.xrTableCell81.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell81.Name = "xrTableCell81";
            this.xrTableCell81.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell81.StylePriority.UseFont = false;
            this.xrTableCell81.StylePriority.UsePadding = false;
            this.xrTableCell81.StylePriority.UseTextAlignment = false;
            this.xrTableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell81.Weight = 0.13313829553753442D;
            // 
            // xrTableCell82
            // 
            this.xrTableCell82.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell82.Name = "xrTableCell82";
            this.xrTableCell82.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell82.StylePriority.UseFont = false;
            this.xrTableCell82.StylePriority.UsePadding = false;
            this.xrTableCell82.StylePriority.UseTextAlignment = false;
            this.xrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell82.Weight = 0.13313845747042455D;
            // 
            // xrTableCell83
            // 
            this.xrTableCell83.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell83.Name = "xrTableCell83";
            this.xrTableCell83.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell83.StylePriority.UseFont = false;
            this.xrTableCell83.StylePriority.UsePadding = false;
            this.xrTableCell83.StylePriority.UseTextAlignment = false;
            this.xrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell83.Weight = 0.13313763803109122D;
            // 
            // xrTableCell84
            // 
            this.xrTableCell84.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell84.Name = "xrTableCell84";
            this.xrTableCell84.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell84.StylePriority.UseFont = false;
            this.xrTableCell84.StylePriority.UsePadding = false;
            this.xrTableCell84.StylePriority.UseTextAlignment = false;
            this.xrTableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell84.Weight = 0.14788676993203609D;
            // 
            // xrLabel9
            // 
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(628.4673F, 454F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(143.5676F, 23F);
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(628.0046F, 354.1667F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(143.5676F, 23F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "Giám đốc HCNS";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel7
            // 
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(135.6833F, 454F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(143.5676F, 23F);
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(135.2207F, 354.1667F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(143.5676F, 23F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Người lập";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // GroupHeader1
            // 
            this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable7});
            this.GroupHeader1.HeightF = 30F;
            this.GroupHeader1.Name = "GroupHeader1";
            // 
            // xrTable7
            // 
            this.xrTable7.BackColor = System.Drawing.Color.LightGray;
            this.xrTable7.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable7.Name = "xrTable7";
            this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
            this.xrTable7.SizeF = new System.Drawing.SizeF(1128F, 30F);
            this.xrTable7.StylePriority.UseBackColor = false;
            this.xrTable7.StylePriority.UseBorders = false;
            // 
            // xrTableRow7
            // 
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell45,
            this.xrTableCell47,
            this.xrTableCell48,
            this.xrTableCell49,
            this.xrTableCell50,
            this.xrTableCell51,
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54,
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell57,
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60,
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64});
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.Weight = 1D;
            // 
            // xrTableCell45
            // 
            this.xrTableCell45.Font = new System.Drawing.Font("Times New Roman", 8F);
            this.xrTableCell45.Name = "xrTableCell45";
            this.xrTableCell45.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell45.StylePriority.UseFont = false;
            this.xrTableCell45.StylePriority.UsePadding = false;
            this.xrTableCell45.Weight = 0.080213922333137413D;
            // 
            // xrTableCell47
            // 
            this.xrTableCell47.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrTableCell47.Name = "xrTableCell47";
            this.xrTableCell47.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell47.StylePriority.UseFont = false;
            this.xrTableCell47.StylePriority.UsePadding = false;
            this.xrTableCell47.StylePriority.UseTextAlignment = false;
            this.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell47.Weight = 0.4519066248450434D;
            // 
            // xrTableCell48
            // 
            this.xrTableCell48.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell48.Name = "xrTableCell48";
            this.xrTableCell48.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell48.StylePriority.UseFont = false;
            this.xrTableCell48.StylePriority.UsePadding = false;
            this.xrTableCell48.StylePriority.UseTextAlignment = false;
            this.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell48.Weight = 0.24891382275322349D;
            // 
            // xrTableCell49
            // 
            this.xrTableCell49.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell49.Name = "xrTableCell49";
            this.xrTableCell49.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell49.StylePriority.UseFont = false;
            this.xrTableCell49.StylePriority.UsePadding = false;
            this.xrTableCell49.StylePriority.UseTextAlignment = false;
            this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell49.Weight = 0.17895474803052666D;
            // 
            // xrTableCell50
            // 
            this.xrTableCell50.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell50.Name = "xrTableCell50";
            this.xrTableCell50.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell50.StylePriority.UseFont = false;
            this.xrTableCell50.StylePriority.UsePadding = false;
            this.xrTableCell50.StylePriority.UseTextAlignment = false;
            this.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrTableCell50.Weight = 0.12723135240693348D;
            // 
            // xrTableCell51
            // 
            this.xrTableCell51.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell51.Name = "xrTableCell51";
            this.xrTableCell51.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell51.StylePriority.UseFont = false;
            this.xrTableCell51.StylePriority.UsePadding = false;
            this.xrTableCell51.StylePriority.UseTextAlignment = false;
            this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell51.Weight = 0.1672226950177908D;
            // 
            // xrTableCell52
            // 
            this.xrTableCell52.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell52.Name = "xrTableCell52";
            this.xrTableCell52.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell52.StylePriority.UseFont = false;
            this.xrTableCell52.StylePriority.UsePadding = false;
            this.xrTableCell52.StylePriority.UseTextAlignment = false;
            this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell52.Weight = 0.13313829757467929D;
            // 
            // xrTableCell53
            // 
            this.xrTableCell53.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell53.Name = "xrTableCell53";
            this.xrTableCell53.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell53.StylePriority.UseFont = false;
            this.xrTableCell53.StylePriority.UsePadding = false;
            this.xrTableCell53.StylePriority.UseTextAlignment = false;
            this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell53.Weight = 0.13314543617218461D;
            // 
            // xrTableCell54
            // 
            this.xrTableCell54.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell54.Name = "xrTableCell54";
            this.xrTableCell54.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell54.StylePriority.UseFont = false;
            this.xrTableCell54.StylePriority.UsePadding = false;
            this.xrTableCell54.StylePriority.UseTextAlignment = false;
            this.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell54.Weight = 0.13314202254000154D;
            // 
            // xrTableCell55
            // 
            this.xrTableCell55.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell55.Name = "xrTableCell55";
            this.xrTableCell55.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell55.StylePriority.UseFont = false;
            this.xrTableCell55.StylePriority.UsePadding = false;
            this.xrTableCell55.StylePriority.UseTextAlignment = false;
            this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell55.Weight = 0.13313845110544068D;
            // 
            // xrTableCell56
            // 
            this.xrTableCell56.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell56.Name = "xrTableCell56";
            this.xrTableCell56.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell56.StylePriority.UseFont = false;
            this.xrTableCell56.StylePriority.UsePadding = false;
            this.xrTableCell56.StylePriority.UseTextAlignment = false;
            this.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell56.Weight = 0.13313813168672664D;
            // 
            // xrTableCell57
            // 
            this.xrTableCell57.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell57.Name = "xrTableCell57";
            this.xrTableCell57.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell57.StylePriority.UseFont = false;
            this.xrTableCell57.StylePriority.UsePadding = false;
            this.xrTableCell57.StylePriority.UseTextAlignment = false;
            this.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell57.Weight = 0.13313861374341213D;
            // 
            // xrTableCell58
            // 
            this.xrTableCell58.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell58.Name = "xrTableCell58";
            this.xrTableCell58.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell58.StylePriority.UseFont = false;
            this.xrTableCell58.StylePriority.UsePadding = false;
            this.xrTableCell58.StylePriority.UseTextAlignment = false;
            this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell58.Weight = 0.13313796880330003D;
            // 
            // xrTableCell59
            // 
            this.xrTableCell59.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell59.Name = "xrTableCell59";
            this.xrTableCell59.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell59.StylePriority.UseFont = false;
            this.xrTableCell59.StylePriority.UsePadding = false;
            this.xrTableCell59.StylePriority.UseTextAlignment = false;
            this.xrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell59.Weight = 0.13313813145811662D;
            // 
            // xrTableCell60
            // 
            this.xrTableCell60.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell60.Name = "xrTableCell60";
            this.xrTableCell60.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell60.StylePriority.UseFont = false;
            this.xrTableCell60.StylePriority.UsePadding = false;
            this.xrTableCell60.StylePriority.UseTextAlignment = false;
            this.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell60.Weight = 0.13313862055839681D;
            // 
            // xrTableCell61
            // 
            this.xrTableCell61.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell61.Name = "xrTableCell61";
            this.xrTableCell61.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell61.StylePriority.UseFont = false;
            this.xrTableCell61.StylePriority.UsePadding = false;
            this.xrTableCell61.StylePriority.UseTextAlignment = false;
            this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell61.Weight = 0.13313829553753442D;
            // 
            // xrTableCell62
            // 
            this.xrTableCell62.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell62.Name = "xrTableCell62";
            this.xrTableCell62.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell62.StylePriority.UseFont = false;
            this.xrTableCell62.StylePriority.UsePadding = false;
            this.xrTableCell62.StylePriority.UseTextAlignment = false;
            this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell62.Weight = 0.13313845747042455D;
            // 
            // xrTableCell63
            // 
            this.xrTableCell63.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell63.Name = "xrTableCell63";
            this.xrTableCell63.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell63.StylePriority.UseFont = false;
            this.xrTableCell63.StylePriority.UsePadding = false;
            this.xrTableCell63.StylePriority.UseTextAlignment = false;
            this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell63.Weight = 0.13313763803109122D;
            // 
            // xrTableCell64
            // 
            this.xrTableCell64.Font = new System.Drawing.Font("Times New Roman", 7F);
            this.xrTableCell64.Name = "xrTableCell64";
            this.xrTableCell64.Padding = new DevExpress.XtraPrinting.PaddingInfo(3, 3, 3, 3, 100F);
            this.xrTableCell64.StylePriority.UseFont = false;
            this.xrTableCell64.StylePriority.UsePadding = false;
            this.xrTableCell64.StylePriority.UseTextAlignment = false;
            this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrTableCell64.Weight = 0.14788676993203609D;
            // 
            // rp_austfeed_DS_LaoDongThamGiaBHXH
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.GroupHeader1});
            this.Landscape = true;
            this.Margins = new System.Drawing.Printing.Margins(21, 20, 100, 100);
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Version = "10.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
