using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyServer.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime Deadline { get; set; }

        public virtual ICollection<Issue> Issues { get; set; } = new HashSet<Issue>();

        public int AuthorId { get; set; }
        public User Author { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
