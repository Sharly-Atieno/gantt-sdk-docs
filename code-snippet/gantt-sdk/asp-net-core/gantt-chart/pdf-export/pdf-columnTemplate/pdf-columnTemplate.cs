using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CoreSamples.Pages
{
    public class IndexModel : PageModel
    {
        public List<GanttDataSource> GanttDataSourceCollection { get; set; }

        public List<GanttResources> GanttResourcesCollection { get; set; }

        public void OnGet()
        {
            GanttDataSourceCollection = GetTaskCollection();
            GanttResourcesCollection = GetResourcesCollection();
        }

        private List<GanttResources> GetResourcesCollection()
        {
            return new List<GanttResources>()
            {
                new GanttResources { ResourceId = 1, ResourceName = "Martin Tamer" },
                new GanttResources { ResourceId = 2, ResourceName = "Rose Fuller" },
                new GanttResources { ResourceId = 3, ResourceName = "Margaret Buchanan" },
                new GanttResources { ResourceId = 4, ResourceName = "Fuller King" },
                new GanttResources { ResourceId = 5, ResourceName = "Davolio Fuller" },
                new GanttResources { ResourceId = 6, ResourceName = "Van Jack" },
                new GanttResources { ResourceId = 7, ResourceName = "Fuller Buchanan" },
                new GanttResources { ResourceId = 8, ResourceName = "Jack Davolio" },
                new GanttResources { ResourceId = 9, ResourceName = "Tamer Vinet" },
                new GanttResources { ResourceId = 10, ResourceName = "Vinet Fuller" },
                new GanttResources { ResourceId = 11, ResourceName = "Bergs Anton" },
                new GanttResources { ResourceId = 12, ResourceName = "Construction Supervisor" }
            };
        }

        private List<GanttDataSource> GetTaskCollection()
        {
            return new List<GanttDataSource>()
            {
                new GanttDataSource
                {
                    TaskId = 1,
                    TaskName = "Project Initiation",
                    StartDate = new DateTime(2019, 4, 2),
                    EndDate = new DateTime(2019, 4, 21),
                    SubTasks = new List<GanttDataSource>()
                    {
                        new GanttDataSource
                        {
                            TaskId = 2,
                            TaskName = "Identify Site location",
                            StartDate = new DateTime(2019, 4, 2),
                            Duration = 4,
                            Progress = 70,
                            ResourceId = new int[] { 1 }
                        },
                        new GanttDataSource
                        {
                            TaskId = 3,
                            TaskName = "Perform Soil test",
                            StartDate = new DateTime(2019, 4, 2),
                            Duration = 4,
                            Progress = 50,
                            ResourceId = new int[] { 2 }
                        },
                        new GanttDataSource
                        {
                            TaskId = 4,
                            TaskName = "Soil test approval",
                            StartDate = new DateTime(2019, 4, 2),
                            Duration = 4,
                            Progress = 50,
                            Dependency = "3FS",
                            ResourceId = new int[] { 3 }
                        }
                    }
                },
                new GanttDataSource
                {
                    TaskId = 5,
                    TaskName = "Project Estimation",
                    StartDate = new DateTime(2019, 4, 2),
                    EndDate = new DateTime(2019, 4, 21),
                    SubTasks = new List<GanttDataSource>()
                    {
                        new GanttDataSource
                        {
                            TaskId = 6,
                            TaskName = "Develop floor plan for estimation",
                            StartDate = new DateTime(2019, 4, 4),
                            Duration = 3,
                            Progress = 70,
                            ResourceId = new int[] { 4 }
                        },
                        new GanttDataSource
                        {
                            TaskId = 7,
                            TaskName = "List materials",
                            StartDate = new DateTime(2019, 4, 4),
                            Duration = 3,
                            Progress = 50,
                            Dependency = "6FS",
                            ResourceId = new int[] { 3 }
                        }
                    }
                }
            };
        }
    }

    public class GanttResources
    {
        public int ResourceId { get; set; }

        public string ResourceName { get; set; }
    }

    public class GanttDataSource
    {
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? Duration { get; set; }

        public int? Progress { get; set; }

        public string Dependency { get; set; }

        public List<GanttDataSource> SubTasks { get; set; }

        public int[] ResourceId { get; set; }
    }
}
