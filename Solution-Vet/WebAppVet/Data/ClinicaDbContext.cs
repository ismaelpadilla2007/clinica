using ClientPatientManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebAppVet.Data
{
    public class ClinicaDbContext : DbContext
    {
        public ClinicaDbContext() :base("ClinicaDbContext")
        {
        }

        public DbSet<Room> Rooms { get; set; }
    }
}