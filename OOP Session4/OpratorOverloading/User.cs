using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Session4.OpratorOverloading
{
    //Model : Is The Class Thaat Represent The Table In Datebase
    internal class User
    {
        public int  Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public Guid SecurityStmp { get; set; }

    }
}
