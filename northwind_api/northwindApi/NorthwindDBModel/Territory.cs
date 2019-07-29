using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class Territory
    {
        public Territory()
        {
            EmployeeTerritory = new HashSet<EmployeeTerritory>();
        }

        public int TerritoryId { get; set; }
        public string TerritoryName { get; set; }
        public int RegionId { get; set; }

        public virtual Region Region { get; set; }
        public virtual ICollection<EmployeeTerritory> EmployeeTerritory { get; set; }
    }
}
