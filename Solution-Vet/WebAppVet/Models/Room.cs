using ClientPatientManagement.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientPatientManagement.Core.Models
{
    public partial class Room : IEntity
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Location { get; set; }
    }
}