using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyServer.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created_At { get; set; }
        public DateTime Finished_At { get; set; }
        public int State { get; set; }

        public int Project_id { get; set; }
        public int Performer_id { get; set; }
    }
}
