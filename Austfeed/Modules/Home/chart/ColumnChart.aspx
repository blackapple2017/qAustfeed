﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ColumnChart.aspx.cs" Inherits="Modules_Home_chart_ColumnChart" %>

<%@ Register Assembly="Highcharts" Namespace="Highcharts.UI" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="js/jquery.min.js"></script>
    <script type="text/javascript" src="js/highcharts.js"></script>
    <script type="text/javascript" src="js/modules/exporting.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:ColumnChart Width="100%" Height="270" ID="hcFrutas" runat="server" />
    </div>
    </form>
</body>
</html>
