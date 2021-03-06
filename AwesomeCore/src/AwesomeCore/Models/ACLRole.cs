using System.Collections.Generic;

namespace AwesomeCore.Models
{
    public class ACLRole
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public bool Enabled { get; set; }
        public List<ACLPermission> Permissions { get; set; }
    }
}