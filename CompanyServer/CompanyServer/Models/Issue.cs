using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyServer.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Finished_At { get; set; }

        public int StateId { get; set; }
        public TaskState State { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public int PerformerId { get; set; }
        public User Performer { get; set; }
    }
}
