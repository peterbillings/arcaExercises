using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class EmployeeTerritory
    {
        public int EmployeeTerritoryId { get; set; }
        public int EmployeeId { get; set; }
        public int TerritoryId { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Territory Territory { get; set; }
    }
}
