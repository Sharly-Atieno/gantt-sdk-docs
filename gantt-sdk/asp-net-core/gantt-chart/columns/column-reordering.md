---
layout: post
title: Reorder Columns in ASP.NET Core Gantt Chart | Drag & Drop | Syncfusion
description: Learn how to reorder columns in Syncfusion ASP.NET Core Gantt Chart with drag-and-drop or programmatically, with options to restrict reordering for specific columns.
keywords: asp.net core gantt reorder columns, allowreordering, drag and drop, column reorder, reordercolumns, syncfusion gantt
canonical: https://help.syncfusion.com/gantt-sdk/asp-net-core/gantt-chart/columns/column-reordering
platform: gantt-sdk
control: Column Reorder - Gantt Chart
documentation: ug
domainurl: https://help.syncfusion.com/gantt-sdk
appliesto: UI Component Suite, Gantt SDK/overview
---

# Column Reordering with Drag and Drop Support in ASP.NET Core Gantt Chart

The [ASP.NET Core Gantt Chart](https://www.syncfusion.com/gantt-sdk/aspnet-core-gantt-chart) supports column reordering by dragging a column header to a new position.

To enable column reordering, set the [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowReordering) property to **true** in the Gantt configuration.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/reOrdering/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReOrdering.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/reOrdering/reOrdering.cs %}
{% endhighlight %}
{% endtabs %}


> * You can modify the appearance of column headers during drag-and-drop using the [`ColumnDrag`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnDrag) and [`ColumnDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnDrop) events.
> * After columns are reordered, the visual column index changes but field names remain the same. If your logic references column indices (e.g., `gantt.treeGrid.columns[0]`), update those references after reordering.
> * You can disable the reordering of a particular column by setting the [`Columns.AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_AllowReordering) property to **false**.

## Disable column reordering for specific columns

In Syncfusion<sup style="font-size:70%">&reg;</sup> ASP.NET Core Gantt Chart control, when `AllowReordering` is enabled globally, you can restrict reordering for individual columns by setting their [`Columns.AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_AllowReordering) property to **false**.

> Column-level `AllowReordering = false` only works when global `AllowReordering` is **true**; if global reordering is disabled, all columns cannot be reordered regardless of column-level settings.

The following example demonstrates how reordering is restricted for the **Task Name** column.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/columnreorder-cs2/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnReorder.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/columnreorder-cs2/columnreorder-cs2.cs %}
{% endhighlight %}
{% endtabs %}


## Reorder columns programmatically

You can programmatically reorder columns in the ASP.NET Core Gantt Chart control using available methods based on field names, index, or target index.

> To perform programmatic column reordering, the global [`AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_AllowReordering) property must be enabled and the target column's [`Columns.AllowReordering`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttColumn.html#Syncfusion_EJ2_Gantt_GanttColumn_AllowReordering) property must not be set to **false**.

### Reorder columns using field names

**Use this method when:** You have the field names of columns you want to reorder and prefer a readable, semantic approach.

You can reorder columns in the Gantt Chart control using the `reorderColumns` method of the Gantt instance accessed as `document.getElementById("Gantt").ej2_instances[0]`. This method reorders one or more columns by specifying the source column(s) and the target column using their field names:

- **fromFName**: The field name of the column to move.
- **toFName**: The field name of the target column position.

The following demonstrates how to reorder columns by placing **Task Name** to position before **Task ID**, or moving **Task Name**, **Start Date**, **Duration** to position before **Task ID**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/columnreorder-cs3/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ColumnReorder.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/columnreorder-cs2/columnreorder-cs2.cs %}
{% endhighlight %}
{% endtabs %}

### Reorder columns using column index

**Use this method when:** You need to swap or move columns by their numeric position in the grid, or you're implementing UI controls that work with column positions.

You can reorder columns in the Gantt Chart control using the `reorderColumnByIndex` method on the `treeGrid` object of the Gantt instance. This method repositions a column based on its current index and takes two parameters:

- **fromIndex**: Index of the column to move (zero-based).
- **toIndex**: Target index where the column should be placed (zero-based).

The following demonstrates how to reorder the column at index **1** to position **3**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/columnreorder-cs5/tagHelper %}
{% endhighlight %}
{% endtabs %}


### Reorder columns using target index

**Use this method when:** You want to move multiple columns to a specific position using their field names, combining the semantic clarity of field names with positional control.

You can reorder single or multiple columns in the Gantt Chart control using the `reorderColumnByTargetIndex` method on the `treeGrid` object of the Gantt instance. This method reorders columns based on their field names and the target index. It takes two parameters:

- **fieldName**: The field name (or array of field names for multiple columns) of the column(s) to move.
- **toIndex**: The zero-based index where the column(s) should be placed.

The following demonstrates how to reorder a single column **Task ID** to index **3**, or move multiple columns **Task ID** and **Task Name** together to index **3** (pass an array of field names: `['TaskId', 'TaskName']`).

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/columnreorder-cs6/tagHelper %}
{% endhighlight %}
{% endtabs %}


## Customize column reorder behavior using events

You can customize the column reorder behavior in the Gantt Chart using the [`ColumnDragStart`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnDragStart), [`ColumnDrag`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnDrag), and [`ColumnDrop`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_ColumnDrop) events. These events provide control over each stage of the column drag-and-drop process, allowing for custom logic or restrictions.

The following demonstrates how to handle specific fields during column reordering:
- Cancel `columnDrop` for the **Task ID** field.
- Cancel `columnDrag` for the **Duration** field.
- Change header text for the **Task Name** field during the `columnDragStart` event.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/reorderEvents/tagHelper %}
{% endhighlight %}
{% highlight c# tabtitle="ReorderEvents.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/columns/reorderEvents/reorderEvents.cs %}
{% endhighlight %}
{% endtabs %}

