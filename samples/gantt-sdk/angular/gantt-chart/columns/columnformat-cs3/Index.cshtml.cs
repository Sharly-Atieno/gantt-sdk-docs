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
                new GanttDataSource { TaskId = 1, TaskName = "Inicio del proyecto", StartDate = new DateTime(2023, 01, 01), EndDate = new DateTime(2023, 01, 05), Duration = 5, Progress = 1000 },
                new GanttDataSource { TaskId = 2, TaskName = "Análisis del sitio", StartDate = new DateTime(2023, 01, 06), EndDate = new DateTime(2023, 01, 10), Duration = 4, Progress = 1500 },
                new GanttDataSource { TaskId = 3, TaskName = "Pruebas de suelo", StartDate = new DateTime(2023, 01, 11), EndDate = new DateTime(2023, 01, 14), Duration = 3, Progress = 1200 },
                new GanttDataSource { TaskId = 4, TaskName = "Proceso de aprobación", StartDate = new DateTime(2023, 01, 15), EndDate = new DateTime(2023, 01, 18), Duration = 3, Progress = 1800 },
                new GanttDataSource { TaskId = 5, TaskName = "Estimación de presupuesto", StartDate = new DateTime(2023, 01, 19), EndDate = new DateTime(2023, 01, 23), Duration = 4, Progress = 2000 },
                new GanttDataSource { TaskId = 6, TaskName = "Diseño del plano", StartDate = new DateTime(2023, 01, 24), EndDate = new DateTime(2023, 01, 28), Duration = 4, Progress = 2500 },
                new GanttDataSource { TaskId = 7, TaskName = "Listado de materiales", StartDate = new DateTime(2023, 01, 29), EndDate = new DateTime(2023, 02, 02), Duration = 4, Progress = 3000 },
                new GanttDataSource { TaskId = 8, TaskName = "Aprobación final", StartDate = new DateTime(2023, 02, 03), EndDate = new DateTime(2023, 02, 06), Duration = 3, Progress = 3500 }
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
