---
layout: post
title: Row Spanning in ASP.NET Core Gantt Chart | Merge Cells | Syncfusion
description: Learn how to span rows in Syncfusion ASP.NET Core Gantt Chart with rowSpan attribute to merge cells across rows.
keywords: asp.net core gantt row spanning, rowspan, querycellinfo, merge cells, shared info, syncfusion gantt
canonical: https://help.syncfusion.com/gantt-sdk/asp-net-core/gantt-chart/rows/row-spanning
platform: gantt-sdk
control: Row Spanning - Gantt Chart
documentation: ug
domainurl: https://help.syncfusion.com/gantt-sdk
appliesto: UI Component Suite, Gantt SDK/overview
---

# Implementing Row Spanning for Multi-Row Cells in ASP.NET Core Gantt Chart

The [ASP.NET Core Gantt Chart](https://www.syncfusion.com/gantt-sdk/aspnet-core-gantt-chart) supports row cell spanning, allowing multiple cells in a row to merge into a single cell. This is useful for displaying shared information across rows without duplication.

To enable row spanning, use the `rowSpan` attribute inside the [`QueryCellInfo`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_QueryCellInfo) event. This event is triggered for each grid cell, where you can define the number of rows a cell should span based on its data.

In the example below, the **Soil test approval** cell spans across two rows in the **Task Name** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/rows/rowSpanning/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="RowSpanning.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/rows/rowSpanning/rowSpanning.cs %}
{% endhighlight %}
{% endtabs %}

![Row spanning](../images/rowSpanning.png)

> * You can use both `rowSpan` and `colSpan` together to merge grid cells vertically and horizontally.