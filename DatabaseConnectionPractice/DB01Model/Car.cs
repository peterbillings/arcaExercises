using System;
using System.Collections.Generic;

namespace DatabaseConnectionPractice.DB01Model
{
    public partial class Car
    {
        public int CarId { get; set; }
        public string Make { get; set; }
        public int Model { get; set; }
        public int? AutomakerId { get; set; }
    }
}
