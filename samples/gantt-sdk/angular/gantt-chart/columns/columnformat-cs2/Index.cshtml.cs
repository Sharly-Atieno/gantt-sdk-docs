using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace CoreSamples.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            ViewBag.DataSource = GanttData();
        }

        public List<GanttDataSource> GanttData()
        {
            List<GanttDataSource> data = new List<GanttDataSource>
            {
                new GanttDataSource { TaskId = 1, TaskName = "Project Initiation", StartDate = new DateTime(2023, 01, 01), EndDate = new DateTime(2023, 01, 05), Duration = 5, Progress = 30 },
                new GanttDataSource { TaskId = 2, TaskName = "Site Analysis", StartDate = new DateTime(2023, 01, 06), EndDate = new DateTime(2023, 01, 10), Duration = 4, Progress = 50 },
                new GanttDataSource { TaskId = 3, TaskName = "Soil Testing", StartDate = new DateTime(2023, 01, 11), EndDate = new DateTime(2023, 01, 14), Duration = 3, Progress = 40 },
                new GanttDataSource { TaskId = 4, TaskName = "Approval Process", StartDate = new DateTime(2023, 01, 15), EndDate = new DateTime(2023, 01, 18), Duration = 3, Progress = 60 },
                new GanttDataSource { TaskId = 5, TaskName = "Budget Estimation", StartDate = new DateTime(2023, 01, 19), EndDate = new DateTime(2023, 01, 23), Duration = 4, Progress = 70 },
                new GanttDataSource { TaskId = 6, TaskName = "Floor Plan Design", StartDate = new DateTime(2023, 01, 24), EndDate = new DateTime(2023, 01, 28), Duration = 4, Progress = 80 },
                new GanttDataSource { TaskId = 7, TaskName = "Material Listing", StartDate = new DateTime(2023, 01, 29), EndDate = new DateTime(2023, 02, 02), Duration = 4, Progress = 90 },
                new GanttDataSource { TaskId = 8, TaskName = "Final Approval", StartDate = new DateTime(2023, 02, 03), EndDate = new DateTime(2023, 02, 06), Duration = 3, Progress = 100 }
            };
            return data;
        }

        public class GanttDataSource
        {
            public int TaskId { get; set; }
            public string TaskName { get; set; }
            public DateTime StartDate { get; set; }
            public DateTime? EndDate { get; set; }
            public int? Duration { get; set; }
            public int? Progress { get; set; }
            public int? ParentId { get; set; }
        }
    }
}
