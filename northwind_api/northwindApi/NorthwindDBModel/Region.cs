using System;
using System.Collections.Generic;

namespace northwindApi.NorthwindDBModel
{
    public partial class Region
    {
        public Region()
        {
            Territory = new HashSet<Territory>();
        }

        public int RegionId { get; set; }
        public string RegionName { get; set; }

        public virtual ICollection<Territory> Territory { get; set; }
    }
}
