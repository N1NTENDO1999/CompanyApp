using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyServer.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime RegisteredAt { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
