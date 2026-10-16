---
layout: post
title: Timeline in ASP.NET Core Gantt Chart | View Modes | Syncfusion
description: Learn how to configure timeline in Syncfusion ASP.NET Core Gantt Chart with view modes, zooming, weekend highlighting, and templates to visualize project schedules.
keywords: asp.net core gantt timeline, timeline view modes, timelinesettings, weekend highlight, syncfusion gantt
canonical: https://help.syncfusion.com/gantt-sdk/asp-net-core/gantt-chart/time-line/time-line
platform: gantt-sdk
control: Timeline - Gantt Chart
documentation: ug
domainurl: https://help.syncfusion.com/gantt-sdk
appliesto: UI Component Suite, Gantt SDK/overview
---

# Configuring Timeline Settings in ASP.NET Core Gantt Chart


## Configure timeline view modes

Set the timeline view mode using the [`TimelineViewMode`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.TimelineViewMode.html) property, with top tier displaying broader units (e.g., weeks) and bottom tier finer ones (e.g., days), ideal for project schedules.

### Week timeline mode

In Week mode, the top tier shows weeks and the bottom tier days, suitable for short-term project tracking.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/weekMode/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="WeekMode.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/weekMode/weekMode.cs %}
{% endhighlight %}
{% endtabs %}

![Week timeline mode](../images/weekMode.png)

### Month timeline mode

In Month mode, the top tier shows months and the bottom tier weeks, ideal for medium-term planning.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/monthMode/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="MonthMode.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/monthMode/monthMode.cs %}
{% endhighlight %}
{% endtabs %}

![Month timeline mode](../images/monthMode.png)

### Year timeline mode

In Year mode, the top tier shows years and the bottom tier months, suitable for long-term projects.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/yearMode/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="YearMode.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/yearMode/yearMode.cs %}
{% endhighlight %}
{% endtabs %}

![Year timeline mode](../images/yearMode.png)

### Day timeline mode

In Day mode, the top tier shows days and the bottom tier hours, ideal for detailed daily scheduling.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/dayMode/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="DayMode.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/dayMode/dayMode.cs %}
{% endhighlight %}
{% endtabs %}

![Day timeline mode](../images/dayMode.png)

### Hour timeline mode

In Hour mode, the top tier shows hours and the bottom tier minutes, perfect for minute-level task tracking.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/hourMode/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="HourMode.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/hourMode/hourMode.cs %}
{% endhighlight %}
{% endtabs %}

![Hour timeline mode](../images/hourMode.png)

### Minutes timeline mode

In Minutes timeline mode, the tier displays minute-level intervals, ideal for tracking short-duration tasks with high precision.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/hourMode/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="HourMode.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/hourMode/hourMode.cs %}
{% endhighlight %}
{% endtabs %}

![Minutes timeline mode](../images/hourMode.png)

## Timeline view dates

The Gantt Chart control supports rendering a fixed timeline range using the `ViewStartDate` and `ViewEndDate` properties. These properties allow the visible portion of the timeline to be explicitly defined and locked within the Gantt chart UI, independent of the project's overall scheduling boundaries defined by `ProjectStartDate` and `ProjectEndDate`. The `ProjectStartDate` and `ProjectEndDate` values represent the full scheduling window for the project and are used for baseline processing, critical-path calculations, and project-level reporting. By default, both `ViewStartDate` and `ViewEndDate` are set to **auto**. The following example demonstrates how to configure a custom timeline view range.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/viewDate/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="viewDate.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/viewDate/viewDate.cs %}
{% endhighlight %}
{% endtabs %}

**Key behaviors**

When `ViewStartDate` and `ViewEndDate` are set to concrete Date values, the timeline rendering is restricted to the inclusive range [ViewStartDate, ViewEndDate].

- When `ViewStartDate` is set to **auto**:
  - If `ProjectStartDate` is defined, the timeline begins at `ProjectStartDate`.
  - If `ProjectStartDate` is not defined, the earliest task start date is used as the beginning of the visible range.

- When `ViewEndDate` is set to **auto**:
  - If `ProjectEndDate` is defined, the timeline ends at `ProjectEndDate`.
  - If `ProjectEndDate` is not defined, the maximum task end date is used. If this end date leaves visible white-space in the timeline area, the end date is automatically extended to fill the chart width.

> Note: The `ZoomToFit` feature uses `ProjectStartDate` and `ProjectEndDate` to fit the entire project within the available timeline viewport.

## Customize week start day

In the Gantt Chart control, you can customize the week start day using the [`WeekStartDay`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_WeekStartDay) property. By default, the `WeekStartDay` is set to **0**, which specifies the **Sunday** as a start day of the week. But, you can customize the week start day by using the following code example.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/weekStartDay/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="WeekStartDay.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/weekStartDay/weekStartDay.cs %}
{% endhighlight %}
{% endtabs %}

## Customize automatic timescale update action

In the Gantt Chart control, the schedule timeline will be automatically updated when the tasks date values are updated beyond the project start date and end date ranges. This can be enabled or disabled using the [`UpdateTimescaleView`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_UpdateTimescaleView) property.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/updateTimescaleView/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="UpdateTimescaleView.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/updateTimescaleView/updateTimescaleView.cs %}
{% endhighlight %}
{% endtabs %}

## Dynamically change timeline mode

You can dynamically change the timeline mode in the Gantt Chart by updating the `timelineSettings.timelineViewMode` property using the **change** event of the DropDownList control.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/changeTimelineMode/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Timeline cells tooltip

In the Gantt Chart control, you can enable or disable the mouse hover tooltip of timeline cells using the [`TimelineSettings.ShowTooltip`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_ShowTooltip) property. The default value of this property is **true**.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/tooltip/timelinecellTooltip/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="TimelinecellTooltip.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/tooltip/timelinecellTooltip/timelinecellTooltip.cs %}
{% endhighlight %}
{% endtabs %}

## Show/hide weekends

Highlight weekends by setting [`TimelineSettings.ShowWeekend`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html#Syncfusion_EJ2_Gantt_GanttTimelineSettings_ShowWeekend) to **true** and `WorkWeek` to define weekdays, aiding in identifying non-working days in a project schedule.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/showWeekend/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="showWeekend.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/showWeekend/showWeekend.cs %}
{% endhighlight %}
{% endtabs %}

**Limitations:**

- The `showWeekend` feature does not support baselines and not compatible with the manual task mode.
- Non-working hours cannot be excluded when `showWeekend` is set to **false**.
- Holidays are not excluded from the timeline if `showWeekend` is set to **false**.

## Navigating Gantt Timeline

You can adjust the Gantt chart view by shifting the timeline forward or backward by one unit using the following methods:

- `previousTimeSpan`: Moves the timeline backward by one unit from the current start point.

- `nextTimeSpan`: Moves the timeline forward by one unit from the current end point.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/spanTime/tagHelper %}
{% endhighlight %}
{% endtabs %}

## Timeline template

In the Gantt Chart control, you can customize timeline cells using the [`TimelineSettings.TimelineTemplate`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.GanttTimelineSettings.html) property, allowing for the customization of HTML content within timeline cells. This feature enhances the visual appeal and enables personalized functionality.

When designing the timeline cells, you can utilize the following context properties within the template:

- `date`: Defines the date of the timeline cells.
- `value`: Defines the formatted date value that will be displayed in the timeline cells.
- `tier`: Defines whether the cell is part of the top or bottom tier.

The following code example how to customize the top tier to display the week's weather details and the bottom tier to highlight working and non-working days, with formatted text for holidays.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/tooltip/timelineTemplate/tagHelper %}
{% endhighlight %}

{% highlight c# tabtitle="timelineTemplate.cs" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/tooltip/timelineTemplate/timelineTemplate.cs %}
{% endhighlight %}
{% endtabs %}

## Infinite timeline scrolling

The [`EnableInfiniteTimelineScroll`](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Gantt.Gantt.html#Syncfusion_EJ2_Gantt_Gantt_EnableInfiniteTimelineScroll) property enables infinite horizontal scrolling by dynamically extending the visible timeline range as the user navigates. Set `EnableInfiniteTimelineScroll` to **true** to enable this behavior.

**Key behaviors**

- When `enableInfiniteTimelineScroll` is enabled, the timeline automatically extends in the forward direction as the user scrolls using the horizontal scrollbar or clicks the forward scroll arrow.
- In the backward direction, the timeline extends only when the user clicks the backward scroll arrow. Scrolling or dragging the scrollbar backward does not trigger timeline extension.
- Infinite scrolling extends only the visible timeline range and does not modify the project dates.

This feature enables exploration of long project schedules without manually updating the timeline range.

{% tabs %}
{% highlight cshtml tabtitle="CSHTML" %}
{% include code-snippet/gantt-sdk/asp-net-core/gantt-chart/timeline/infiniteScroll/tagHelper %}
{% endhighlight %}
{% endtabs %}

![Infinite timeline scrolling](../images/infinite-timeline-scrolling.gif)

## See also

- [How to configure taskbars?](https://help.syncfusion.com/gantt-sdk/asp-net-core/gantt-chart/taskbar)
- [How to zoom the timeline?](https://help.syncfusion.com/gantt-sdk/asp-net-core/gantt-chart/time-line/zooming)
- [How to configure non-working days?](https://help.syncfusion.com/gantt-sdk/asp-net-core/gantt-chart/scheduling-tasks#weekend--non-working-days)