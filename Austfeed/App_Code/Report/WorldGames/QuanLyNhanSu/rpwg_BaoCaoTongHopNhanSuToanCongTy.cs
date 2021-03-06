using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using DevExpress.XtraCharts;

/// <summary>
/// Summary description for rpwg_BaoCaoTongHopNhanSuToanCongTy
/// </summary>
public class rpwg_BaoCaoTongHopNhanSuToanCongTy : DevExpress.XtraReports.UI.XtraReport
{
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private ReportHeaderBand ReportHeader;
    private ReportFooterBand ReportFooter;
    private PageFooterBand PageFooter;
    private XRLabel xrlReportTitle;
    private XRLabel xrLabel2;
    private XRLabel xrLabel1;
    private XRTable xrTable3;
    private XRTableRow xrTableRow3;
    private XRTableCell xrTableCell13;
    private XRTable xrTable2;
    private XRTableRow xrTableRow2;
    private XRTableCell xrTableCell6;
    private XRTableCell xrTableCell8;
    private XRTable xrTable1;
    private XRTableRow xrTableRow1;
    private XRTableCell xrTableCell12;
    private XRTableCell xrTableCell1;
    private XRTableCell xrTableCell2;
    private XRTableCell xrTableCell3;
    private XRTableCell xrTableCell4;
    private XRTableCell xrTableCell5;
    private XRTableCell xrTableCell7;
    private XRTableCell xrTableCell14;
    private XRTableCell xrTableCell15;
    private XRTableCell xrTableCell16;
    private XRTableCell xrTableCell17;
    private XRTableCell xrTableCell19;
    private XRTable xrTable4;
    private XRTableRow xrTableRow4;
    private XRTableCell xrTableCell18;
    private XRTableCell xrTableCell20;
    private XRTableCell xrTableCell21;
    private XRTableCell xrTableCell22;
    private XRTableCell xrTableCell23;
    private XRTable xrTable5;
    private XRTableRow xrTableRow5;
    private XRTableCell xrTableCell24;
    private XRTable xrTable6;
    private XRTableRow xrTableRow6;
    private XRTableCell xrTableCell10;
    private XRTableCell xrTableCell11;
    private XRTableCell xrTableCell25;
    private XRTable xrTable7;
    private XRTableRow xrTableRow7;
    private XRTableCell xrTableCell26;
    private XRTable xrTable8;
    private XRTableRow xrTableRow8;
    private XRTableCell xrTableCell27;
    private XRTableCell xrTableCell28;
    private XRTableCell xrTableCell29;
    private XRTable xrTable9;
    private XRTableRow xrTableRow9;
    private XRTableCell xrTableCell30;
    private XRTable xrTable10;
    private XRTableRow xrTableRow10;
    private XRTableCell xrTableCell31;
    private XRTableCell xrTableCell32;
    private XRTableCell xrTableCell33;
    private XRTable xrTable11;
    private XRTableRow xrTableRow11;
    private XRTableCell xrTableCell34;
    private XRTable xrTable12;
    private XRTableRow xrTableRow12;
    private XRTableCell xrTableCell9;
    private XRTableCell xrTableCell35;
    private XRTableCell xrTableCell36;
    private XRTableCell xrTableCell37;
    private XRTableCell xrTableCell38;
    private XRTableCell xrTableCell39;
    private XRTableCell xrTableCell40;
    private XRTableCell xrTableCell41;
    private XRTableCell xrTableCell42;
    private XRTableCell xrTableCell43;
    private XRTableCell xrTableCell44;
    private XRTableCell xrTableCell45;
    private XRTableCell xrTableCell46;
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
    private GroupHeaderBand GroupHeader1;
    private XRChart xrChartContractType;
    private XRChart xrChartDegree;
    private XRChart xrChartGender;
    private XRRichText xrRichText1;
    private XRTable xrTable13;
    private XRTableRow xrTableRow13;
    private XRTableCell xrTableCell58;
    private XRTableCell xrTableCell59;
    private XRTableCell xrTableCell60;
    private XRTableCell xrTableCell61;
    private XRTableCell xrTableCell62;
    private XRTableCell xrTableCell63;
    private XRTableCell xrTableCell64;
    private XRTableCell xrTableCell65;
    private XRTableCell xrTableCell66;
    private XRTableCell xrTableCell67;
    private XRTableCell xrTableCell68;
    private XRTableCell xrTableCell69;
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
    private XRTable xrTable14;
    private XRTableRow xrTableRow14;
    private XRTableCell xrTableCell57;
    private XRTableCell xrTableCell80;
    private XRTableCell xrTableCell81;
    private XRTableCell xrTableCell82;
    private XRTableCell xrTableCell83;
    private XRTableCell xrTableCell84;
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
    private XRTableCell xrTableCell95;
    private XRTableCell xrTableCell96;
    private XRTableCell xrTableCell97;
    private XRTableCell xrTableCell98;
    private XRTableCell xrTableCell99;
    private XRTableCell xrTableCell100;
    private XRLabel xrtngayketxuat;
    private XRLabel xrl_ten3;
    private XRLabel xrl_footer3;
    private XRLabel xrl_footer1;
    private XRLabel xrl_ten1;
    private XRPageInfo xrPageInfo1;
    private XRLine xrLine1;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public rpwg_BaoCaoTongHopNhanSuToanCongTy()
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

    public void BindData(ReportFilter filter)
    {
        try
        {
            if (!string.IsNullOrEmpty(filter.ReportTitle))
                xrlReportTitle.Text = filter.ReportTitle.ToUpper();
            //### Chart
            // Gender
            drawGenderChart(filter.SessionDepartment);
            // degree
            drawDegreeChart(filter.SessionDepartment);
            // contract type
            drawContractTypeChart(filter.SessionDepartment);

            // Bind data
            DataTable table = DataController.DataHandler.GetInstance().ExecuteDataTable("report_WGBaoCaoTongHopNhanSuToanCongTy", "@startDate", "@endDate", "@maBoPhan", filter.StartDate, filter.EndDate, filter.SelectedDepartment);
        }
        catch (Exception ex)
        {
            ExtMessage.Dialog.ShowNotification("Có lỗi xảy ra: " + ex.Message);
        }
    }

    /// <summary>
    /// draw gender chart
    /// </summary>
    /// <param name="maDonVi"></param>
    private void drawGenderChart(string maDonVi)
    {
        try
        {
            DataTable tableGender = DataController.DataHandler.GetInstance().ExecuteDataTable("report_wg_sub_GetThongKeGioiTinh", "@MaDonVi", maDonVi);

            Series seriesGender = new Series("Biểu đồ giới tính", ViewType.Pie);
            // config
            PieSeriesLabel label = new PieSeriesLabel();
            label.Position = PieSeriesLabelPosition.Inside;
            seriesGender.Label.Assign(label);

            PiePointOptions pointOption = new PiePointOptions();
            pointOption.PointView = PointView.ArgumentAndValues;
            pointOption.ValueNumericOptions.Format = NumericFormat.Percent;
            pointOption.ValueNumericOptions.Precision = 0;
            seriesGender.PointOptions.Assign(pointOption);
            // fill data
            xrChartGender.Series.Add(seriesGender);
            seriesGender.DataSource = tableGender;
            seriesGender.ArgumentScaleType = ScaleType.Qualitative;
            seriesGender.ArgumentDataMember = "Name";
            seriesGender.Label.Visible = true;
            seriesGender.ValueScaleType = ScaleType.Numerical;
            seriesGender.ValueDataMembers.AddRange(new string[] { "Count" });
            xrChartGender.Legend.Visible = false;
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// draw degree chart
    /// </summary>
    /// <param name="maDonVi"></param>
    private void drawDegreeChart(string maDonVi)
    {
        try
        {
            DataTable tableDegree = DataController.DataHandler.GetInstance().ExecuteDataTable("BieuDo_ThongKeNhanSuTheoTrinhDo", "@MaDonVi", maDonVi);

            Series seriesDegree = new Series("Biểu đồ trình độ", ViewType.Pie);
            // config
            PieSeriesLabel label = new PieSeriesLabel();
            label.Position = PieSeriesLabelPosition.Outside;
            seriesDegree.Label.Assign(label);

            PiePointOptions pointOption = new PiePointOptions();
            pointOption.PointView = PointView.ArgumentAndValues;
            pointOption.ValueNumericOptions.Format = NumericFormat.Percent;
            pointOption.ValueNumericOptions.Precision = 0;
            seriesDegree.PointOptions.Assign(pointOption);
            // fill data
            xrChartDegree.Series.Add(seriesDegree);
            seriesDegree.DataSource = tableDegree;
            seriesDegree.ArgumentScaleType = ScaleType.Qualitative;
            seriesDegree.ArgumentDataMember = "MA_TRINHDO";
            seriesDegree.Label.Visible = true;
            seriesDegree.ValueScaleType = ScaleType.Numerical;
            seriesDegree.ValueDataMembers.AddRange(new string[] { "Count" });
            xrChartDegree.Legend.Visible = false;
        }
        catch (Exception)
        {
            throw;
        }
    }

    /// <summary>
    /// Draw contract type chart
    /// </summary>
    /// <param name="maDonVi">department id</param>
    private void drawContractTypeChart(string maDonVi)
    {
        try
        {
            DataTable tableContractType = DataController.DataHandler.GetInstance().ExecuteDataTable("BieuDo_ThongKeNhanSuTheoLoaiHopDong", "@MaDonVi", maDonVi);

            Series seriesContractType = new Series("Biểu đồ trình độ", ViewType.Pie);
            // config
            PieSeriesLabel label = new PieSeriesLabel();
            label.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 6);
            label.Position = PieSeriesLabelPosition.Inside;
            seriesContractType.Label.Assign(label);

            PiePointOptions pointOption = new PiePointOptions();
            pointOption.PointView = PointView.ArgumentAndValues;
            pointOption.ValueNumericOptions.Format = NumericFormat.Percent;
            pointOption.ValueNumericOptions.Precision = 0;
            seriesContractType.PointOptions.Assign(pointOption);
            // fill data
            xrChartContractType.Series.Add(seriesContractType);
            seriesContractType.DataSource = tableContractType;
            seriesContractType.ArgumentScaleType = ScaleType.Qualitative;
            seriesContractType.ArgumentDataMember = "TEN_LOAI_HDONG";
            seriesContractType.Label.Visible = true;
            seriesContractType.ValueScaleType = ScaleType.Numerical;
            seriesContractType.ValueDataMembers.AddRange(new string[] { "Count" });
            xrChartContractType.Legend.Visible = false;
        }
        catch (Exception)
        {
            throw;
        }
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        string resourceFileName = "rpwg_BaoCaoTongHopNhanSuToanCongTy.resx";
        System.Resources.ResourceManager resources = global::Resources.rpwg_BaoCaoTongHopNhanSuToanCongTy.ResourceManager;
        DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
        DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel1 = new DevExpress.XtraCharts.PieSeriesLabel();
        DevExpress.XtraCharts.PiePointOptions piePointOptions1 = new DevExpress.XtraCharts.PiePointOptions();
        DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
        DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel2 = new DevExpress.XtraCharts.PieSeriesLabel();
        DevExpress.XtraCharts.PieSeriesView pieSeriesView2 = new DevExpress.XtraCharts.PieSeriesView();
        DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
        DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel3 = new DevExpress.XtraCharts.PieSeriesLabel();
        DevExpress.XtraCharts.PieSeriesView pieSeriesView3 = new DevExpress.XtraCharts.PieSeriesView();
        DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel4 = new DevExpress.XtraCharts.PieSeriesLabel();
        DevExpress.XtraCharts.PieSeriesView pieSeriesView4 = new DevExpress.XtraCharts.PieSeriesView();
        DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
        DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel5 = new DevExpress.XtraCharts.PieSeriesLabel();
        DevExpress.XtraCharts.PieSeriesView pieSeriesView5 = new DevExpress.XtraCharts.PieSeriesView();
        DevExpress.XtraCharts.PieSeriesLabel pieSeriesLabel6 = new DevExpress.XtraCharts.PieSeriesLabel();
        DevExpress.XtraCharts.PieSeriesView pieSeriesView6 = new DevExpress.XtraCharts.PieSeriesView();
        this.Detail = new DevExpress.XtraReports.UI.DetailBand();
        this.xrTable14 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow14 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell80 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell81 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell82 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell83 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell84 = new DevExpress.XtraReports.UI.XRTableCell();
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
        this.xrTableCell95 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell96 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell97 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell98 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell99 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell100 = new DevExpress.XtraReports.UI.XRTableCell();
        this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
        this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
        this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
        this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
        this.xrRichText1 = new DevExpress.XtraReports.UI.XRRichText();
        this.xrChartGender = new DevExpress.XtraReports.UI.XRChart();
        this.xrChartDegree = new DevExpress.XtraReports.UI.XRChart();
        this.xrChartContractType = new DevExpress.XtraReports.UI.XRChart();
        this.xrTable12 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow12 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable8 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable9 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable6 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable7 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable4 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable5 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable10 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable11 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow11 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTable3 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrlReportTitle = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
        this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
        this.xrtngayketxuat = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_ten3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_footer3 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_footer1 = new DevExpress.XtraReports.UI.XRLabel();
        this.xrl_ten1 = new DevExpress.XtraReports.UI.XRLabel();
        this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
        this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
        this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
        this.xrTable13 = new DevExpress.XtraReports.UI.XRTable();
        this.xrTableRow13 = new DevExpress.XtraReports.UI.XRTableRow();
        this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
        this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
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
        ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrChartGender)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrChartDegree)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrChartContractType)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
        // 
        // Detail
        // 
        this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable14});
        this.Detail.HeightF = 29.95834F;
        this.Detail.Name = "Detail";
        this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // xrTable14
        // 
        this.xrTable14.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable14.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable14.Name = "xrTable14";
        this.xrTable14.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow14});
        this.xrTable14.SizeF = new System.Drawing.SizeF(1081F, 29.95834F);
        this.xrTable14.StylePriority.UseBorders = false;
        // 
        // xrTableRow14
        // 
        this.xrTableRow14.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell57,
            this.xrTableCell80,
            this.xrTableCell81,
            this.xrTableCell82,
            this.xrTableCell83,
            this.xrTableCell84,
            this.xrTableCell85,
            this.xrTableCell86,
            this.xrTableCell87,
            this.xrTableCell88,
            this.xrTableCell89,
            this.xrTableCell90,
            this.xrTableCell91,
            this.xrTableCell92,
            this.xrTableCell93,
            this.xrTableCell94,
            this.xrTableCell95,
            this.xrTableCell96,
            this.xrTableCell97,
            this.xrTableCell98,
            this.xrTableCell99,
            this.xrTableCell100});
        this.xrTableRow14.Name = "xrTableRow14";
        this.xrTableRow14.Weight = 1D;
        // 
        // xrTableCell57
        // 
        this.xrTableCell57.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell57.Name = "xrTableCell57";
        this.xrTableCell57.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell57.StylePriority.UseFont = false;
        this.xrTableCell57.StylePriority.UsePadding = false;
        this.xrTableCell57.StylePriority.UseTextAlignment = false;
        this.xrTableCell57.Text = "ÁDFASDF";
        this.xrTableCell57.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell57.Weight = 0.56025909410291108D;
        // 
        // xrTableCell80
        // 
        this.xrTableCell80.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell80.Name = "xrTableCell80";
        this.xrTableCell80.StylePriority.UseFont = false;
        this.xrTableCell80.StylePriority.UsePadding = false;
        this.xrTableCell80.StylePriority.UseTextAlignment = false;
        this.xrTableCell80.Text = "190";
        this.xrTableCell80.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell80.Weight = 0.13393148544967409D;
        // 
        // xrTableCell81
        // 
        this.xrTableCell81.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell81.Name = "xrTableCell81";
        this.xrTableCell81.StylePriority.UseFont = false;
        this.xrTableCell81.StylePriority.UsePadding = false;
        this.xrTableCell81.StylePriority.UseTextAlignment = false;
        this.xrTableCell81.Text = "174";
        this.xrTableCell81.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell81.Weight = 0.13393152067449227D;
        // 
        // xrTableCell82
        // 
        this.xrTableCell82.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell82.Name = "xrTableCell82";
        this.xrTableCell82.StylePriority.UseFont = false;
        this.xrTableCell82.StylePriority.UsePadding = false;
        this.xrTableCell82.StylePriority.UseTextAlignment = false;
        this.xrTableCell82.Text = "1";
        this.xrTableCell82.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell82.Weight = 0.081948665737837878D;
        // 
        // xrTableCell83
        // 
        this.xrTableCell83.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell83.Name = "xrTableCell83";
        this.xrTableCell83.StylePriority.UseFont = false;
        this.xrTableCell83.StylePriority.UsePadding = false;
        this.xrTableCell83.StylePriority.UseTextAlignment = false;
        this.xrTableCell83.Text = "-";
        this.xrTableCell83.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell83.Weight = 0.081490135117964879D;
        // 
        // xrTableCell84
        // 
        this.xrTableCell84.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell84.Name = "xrTableCell84";
        this.xrTableCell84.StylePriority.UseFont = false;
        this.xrTableCell84.StylePriority.UsePadding = false;
        this.xrTableCell84.StylePriority.UseTextAlignment = false;
        this.xrTableCell84.Text = "-";
        this.xrTableCell84.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell84.Weight = 0.088799962951161243D;
        // 
        // xrTableCell85
        // 
        this.xrTableCell85.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell85.Name = "xrTableCell85";
        this.xrTableCell85.StylePriority.UseFont = false;
        this.xrTableCell85.StylePriority.UsePadding = false;
        this.xrTableCell85.StylePriority.UseTextAlignment = false;
        this.xrTableCell85.Text = "175";
        this.xrTableCell85.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell85.Weight = 0.12946335471307052D;
        // 
        // xrTableCell86
        // 
        this.xrTableCell86.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell86.Name = "xrTableCell86";
        this.xrTableCell86.StylePriority.UseFont = false;
        this.xrTableCell86.StylePriority.UsePadding = false;
        this.xrTableCell86.StylePriority.UseTextAlignment = false;
        this.xrTableCell86.Text = "15";
        this.xrTableCell86.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell86.Weight = 0.09427449975766844D;
        // 
        // xrTableCell87
        // 
        this.xrTableCell87.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell87.Name = "xrTableCell87";
        this.xrTableCell87.StylePriority.UseFont = false;
        this.xrTableCell87.StylePriority.UsePadding = false;
        this.xrTableCell87.StylePriority.UseTextAlignment = false;
        this.xrTableCell87.Text = "9";
        this.xrTableCell87.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell87.Weight = 0.093746611440936725D;
        // 
        // xrTableCell88
        // 
        this.xrTableCell88.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell88.Name = "xrTableCell88";
        this.xrTableCell88.StylePriority.UseFont = false;
        this.xrTableCell88.StylePriority.UsePadding = false;
        this.xrTableCell88.StylePriority.UseTextAlignment = false;
        this.xrTableCell88.Text = "151";
        this.xrTableCell88.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell88.Weight = 0.10215447283461322D;
        // 
        // xrTableCell89
        // 
        this.xrTableCell89.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell89.Name = "xrTableCell89";
        this.xrTableCell89.StylePriority.UseFont = false;
        this.xrTableCell89.StylePriority.UsePadding = false;
        this.xrTableCell89.StylePriority.UseTextAlignment = false;
        this.xrTableCell89.Text = "1";
        this.xrTableCell89.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell89.Weight = 0.091498530664096925D;
        // 
        // xrTableCell90
        // 
        this.xrTableCell90.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell90.Name = "xrTableCell90";
        this.xrTableCell90.StylePriority.UseFont = false;
        this.xrTableCell90.StylePriority.UsePadding = false;
        this.xrTableCell90.StylePriority.UseTextAlignment = false;
        this.xrTableCell90.Text = "47";
        this.xrTableCell90.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell90.Weight = 0.0914986556748949D;
        // 
        // xrTableCell91
        // 
        this.xrTableCell91.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell91.Name = "xrTableCell91";
        this.xrTableCell91.StylePriority.UseFont = false;
        this.xrTableCell91.StylePriority.UsePadding = false;
        this.xrTableCell91.StylePriority.UseTextAlignment = false;
        this.xrTableCell91.Text = "43";
        this.xrTableCell91.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell91.Weight = 0.091499038019263318D;
        // 
        // xrTableCell92
        // 
        this.xrTableCell92.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell92.Name = "xrTableCell92";
        this.xrTableCell92.StylePriority.UseFont = false;
        this.xrTableCell92.StylePriority.UsePadding = false;
        this.xrTableCell92.StylePriority.UseTextAlignment = false;
        this.xrTableCell92.Text = "21";
        this.xrTableCell92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell92.Weight = 0.091498360478213386D;
        // 
        // xrTableCell93
        // 
        this.xrTableCell93.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell93.Name = "xrTableCell93";
        this.xrTableCell93.StylePriority.UseFont = false;
        this.xrTableCell93.StylePriority.UsePadding = false;
        this.xrTableCell93.StylePriority.UseTextAlignment = false;
        this.xrTableCell93.Text = "63";
        this.xrTableCell93.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell93.Weight = 0.091581996640806684D;
        // 
        // xrTableCell94
        // 
        this.xrTableCell94.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell94.Name = "xrTableCell94";
        this.xrTableCell94.StylePriority.UseFont = false;
        this.xrTableCell94.StylePriority.UsePadding = false;
        this.xrTableCell94.StylePriority.UseTextAlignment = false;
        this.xrTableCell94.Text = "51";
        this.xrTableCell94.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell94.Weight = 0.10008026651057374D;
        // 
        // xrTableCell95
        // 
        this.xrTableCell95.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell95.Name = "xrTableCell95";
        this.xrTableCell95.StylePriority.UseFont = false;
        this.xrTableCell95.StylePriority.UsePadding = false;
        this.xrTableCell95.StylePriority.UseTextAlignment = false;
        this.xrTableCell95.Text = "22";
        this.xrTableCell95.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell95.Weight = 0.099520278832786968D;
        // 
        // xrTableCell96
        // 
        this.xrTableCell96.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell96.Name = "xrTableCell96";
        this.xrTableCell96.StylePriority.UseFont = false;
        this.xrTableCell96.StylePriority.UsePadding = false;
        this.xrTableCell96.StylePriority.UseTextAlignment = false;
        this.xrTableCell96.Text = "102";
        this.xrTableCell96.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell96.Weight = 0.10844739817217158D;
        // 
        // xrTableCell97
        // 
        this.xrTableCell97.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell97.Name = "xrTableCell97";
        this.xrTableCell97.StylePriority.UseFont = false;
        this.xrTableCell97.StylePriority.UsePadding = false;
        this.xrTableCell97.StylePriority.UseTextAlignment = false;
        this.xrTableCell97.Text = "81";
        this.xrTableCell97.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell97.Weight = 0.091582041273439052D;
        // 
        // xrTableCell98
        // 
        this.xrTableCell98.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell98.Name = "xrTableCell98";
        this.xrTableCell98.StylePriority.UseFont = false;
        this.xrTableCell98.StylePriority.UsePadding = false;
        this.xrTableCell98.StylePriority.UseTextAlignment = false;
        this.xrTableCell98.Text = "94";
        this.xrTableCell98.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell98.Weight = 0.0959113469867878D;
        // 
        // xrTableCell99
        // 
        this.xrTableCell99.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell99.Name = "xrTableCell99";
        this.xrTableCell99.StylePriority.UseFont = false;
        this.xrTableCell99.StylePriority.UsePadding = false;
        this.xrTableCell99.StylePriority.UseTextAlignment = false;
        this.xrTableCell99.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell99.Weight = 0.1272428777597989D;
        // 
        // xrTableCell100
        // 
        this.xrTableCell100.Font = new System.Drawing.Font("Times New Roman", 8F);
        this.xrTableCell100.Name = "xrTableCell100";
        this.xrTableCell100.StylePriority.UseFont = false;
        this.xrTableCell100.StylePriority.UsePadding = false;
        this.xrTableCell100.StylePriority.UseTextAlignment = false;
        this.xrTableCell100.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell100.Weight = 0.41963940620683593D;
        // 
        // TopMargin
        // 
        this.TopMargin.HeightF = 54F;
        this.TopMargin.Name = "TopMargin";
        this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // BottomMargin
        // 
        this.BottomMargin.HeightF = 36F;
        this.BottomMargin.Name = "BottomMargin";
        this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
        this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
        // 
        // ReportHeader
        // 
        this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrRichText1,
            this.xrChartGender,
            this.xrChartDegree,
            this.xrChartContractType,
            this.xrTable12,
            this.xrTable1,
            this.xrlReportTitle,
            this.xrLabel2,
            this.xrLabel1});
        this.ReportHeader.HeightF = 493.5833F;
        this.ReportHeader.Name = "ReportHeader";
        // 
        // xrLine1
        // 
        this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 491.5F);
        this.xrLine1.Name = "xrLine1";
        this.xrLine1.SizeF = new System.Drawing.SizeF(1081F, 2.083344F);
        // 
        // xrRichText1
        // 
        this.xrRichText1.LocationFloat = new DevExpress.Utils.PointFloat(824.0402F, 296.625F);
        this.xrRichText1.Name = "xrRichText1";
        this.xrRichText1.SerializableRtfString = resources.GetString("xrRichText1.SerializableRtfString");
        this.xrRichText1.SizeF = new System.Drawing.SizeF(256.9598F, 173.9583F);
        // 
        // xrChartGender
        // 
        this.xrChartGender.BorderColor = System.Drawing.SystemColors.ControlText;
        this.xrChartGender.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrChartGender.LocationFloat = new DevExpress.Utils.PointFloat(540.5004F, 296.625F);
        this.xrChartGender.Name = "xrChartGender";
        pieSeriesLabel1.Font = new System.Drawing.Font("Tahoma", 6F);
        pieSeriesLabel1.LineVisible = true;
        pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Inside;
        series1.Label = pieSeriesLabel1;
        series1.Name = "seriesGender";
        piePointOptions1.PointView = DevExpress.XtraCharts.PointView.ArgumentAndValues;
        piePointOptions1.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Percent;
        piePointOptions1.ValueNumericOptions.Precision = 0;
        series1.PointOptions = piePointOptions1;
        pieSeriesView1.RuntimeExploding = false;
        series1.View = pieSeriesView1;
        this.xrChartGender.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
        pieSeriesLabel2.LineVisible = true;
        this.xrChartGender.SeriesTemplate.Label = pieSeriesLabel2;
        pieSeriesView2.RuntimeExploding = false;
        this.xrChartGender.SeriesTemplate.View = pieSeriesView2;
        this.xrChartGender.SizeF = new System.Drawing.SizeF(283.54F, 173.9584F);
        // 
        // xrChartDegree
        // 
        this.xrChartDegree.BorderColor = System.Drawing.SystemColors.ControlText;
        this.xrChartDegree.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrChartDegree.LocationFloat = new DevExpress.Utils.PointFloat(265.625F, 296.625F);
        this.xrChartDegree.Name = "xrChartDegree";
        pieSeriesLabel3.LineVisible = true;
        series2.Label = pieSeriesLabel3;
        series2.Name = "Series 1";
        pieSeriesView3.RuntimeExploding = false;
        series2.View = pieSeriesView3;
        this.xrChartDegree.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
        pieSeriesLabel4.LineVisible = true;
        this.xrChartDegree.SeriesTemplate.Label = pieSeriesLabel4;
        pieSeriesView4.RuntimeExploding = false;
        this.xrChartDegree.SeriesTemplate.View = pieSeriesView4;
        this.xrChartDegree.SizeF = new System.Drawing.SizeF(273.0699F, 173.9584F);
        // 
        // xrChartContractType
        // 
        this.xrChartContractType.BorderColor = System.Drawing.SystemColors.ControlText;
        this.xrChartContractType.Borders = DevExpress.XtraPrinting.BorderSide.None;
        this.xrChartContractType.LocationFloat = new DevExpress.Utils.PointFloat(0F, 296.625F);
        this.xrChartContractType.Name = "xrChartContractType";
        pieSeriesLabel5.LineVisible = true;
        series3.Label = pieSeriesLabel5;
        series3.Name = "Series 1";
        pieSeriesView5.RuntimeExploding = false;
        series3.View = pieSeriesView5;
        this.xrChartContractType.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
        pieSeriesLabel6.LineVisible = true;
        this.xrChartContractType.SeriesTemplate.Label = pieSeriesLabel6;
        pieSeriesView6.RuntimeExploding = false;
        this.xrChartContractType.SeriesTemplate.View = pieSeriesView6;
        this.xrChartContractType.SizeF = new System.Drawing.SizeF(265.625F, 173.9583F);
        // 
        // xrTable12
        // 
        this.xrTable12.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable12.LocationFloat = new DevExpress.Utils.PointFloat(0F, 266.6667F);
        this.xrTable12.Name = "xrTable12";
        this.xrTable12.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow12});
        this.xrTable12.SizeF = new System.Drawing.SizeF(1081F, 29.95834F);
        this.xrTable12.StylePriority.UseBorders = false;
        // 
        // xrTableRow12
        // 
        this.xrTableRow12.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell35,
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell44,
            this.xrTableCell38,
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48,
            this.xrTableCell49,
            this.xrTableCell50,
            this.xrTableCell51,
            this.xrTableCell39,
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell42,
            this.xrTableCell43});
        this.xrTableRow12.Name = "xrTableRow12";
        this.xrTableRow12.Weight = 1D;
        // 
        // xrTableCell9
        // 
        this.xrTableCell9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell9.Name = "xrTableCell9";
        this.xrTableCell9.StylePriority.UseFont = false;
        this.xrTableCell9.StylePriority.UsePadding = false;
        this.xrTableCell9.StylePriority.UseTextAlignment = false;
        this.xrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell9.Weight = 0.098214591962931239D;
        // 
        // xrTableCell35
        // 
        this.xrTableCell35.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell35.Name = "xrTableCell35";
        this.xrTableCell35.StylePriority.UseFont = false;
        this.xrTableCell35.StylePriority.UsePadding = false;
        this.xrTableCell35.StylePriority.UseTextAlignment = false;
        this.xrTableCell35.Text = "TỔNG CỘNG";
        this.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell35.Weight = 0.46204450213997983D;
        // 
        // xrTableCell36
        // 
        this.xrTableCell36.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell36.Name = "xrTableCell36";
        this.xrTableCell36.StylePriority.UseFont = false;
        this.xrTableCell36.StylePriority.UsePadding = false;
        this.xrTableCell36.StylePriority.UseTextAlignment = false;
        this.xrTableCell36.Text = "190";
        this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell36.Weight = 0.13393148544967409D;
        // 
        // xrTableCell37
        // 
        this.xrTableCell37.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell37.Name = "xrTableCell37";
        this.xrTableCell37.StylePriority.UseFont = false;
        this.xrTableCell37.StylePriority.UsePadding = false;
        this.xrTableCell37.StylePriority.UseTextAlignment = false;
        this.xrTableCell37.Text = "174";
        this.xrTableCell37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell37.Weight = 0.13393152067449227D;
        // 
        // xrTableCell44
        // 
        this.xrTableCell44.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell44.Name = "xrTableCell44";
        this.xrTableCell44.StylePriority.UseFont = false;
        this.xrTableCell44.StylePriority.UsePadding = false;
        this.xrTableCell44.StylePriority.UseTextAlignment = false;
        this.xrTableCell44.Text = "1";
        this.xrTableCell44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell44.Weight = 0.081948665737837878D;
        // 
        // xrTableCell38
        // 
        this.xrTableCell38.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell38.Name = "xrTableCell38";
        this.xrTableCell38.StylePriority.UseFont = false;
        this.xrTableCell38.StylePriority.UsePadding = false;
        this.xrTableCell38.StylePriority.UseTextAlignment = false;
        this.xrTableCell38.Text = "-";
        this.xrTableCell38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell38.Weight = 0.081490135117964879D;
        // 
        // xrTableCell45
        // 
        this.xrTableCell45.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell45.Name = "xrTableCell45";
        this.xrTableCell45.StylePriority.UseFont = false;
        this.xrTableCell45.StylePriority.UsePadding = false;
        this.xrTableCell45.StylePriority.UseTextAlignment = false;
        this.xrTableCell45.Text = "-";
        this.xrTableCell45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell45.Weight = 0.088799962951161243D;
        // 
        // xrTableCell46
        // 
        this.xrTableCell46.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell46.Name = "xrTableCell46";
        this.xrTableCell46.StylePriority.UseFont = false;
        this.xrTableCell46.StylePriority.UsePadding = false;
        this.xrTableCell46.StylePriority.UseTextAlignment = false;
        this.xrTableCell46.Text = "175";
        this.xrTableCell46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell46.Weight = 0.12946335471307052D;
        // 
        // xrTableCell47
        // 
        this.xrTableCell47.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell47.Name = "xrTableCell47";
        this.xrTableCell47.StylePriority.UseFont = false;
        this.xrTableCell47.StylePriority.UsePadding = false;
        this.xrTableCell47.StylePriority.UseTextAlignment = false;
        this.xrTableCell47.Text = "15";
        this.xrTableCell47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell47.Weight = 0.09427449975766844D;
        // 
        // xrTableCell48
        // 
        this.xrTableCell48.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell48.Name = "xrTableCell48";
        this.xrTableCell48.StylePriority.UseFont = false;
        this.xrTableCell48.StylePriority.UsePadding = false;
        this.xrTableCell48.StylePriority.UseTextAlignment = false;
        this.xrTableCell48.Text = "9";
        this.xrTableCell48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell48.Weight = 0.093746611440936725D;
        // 
        // xrTableCell49
        // 
        this.xrTableCell49.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell49.Name = "xrTableCell49";
        this.xrTableCell49.StylePriority.UseFont = false;
        this.xrTableCell49.StylePriority.UsePadding = false;
        this.xrTableCell49.StylePriority.UseTextAlignment = false;
        this.xrTableCell49.Text = "151";
        this.xrTableCell49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell49.Weight = 0.10215447283461322D;
        // 
        // xrTableCell50
        // 
        this.xrTableCell50.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell50.Name = "xrTableCell50";
        this.xrTableCell50.StylePriority.UseFont = false;
        this.xrTableCell50.StylePriority.UsePadding = false;
        this.xrTableCell50.StylePriority.UseTextAlignment = false;
        this.xrTableCell50.Text = "1";
        this.xrTableCell50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell50.Weight = 0.091498530664096925D;
        // 
        // xrTableCell51
        // 
        this.xrTableCell51.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell51.Name = "xrTableCell51";
        this.xrTableCell51.StylePriority.UseFont = false;
        this.xrTableCell51.StylePriority.UsePadding = false;
        this.xrTableCell51.StylePriority.UseTextAlignment = false;
        this.xrTableCell51.Text = "47";
        this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell51.Weight = 0.0914986556748949D;
        // 
        // xrTableCell39
        // 
        this.xrTableCell39.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell39.Name = "xrTableCell39";
        this.xrTableCell39.StylePriority.UseFont = false;
        this.xrTableCell39.StylePriority.UsePadding = false;
        this.xrTableCell39.StylePriority.UseTextAlignment = false;
        this.xrTableCell39.Text = "43";
        this.xrTableCell39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell39.Weight = 0.091499038019263318D;
        // 
        // xrTableCell52
        // 
        this.xrTableCell52.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell52.Name = "xrTableCell52";
        this.xrTableCell52.StylePriority.UseFont = false;
        this.xrTableCell52.StylePriority.UsePadding = false;
        this.xrTableCell52.StylePriority.UseTextAlignment = false;
        this.xrTableCell52.Text = "21";
        this.xrTableCell52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell52.Weight = 0.091498360478213386D;
        // 
        // xrTableCell53
        // 
        this.xrTableCell53.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell53.Name = "xrTableCell53";
        this.xrTableCell53.StylePriority.UseFont = false;
        this.xrTableCell53.StylePriority.UsePadding = false;
        this.xrTableCell53.StylePriority.UseTextAlignment = false;
        this.xrTableCell53.Text = "63";
        this.xrTableCell53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell53.Weight = 0.091581996640806684D;
        // 
        // xrTableCell54
        // 
        this.xrTableCell54.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell54.Name = "xrTableCell54";
        this.xrTableCell54.StylePriority.UseFont = false;
        this.xrTableCell54.StylePriority.UsePadding = false;
        this.xrTableCell54.StylePriority.UseTextAlignment = false;
        this.xrTableCell54.Text = "51";
        this.xrTableCell54.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell54.Weight = 0.10008026651057374D;
        // 
        // xrTableCell40
        // 
        this.xrTableCell40.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell40.Name = "xrTableCell40";
        this.xrTableCell40.StylePriority.UseFont = false;
        this.xrTableCell40.StylePriority.UsePadding = false;
        this.xrTableCell40.StylePriority.UseTextAlignment = false;
        this.xrTableCell40.Text = "22";
        this.xrTableCell40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell40.Weight = 0.099520278832786968D;
        // 
        // xrTableCell41
        // 
        this.xrTableCell41.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell41.Name = "xrTableCell41";
        this.xrTableCell41.StylePriority.UseFont = false;
        this.xrTableCell41.StylePriority.UsePadding = false;
        this.xrTableCell41.StylePriority.UseTextAlignment = false;
        this.xrTableCell41.Text = "102";
        this.xrTableCell41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell41.Weight = 0.10844739817217158D;
        // 
        // xrTableCell55
        // 
        this.xrTableCell55.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell55.Name = "xrTableCell55";
        this.xrTableCell55.StylePriority.UseFont = false;
        this.xrTableCell55.StylePriority.UsePadding = false;
        this.xrTableCell55.StylePriority.UseTextAlignment = false;
        this.xrTableCell55.Text = "81";
        this.xrTableCell55.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell55.Weight = 0.091582041273439052D;
        // 
        // xrTableCell56
        // 
        this.xrTableCell56.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell56.Name = "xrTableCell56";
        this.xrTableCell56.StylePriority.UseFont = false;
        this.xrTableCell56.StylePriority.UsePadding = false;
        this.xrTableCell56.StylePriority.UseTextAlignment = false;
        this.xrTableCell56.Text = "94";
        this.xrTableCell56.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell56.Weight = 0.0959113469867878D;
        // 
        // xrTableCell42
        // 
        this.xrTableCell42.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell42.Name = "xrTableCell42";
        this.xrTableCell42.StylePriority.UseFont = false;
        this.xrTableCell42.StylePriority.UsePadding = false;
        this.xrTableCell42.StylePriority.UseTextAlignment = false;
        this.xrTableCell42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell42.Weight = 0.1272428777597989D;
        // 
        // xrTableCell43
        // 
        this.xrTableCell43.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
        this.xrTableCell43.Name = "xrTableCell43";
        this.xrTableCell43.StylePriority.UseFont = false;
        this.xrTableCell43.StylePriority.UsePadding = false;
        this.xrTableCell43.StylePriority.UseTextAlignment = false;
        this.xrTableCell43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell43.Weight = 0.41963940620683593D;
        // 
        // xrTable1
        // 
        this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 165.625F);
        this.xrTable1.Name = "xrTable1";
        this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
        this.xrTable1.SizeF = new System.Drawing.SizeF(1081F, 101.0417F);
        this.xrTable1.StylePriority.UseBorders = false;
        this.xrTable1.StylePriority.UseFont = false;
        // 
        // xrTableRow1
        // 
        this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell12,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell7,
            this.xrTableCell14,
            this.xrTableCell17,
            this.xrTableCell19});
        this.xrTableRow1.Name = "xrTableRow1";
        this.xrTableRow1.Weight = 1D;
        // 
        // xrTableCell1
        // 
        this.xrTableCell1.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell1.Name = "xrTableCell1";
        this.xrTableCell1.StylePriority.UseFont = false;
        this.xrTableCell1.StylePriority.UseTextAlignment = false;
        this.xrTableCell1.Text = "TT";
        this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell1.Weight = 0.098214612099205359D;
        // 
        // xrTableCell2
        // 
        this.xrTableCell2.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell2.Name = "xrTableCell2";
        this.xrTableCell2.StylePriority.UseFont = false;
        this.xrTableCell2.StylePriority.UseTextAlignment = false;
        this.xrTableCell2.Text = "Nội dung";
        this.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell2.Weight = 0.46204446193936966D;
        // 
        // xrTableCell3
        // 
        this.xrTableCell3.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell3.Name = "xrTableCell3";
        this.xrTableCell3.StylePriority.UseFont = false;
        this.xrTableCell3.StylePriority.UseTextAlignment = false;
        this.xrTableCell3.Text = "ĐỊNH BIÊN";
        this.xrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell3.Weight = 0.13393153033289396D;
        // 
        // xrTableCell15
        // 
        this.xrTableCell15.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell15.Name = "xrTableCell15";
        this.xrTableCell15.StylePriority.UseFont = false;
        this.xrTableCell15.StylePriority.UseTextAlignment = false;
        this.xrTableCell15.Text = "Đầu tuần";
        this.xrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell15.Weight = 0.13393152962119126D;
        // 
        // xrTableCell16
        // 
        this.xrTableCell16.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable8,
            this.xrTable9});
        this.xrTableCell16.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell16.Name = "xrTableCell16";
        this.xrTableCell16.StylePriority.UseFont = false;
        this.xrTableCell16.StylePriority.UseTextAlignment = false;
        this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell16.Weight = 0.25223868473028177D;
        // 
        // xrTable8
        // 
        this.xrTable8.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable8.LocationFloat = new DevExpress.Utils.PointFloat(0F, 53.74997F);
        this.xrTable8.Name = "xrTable8";
        this.xrTable8.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow8});
        this.xrTable8.SizeF = new System.Drawing.SizeF(90.89F, 47.29166F);
        this.xrTable8.StylePriority.UseBorders = false;
        // 
        // xrTableRow8
        // 
        this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29});
        this.xrTableRow8.Name = "xrTableRow8";
        this.xrTableRow8.Weight = 1D;
        // 
        // xrTableCell27
        // 
        this.xrTableCell27.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell27.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell27.Name = "xrTableCell27";
        this.xrTableCell27.StylePriority.UseBorders = false;
        this.xrTableCell27.StylePriority.UseFont = false;
        this.xrTableCell27.Text = "Tăng mới";
        this.xrTableCell27.Weight = 0.97465578269398889D;
        // 
        // xrTableCell28
        // 
        this.xrTableCell28.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell28.Name = "xrTableCell28";
        this.xrTableCell28.StylePriority.UseFont = false;
        this.xrTableCell28.Text = "Nghỉ việc";
        this.xrTableCell28.Weight = 0.96920427908611873D;
        // 
        // xrTableCell29
        // 
        this.xrTableCell29.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell29.Name = "xrTableCell29";
        this.xrTableCell29.StylePriority.UseFont = false;
        this.xrTableCell29.Text = "Điều chuyển";
        this.xrTableCell29.Weight = 1.0561399382198928D;
        // 
        // xrTable9
        // 
        this.xrTable9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable9.Name = "xrTable9";
        this.xrTable9.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow9});
        this.xrTable9.SizeF = new System.Drawing.SizeF(90.89001F, 53.74997F);
        // 
        // xrTableRow9
        // 
        this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell30});
        this.xrTableRow9.Name = "xrTableRow9";
        this.xrTableRow9.Weight = 1D;
        // 
        // xrTableCell30
        // 
        this.xrTableCell30.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell30.Name = "xrTableCell30";
        this.xrTableCell30.StylePriority.UseBorders = false;
        this.xrTableCell30.Text = "Biến động trong tuần";
        this.xrTableCell30.Weight = 3D;
        // 
        // xrTableCell12
        // 
        this.xrTableCell12.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell12.Name = "xrTableCell12";
        this.xrTableCell12.StylePriority.UseFont = false;
        this.xrTableCell12.StylePriority.UseTextAlignment = false;
        this.xrTableCell12.Text = "Cuối tuần";
        this.xrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell12.Weight = 0.12946346399411349D;
        // 
        // xrTableCell4
        // 
        this.xrTableCell4.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable6,
            this.xrTable7});
        this.xrTableCell4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTableCell4.Name = "xrTableCell4";
        this.xrTableCell4.StylePriority.UseFont = false;
        this.xrTableCell4.StylePriority.UseTextAlignment = false;
        this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell4.Weight = 0.29017572482995968D;
        // 
        // xrTable6
        // 
        this.xrTable6.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable6.LocationFloat = new DevExpress.Utils.PointFloat(0.0002543131F, 53.74997F);
        this.xrTable6.Name = "xrTable6";
        this.xrTable6.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow6});
        this.xrTable6.SizeF = new System.Drawing.SizeF(104.56F, 47.29166F);
        this.xrTable6.StylePriority.UseBorders = false;
        // 
        // xrTableRow6
        // 
        this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell25});
        this.xrTableRow6.Name = "xrTableRow6";
        this.xrTableRow6.Weight = 1D;
        // 
        // xrTableCell10
        // 
        this.xrTableCell10.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell10.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell10.Multiline = true;
        this.xrTableCell10.Name = "xrTableCell10";
        this.xrTableCell10.StylePriority.UseBorders = false;
        this.xrTableCell10.StylePriority.UseFont = false;
        this.xrTableCell10.Text = "HV/\r\nThử việc";
        this.xrTableCell10.Weight = 0.97465578269398889D;
        // 
        // xrTableCell11
        // 
        this.xrTableCell11.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell11.Name = "xrTableCell11";
        this.xrTableCell11.StylePriority.UseFont = false;
        this.xrTableCell11.Text = "Thời vụ";
        this.xrTableCell11.Weight = 0.96920427908611873D;
        // 
        // xrTableCell25
        // 
        this.xrTableCell25.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell25.Name = "xrTableCell25";
        this.xrTableCell25.StylePriority.UseFont = false;
        this.xrTableCell25.Text = "CĐ";
        this.xrTableCell25.Weight = 1.0561399382198928D;
        // 
        // xrTable7
        // 
        this.xrTable7.LocationFloat = new DevExpress.Utils.PointFloat(0.0002746582F, 0F);
        this.xrTable7.Name = "xrTable7";
        this.xrTable7.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow7});
        this.xrTable7.SizeF = new System.Drawing.SizeF(104.5599F, 53.74997F);
        // 
        // xrTableRow7
        // 
        this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell26});
        this.xrTableRow7.Name = "xrTableRow7";
        this.xrTableRow7.Weight = 1D;
        // 
        // xrTableCell26
        // 
        this.xrTableCell26.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell26.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell26.Multiline = true;
        this.xrTableCell26.Name = "xrTableCell26";
        this.xrTableCell26.StylePriority.UseBorders = false;
        this.xrTableCell26.StylePriority.UseFont = false;
        this.xrTableCell26.Text = "Trong đó lao động phân theo\r\nLoại hợp đồng";
        this.xrTableCell26.Weight = 3D;
        // 
        // xrTableCell5
        // 
        this.xrTableCell5.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable4,
            this.xrTable5});
        this.xrTableCell5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
        this.xrTableCell5.Name = "xrTableCell5";
        this.xrTableCell5.StylePriority.UseFont = false;
        this.xrTableCell5.StylePriority.UseTextAlignment = false;
        this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell5.Weight = 0.45757633177468759D;
        // 
        // xrTable4
        // 
        this.xrTable4.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable4.LocationFloat = new DevExpress.Utils.PointFloat(0F, 53.75001F);
        this.xrTable4.Name = "xrTable4";
        this.xrTable4.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
        this.xrTable4.SizeF = new System.Drawing.SizeF(164.88F, 47.29166F);
        this.xrTable4.StylePriority.UseBorders = false;
        // 
        // xrTableRow4
        // 
        this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell18,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23});
        this.xrTableRow4.Name = "xrTableRow4";
        this.xrTableRow4.Weight = 1D;
        // 
        // xrTableCell18
        // 
        this.xrTableCell18.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell18.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell18.Name = "xrTableCell18";
        this.xrTableCell18.StylePriority.UseBorders = false;
        this.xrTableCell18.StylePriority.UseFont = false;
        this.xrTableCell18.Text = ">ĐH";
        this.xrTableCell18.Weight = 0.59989079686347635D;
        // 
        // xrTableCell20
        // 
        this.xrTableCell20.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell20.Name = "xrTableCell20";
        this.xrTableCell20.StylePriority.UseFont = false;
        this.xrTableCell20.Text = "ĐH";
        this.xrTableCell20.Weight = 0.59989083182205627D;
        // 
        // xrTableCell21
        // 
        this.xrTableCell21.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell21.Name = "xrTableCell21";
        this.xrTableCell21.StylePriority.UseFont = false;
        this.xrTableCell21.Text = "CĐ";
        this.xrTableCell21.Weight = 0.59989083413970712D;
        // 
        // xrTableCell22
        // 
        this.xrTableCell22.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell22.Name = "xrTableCell22";
        this.xrTableCell22.StylePriority.UseFont = false;
        this.xrTableCell22.Text = "TC";
        this.xrTableCell22.Weight = 0.59989084180699537D;
        // 
        // xrTableCell23
        // 
        this.xrTableCell23.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell23.Name = "xrTableCell23";
        this.xrTableCell23.StylePriority.UseFont = false;
        this.xrTableCell23.Text = "LDPT";
        this.xrTableCell23.Weight = 0.600436695367765D;
        // 
        // xrTable5
        // 
        this.xrTable5.LocationFloat = new DevExpress.Utils.PointFloat(0.0003662109F, 0F);
        this.xrTable5.Name = "xrTable5";
        this.xrTable5.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow5});
        this.xrTable5.SizeF = new System.Drawing.SizeF(164.88F, 53.75F);
        // 
        // xrTableRow5
        // 
        this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell24});
        this.xrTableRow5.Name = "xrTableRow5";
        this.xrTableRow5.Weight = 1D;
        // 
        // xrTableCell24
        // 
        this.xrTableCell24.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell24.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell24.Multiline = true;
        this.xrTableCell24.Name = "xrTableCell24";
        this.xrTableCell24.StylePriority.UseBorders = false;
        this.xrTableCell24.StylePriority.UseFont = false;
        this.xrTableCell24.Text = "Trong đó lao động phân theo \r\nTrình độ học vấn";
        this.xrTableCell24.Weight = 3D;
        // 
        // xrTableCell7
        // 
        this.xrTableCell7.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable10,
            this.xrTable11});
        this.xrTableCell7.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell7.Name = "xrTableCell7";
        this.xrTableCell7.StylePriority.UseFont = false;
        this.xrTableCell7.StylePriority.UseTextAlignment = false;
        this.xrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell7.Weight = 0.30804810360777057D;
        // 
        // xrTable10
        // 
        this.xrTable10.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable10.LocationFloat = new DevExpress.Utils.PointFloat(0F, 53.74997F);
        this.xrTable10.Name = "xrTable10";
        this.xrTable10.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow10});
        this.xrTable10.SizeF = new System.Drawing.SizeF(111F, 47.29166F);
        this.xrTable10.StylePriority.UseBorders = false;
        // 
        // xrTableRow10
        // 
        this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33});
        this.xrTableRow10.Name = "xrTableRow10";
        this.xrTableRow10.Weight = 1D;
        // 
        // xrTableCell31
        // 
        this.xrTableCell31.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell31.Name = "xrTableCell31";
        this.xrTableCell31.StylePriority.UseBorders = false;
        this.xrTableCell31.Text = "Cấp 1";
        this.xrTableCell31.Weight = 0.97465578269398889D;
        // 
        // xrTableCell32
        // 
        this.xrTableCell32.Name = "xrTableCell32";
        this.xrTableCell32.Text = "Cấp 2";
        this.xrTableCell32.Weight = 0.96920427908611873D;
        // 
        // xrTableCell33
        // 
        this.xrTableCell33.Name = "xrTableCell33";
        this.xrTableCell33.Text = "NV";
        this.xrTableCell33.Weight = 1.0561399382198928D;
        // 
        // xrTable11
        // 
        this.xrTable11.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable11.Name = "xrTable11";
        this.xrTable11.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow11});
        this.xrTable11.SizeF = new System.Drawing.SizeF(111F, 53.75F);
        // 
        // xrTableRow11
        // 
        this.xrTableRow11.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell34});
        this.xrTableRow11.Name = "xrTableRow11";
        this.xrTableRow11.Weight = 1D;
        // 
        // xrTableCell34
        // 
        this.xrTableCell34.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell34.Multiline = true;
        this.xrTableCell34.Name = "xrTableCell34";
        this.xrTableCell34.StylePriority.UseBorders = false;
        this.xrTableCell34.Text = "Trong đó lao động phân theo\r\nQuản lý";
        this.xrTableCell34.Weight = 3D;
        // 
        // xrTableCell14
        // 
        this.xrTableCell14.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2,
            this.xrTable3});
        this.xrTableCell14.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell14.Name = "xrTableCell14";
        this.xrTableCell14.StylePriority.UseFont = false;
        this.xrTableCell14.StylePriority.UseTextAlignment = false;
        this.xrTableCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell14.Weight = 0.18749305520423792D;
        // 
        // xrTable2
        // 
        this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top)
        | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 53.74997F);
        this.xrTable2.Name = "xrTable2";
        this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
        this.xrTable2.SizeF = new System.Drawing.SizeF(67.56F, 47.29166F);
        this.xrTable2.StylePriority.UseBorders = false;
        // 
        // xrTableRow2
        // 
        this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6,
            this.xrTableCell8});
        this.xrTableRow2.Name = "xrTableRow2";
        this.xrTableRow2.Weight = 1D;
        // 
        // xrTableCell6
        // 
        this.xrTableCell6.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTableCell6.Name = "xrTableCell6";
        this.xrTableCell6.StylePriority.UseBorders = false;
        this.xrTableCell6.Text = "Nam";
        this.xrTableCell6.Weight = 1.4653641769706329D;
        // 
        // xrTableCell8
        // 
        this.xrTableCell8.Name = "xrTableCell8";
        this.xrTableCell8.Text = "Nữ";
        this.xrTableCell8.Weight = 1.5346358230293675D;
        // 
        // xrTable3
        // 
        this.xrTable3.LocationFloat = new DevExpress.Utils.PointFloat(6.103516E-05F, 0F);
        this.xrTable3.Name = "xrTable3";
        this.xrTable3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow3});
        this.xrTable3.SizeF = new System.Drawing.SizeF(67.56F, 53.74998F);
        // 
        // xrTableRow3
        // 
        this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13});
        this.xrTableRow3.Name = "xrTableRow3";
        this.xrTableRow3.Weight = 1D;
        // 
        // xrTableCell13
        // 
        this.xrTableCell13.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
        this.xrTableCell13.Multiline = true;
        this.xrTableCell13.Name = "xrTableCell13";
        this.xrTableCell13.StylePriority.UseBorders = false;
        this.xrTableCell13.Text = "Trong đó lao động phân loại theo \r\nGiới tính";
        this.xrTableCell13.Weight = 3D;
        // 
        // xrTableCell17
        // 
        this.xrTableCell17.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell17.Name = "xrTableCell17";
        this.xrTableCell17.StylePriority.UseFont = false;
        this.xrTableCell17.StylePriority.UseTextAlignment = false;
        this.xrTableCell17.Text = "Nhân sự +/- so với định biên";
        this.xrTableCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell17.Weight = 0.12724328901236193D;
        // 
        // xrTableCell19
        // 
        this.xrTableCell19.Font = new System.Drawing.Font("Times New Roman", 7F, System.Drawing.FontStyle.Bold);
        this.xrTableCell19.Name = "xrTableCell19";
        this.xrTableCell19.StylePriority.UseFont = false;
        this.xrTableCell19.StylePriority.UseTextAlignment = false;
        this.xrTableCell19.Text = "Đánh giá thừa thiếu nhân sự và chất lượng lao động";
        this.xrTableCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell19.Weight = 0.41963921285392675D;
        // 
        // xrlReportTitle
        // 
        this.xrlReportTitle.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
        this.xrlReportTitle.LocationFloat = new DevExpress.Utils.PointFloat(0F, 118.3333F);
        this.xrlReportTitle.Name = "xrlReportTitle";
        this.xrlReportTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrlReportTitle.SizeF = new System.Drawing.SizeF(1081F, 30.29167F);
        this.xrlReportTitle.StylePriority.UseFont = false;
        this.xrlReportTitle.StylePriority.UseTextAlignment = false;
        this.xrlReportTitle.Text = "BÁO CÁO TỔNG HỢP NHÂN SỰ TOÀN CÔNG TY";
        this.xrlReportTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel2
        // 
        this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 35.00001F);
        this.xrLabel2.Name = "xrLabel2";
        this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel2.SizeF = new System.Drawing.SizeF(332.2917F, 23F);
        this.xrLabel2.StylePriority.UseFont = false;
        this.xrLabel2.StylePriority.UseTextAlignment = false;
        this.xrLabel2.Text = "PHÒNG HCNS CÔNG TY";
        this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // xrLabel1
        // 
        this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
        this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(26.04167F, 10.00001F);
        this.xrLabel1.Name = "xrLabel1";
        this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrLabel1.SizeF = new System.Drawing.SizeF(332.2917F, 23F);
        this.xrLabel1.StylePriority.UseFont = false;
        this.xrLabel1.StylePriority.UseTextAlignment = false;
        this.xrLabel1.Text = "CÔNG TY CP THẾ GIỚI GIẢI TRÍ ";
        this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        // 
        // ReportFooter
        // 
        this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrtngayketxuat,
            this.xrl_ten3,
            this.xrl_footer3,
            this.xrl_footer1,
            this.xrl_ten1});
        this.ReportFooter.HeightF = 195F;
        this.ReportFooter.Name = "ReportFooter";
        // 
        // xrtngayketxuat
        // 
        this.xrtngayketxuat.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Italic);
        this.xrtngayketxuat.LocationFloat = new DevExpress.Utils.PointFloat(764.4582F, 21.875F);
        this.xrtngayketxuat.Name = "xrtngayketxuat";
        this.xrtngayketxuat.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrtngayketxuat.SizeF = new System.Drawing.SizeF(306.5414F, 23F);
        this.xrtngayketxuat.StylePriority.UseFont = false;
        this.xrtngayketxuat.StylePriority.UseTextAlignment = false;
        this.xrtngayketxuat.Text = "Hà Nội, ngày 15 tháng 4 năm 2013";
        this.xrtngayketxuat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_ten3
        // 
        this.xrl_ten3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_ten3.LocationFloat = new DevExpress.Utils.PointFloat(764.4582F, 134.375F);
        this.xrl_ten3.Name = "xrl_ten3";
        this.xrl_ten3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ten3.SizeF = new System.Drawing.SizeF(306.5418F, 23F);
        this.xrl_ten3.StylePriority.UseFont = false;
        this.xrl_ten3.StylePriority.UseTextAlignment = false;
        this.xrl_ten3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_footer3
        // 
        this.xrl_footer3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_footer3.LocationFloat = new DevExpress.Utils.PointFloat(764.4582F, 46.875F);
        this.xrl_footer3.Name = "xrl_footer3";
        this.xrl_footer3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_footer3.SizeF = new System.Drawing.SizeF(306.5414F, 23F);
        this.xrl_footer3.StylePriority.UseFont = false;
        this.xrl_footer3.StylePriority.UseTextAlignment = false;
        this.xrl_footer3.Text = "NGƯỜI DUYỆT";
        this.xrl_footer3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_footer1
        // 
        this.xrl_footer1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
        this.xrl_footer1.LocationFloat = new DevExpress.Utils.PointFloat(89.02499F, 46.875F);
        this.xrl_footer1.Name = "xrl_footer1";
        this.xrl_footer1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_footer1.SizeF = new System.Drawing.SizeF(209.375F, 23F);
        this.xrl_footer1.StylePriority.UseFont = false;
        this.xrl_footer1.StylePriority.UseTextAlignment = false;
        this.xrl_footer1.Text = "NGƯỜI LẬP BÁO CÁO";
        this.xrl_footer1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // xrl_ten1
        // 
        this.xrl_ten1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
        this.xrl_ten1.LocationFloat = new DevExpress.Utils.PointFloat(89.02499F, 134.375F);
        this.xrl_ten1.Name = "xrl_ten1";
        this.xrl_ten1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
        this.xrl_ten1.SizeF = new System.Drawing.SizeF(209.375F, 23F);
        this.xrl_ten1.StylePriority.UseFont = false;
        this.xrl_ten1.StylePriority.UseTextAlignment = false;
        this.xrl_ten1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
        // 
        // PageFooter
        // 
        this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1});
        this.PageFooter.HeightF = 54.00002F;
        this.PageFooter.Name = "PageFooter";
        // 
        // xrPageInfo1
        // 
        this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 11F);
        this.xrPageInfo1.Format = "Trang {0} của {1}";
        this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(953.9584F, 21.00004F);
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
            this.xrTable13});
        this.GroupHeader1.HeightF = 29.95834F;
        this.GroupHeader1.Name = "GroupHeader1";
        // 
        // xrTable13
        // 
        this.xrTable13.Borders = ((DevExpress.XtraPrinting.BorderSide)(((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Right)
        | DevExpress.XtraPrinting.BorderSide.Bottom)));
        this.xrTable13.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
        this.xrTable13.Name = "xrTable13";
        this.xrTable13.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow13});
        this.xrTable13.SizeF = new System.Drawing.SizeF(1081F, 29.95834F);
        this.xrTable13.StylePriority.UseBorders = false;
        // 
        // xrTableRow13
        // 
        this.xrTableRow13.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60,
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell65,
            this.xrTableCell66,
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70,
            this.xrTableCell71,
            this.xrTableCell72,
            this.xrTableCell73,
            this.xrTableCell74,
            this.xrTableCell75,
            this.xrTableCell76,
            this.xrTableCell77,
            this.xrTableCell78,
            this.xrTableCell79});
        this.xrTableRow13.Name = "xrTableRow13";
        this.xrTableRow13.Weight = 1D;
        // 
        // xrTableCell58
        // 
        this.xrTableCell58.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell58.Name = "xrTableCell58";
        this.xrTableCell58.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 2, 2, 100F);
        this.xrTableCell58.StylePriority.UseFont = false;
        this.xrTableCell58.StylePriority.UsePadding = false;
        this.xrTableCell58.StylePriority.UseTextAlignment = false;
        this.xrTableCell58.Text = "ÁDFASDFSDF";
        this.xrTableCell58.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
        this.xrTableCell58.Weight = 0.56025909410291108D;
        // 
        // xrTableCell59
        // 
        this.xrTableCell59.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell59.Name = "xrTableCell59";
        this.xrTableCell59.StylePriority.UseFont = false;
        this.xrTableCell59.StylePriority.UsePadding = false;
        this.xrTableCell59.StylePriority.UseTextAlignment = false;
        this.xrTableCell59.Text = "190";
        this.xrTableCell59.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell59.Weight = 0.13393148544967409D;
        // 
        // xrTableCell60
        // 
        this.xrTableCell60.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell60.Name = "xrTableCell60";
        this.xrTableCell60.StylePriority.UseFont = false;
        this.xrTableCell60.StylePriority.UsePadding = false;
        this.xrTableCell60.StylePriority.UseTextAlignment = false;
        this.xrTableCell60.Text = "174";
        this.xrTableCell60.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell60.Weight = 0.13393152067449227D;
        // 
        // xrTableCell61
        // 
        this.xrTableCell61.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell61.Name = "xrTableCell61";
        this.xrTableCell61.StylePriority.UseFont = false;
        this.xrTableCell61.StylePriority.UsePadding = false;
        this.xrTableCell61.StylePriority.UseTextAlignment = false;
        this.xrTableCell61.Text = "1";
        this.xrTableCell61.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell61.Weight = 0.081948665737837878D;
        // 
        // xrTableCell62
        // 
        this.xrTableCell62.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell62.Name = "xrTableCell62";
        this.xrTableCell62.StylePriority.UseFont = false;
        this.xrTableCell62.StylePriority.UsePadding = false;
        this.xrTableCell62.StylePriority.UseTextAlignment = false;
        this.xrTableCell62.Text = "-";
        this.xrTableCell62.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell62.Weight = 0.081490135117964879D;
        // 
        // xrTableCell63
        // 
        this.xrTableCell63.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell63.Name = "xrTableCell63";
        this.xrTableCell63.StylePriority.UseFont = false;
        this.xrTableCell63.StylePriority.UsePadding = false;
        this.xrTableCell63.StylePriority.UseTextAlignment = false;
        this.xrTableCell63.Text = "-";
        this.xrTableCell63.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell63.Weight = 0.088799962951161243D;
        // 
        // xrTableCell64
        // 
        this.xrTableCell64.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell64.Name = "xrTableCell64";
        this.xrTableCell64.StylePriority.UseFont = false;
        this.xrTableCell64.StylePriority.UsePadding = false;
        this.xrTableCell64.StylePriority.UseTextAlignment = false;
        this.xrTableCell64.Text = "175";
        this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell64.Weight = 0.12946335471307052D;
        // 
        // xrTableCell65
        // 
        this.xrTableCell65.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell65.Name = "xrTableCell65";
        this.xrTableCell65.StylePriority.UseFont = false;
        this.xrTableCell65.StylePriority.UsePadding = false;
        this.xrTableCell65.StylePriority.UseTextAlignment = false;
        this.xrTableCell65.Text = "15";
        this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell65.Weight = 0.09427449975766844D;
        // 
        // xrTableCell66
        // 
        this.xrTableCell66.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell66.Name = "xrTableCell66";
        this.xrTableCell66.StylePriority.UseFont = false;
        this.xrTableCell66.StylePriority.UsePadding = false;
        this.xrTableCell66.StylePriority.UseTextAlignment = false;
        this.xrTableCell66.Text = "9";
        this.xrTableCell66.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell66.Weight = 0.093746611440936725D;
        // 
        // xrTableCell67
        // 
        this.xrTableCell67.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell67.Name = "xrTableCell67";
        this.xrTableCell67.StylePriority.UseFont = false;
        this.xrTableCell67.StylePriority.UsePadding = false;
        this.xrTableCell67.StylePriority.UseTextAlignment = false;
        this.xrTableCell67.Text = "151";
        this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell67.Weight = 0.10215447283461322D;
        // 
        // xrTableCell68
        // 
        this.xrTableCell68.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell68.Name = "xrTableCell68";
        this.xrTableCell68.StylePriority.UseFont = false;
        this.xrTableCell68.StylePriority.UsePadding = false;
        this.xrTableCell68.StylePriority.UseTextAlignment = false;
        this.xrTableCell68.Text = "1";
        this.xrTableCell68.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell68.Weight = 0.091498530664096925D;
        // 
        // xrTableCell69
        // 
        this.xrTableCell69.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell69.Name = "xrTableCell69";
        this.xrTableCell69.StylePriority.UseFont = false;
        this.xrTableCell69.StylePriority.UsePadding = false;
        this.xrTableCell69.StylePriority.UseTextAlignment = false;
        this.xrTableCell69.Text = "47";
        this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell69.Weight = 0.0914986556748949D;
        // 
        // xrTableCell70
        // 
        this.xrTableCell70.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell70.Name = "xrTableCell70";
        this.xrTableCell70.StylePriority.UseFont = false;
        this.xrTableCell70.StylePriority.UsePadding = false;
        this.xrTableCell70.StylePriority.UseTextAlignment = false;
        this.xrTableCell70.Text = "43";
        this.xrTableCell70.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell70.Weight = 0.091499038019263318D;
        // 
        // xrTableCell71
        // 
        this.xrTableCell71.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell71.Name = "xrTableCell71";
        this.xrTableCell71.StylePriority.UseFont = false;
        this.xrTableCell71.StylePriority.UsePadding = false;
        this.xrTableCell71.StylePriority.UseTextAlignment = false;
        this.xrTableCell71.Text = "21";
        this.xrTableCell71.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell71.Weight = 0.091498360478213386D;
        // 
        // xrTableCell72
        // 
        this.xrTableCell72.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell72.Name = "xrTableCell72";
        this.xrTableCell72.StylePriority.UseFont = false;
        this.xrTableCell72.StylePriority.UsePadding = false;
        this.xrTableCell72.StylePriority.UseTextAlignment = false;
        this.xrTableCell72.Text = "63";
        this.xrTableCell72.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell72.Weight = 0.091581996640806684D;
        // 
        // xrTableCell73
        // 
        this.xrTableCell73.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell73.Name = "xrTableCell73";
        this.xrTableCell73.StylePriority.UseFont = false;
        this.xrTableCell73.StylePriority.UsePadding = false;
        this.xrTableCell73.StylePriority.UseTextAlignment = false;
        this.xrTableCell73.Text = "51";
        this.xrTableCell73.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell73.Weight = 0.10008026651057374D;
        // 
        // xrTableCell74
        // 
        this.xrTableCell74.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell74.Name = "xrTableCell74";
        this.xrTableCell74.StylePriority.UseFont = false;
        this.xrTableCell74.StylePriority.UsePadding = false;
        this.xrTableCell74.StylePriority.UseTextAlignment = false;
        this.xrTableCell74.Text = "22";
        this.xrTableCell74.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell74.Weight = 0.099520278832786968D;
        // 
        // xrTableCell75
        // 
        this.xrTableCell75.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell75.Name = "xrTableCell75";
        this.xrTableCell75.StylePriority.UseFont = false;
        this.xrTableCell75.StylePriority.UsePadding = false;
        this.xrTableCell75.StylePriority.UseTextAlignment = false;
        this.xrTableCell75.Text = "102";
        this.xrTableCell75.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell75.Weight = 0.10844739817217158D;
        // 
        // xrTableCell76
        // 
        this.xrTableCell76.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell76.Name = "xrTableCell76";
        this.xrTableCell76.StylePriority.UseFont = false;
        this.xrTableCell76.StylePriority.UsePadding = false;
        this.xrTableCell76.StylePriority.UseTextAlignment = false;
        this.xrTableCell76.Text = "81";
        this.xrTableCell76.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell76.Weight = 0.091582041273439052D;
        // 
        // xrTableCell77
        // 
        this.xrTableCell77.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell77.Name = "xrTableCell77";
        this.xrTableCell77.StylePriority.UseFont = false;
        this.xrTableCell77.StylePriority.UsePadding = false;
        this.xrTableCell77.StylePriority.UseTextAlignment = false;
        this.xrTableCell77.Text = "94";
        this.xrTableCell77.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell77.Weight = 0.0959113469867878D;
        // 
        // xrTableCell78
        // 
        this.xrTableCell78.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell78.Name = "xrTableCell78";
        this.xrTableCell78.StylePriority.UseFont = false;
        this.xrTableCell78.StylePriority.UsePadding = false;
        this.xrTableCell78.StylePriority.UseTextAlignment = false;
        this.xrTableCell78.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell78.Weight = 0.1272428777597989D;
        // 
        // xrTableCell79
        // 
        this.xrTableCell79.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
        this.xrTableCell79.Name = "xrTableCell79";
        this.xrTableCell79.StylePriority.UseFont = false;
        this.xrTableCell79.StylePriority.UsePadding = false;
        this.xrTableCell79.StylePriority.UseTextAlignment = false;
        this.xrTableCell79.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
        this.xrTableCell79.Weight = 0.41963940620683593D;
        // 
        // rpwg_BaoCaoTongHopNhanSuToanCongTy
        // 
        this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.ReportFooter,
            this.PageFooter,
            this.GroupHeader1});
        this.Landscape = true;
        this.Margins = new System.Drawing.Printing.Margins(48, 40, 54, 36);
        this.PageHeight = 827;
        this.PageWidth = 1169;
        this.PaperKind = System.Drawing.Printing.PaperKind.A4;
        this.Version = "10.1";
        ((System.ComponentModel.ISupportInitialize)(this.xrTable14)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrRichText1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrChartGender)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrChartDegree)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesLabel6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(pieSeriesView6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrChartContractType)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable12)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable8)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable9)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable6)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable7)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable4)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable5)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable10)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable11)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable3)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.xrTable13)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

}
