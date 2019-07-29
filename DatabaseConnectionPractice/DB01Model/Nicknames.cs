using System;
using System.Collections.Generic;

namespace DatabaseConnectionPractice.DB01Model
{
    public partial class Nicknames
    {
        public int NicknameId { get; set; }
        public string Nickname { get; set; }
        public int EmpId { get; set; }

        public virtual Employees Emp { get; set; }
    }
}
