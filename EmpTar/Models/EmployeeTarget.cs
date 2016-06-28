using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EmpTar.Models
{
    public class EmployeeTarget
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }
        public int TargetHour { get; set; }
    }

    public class EmployeeTargetDBContext : DbContext
    {
        public DbSet<EmployeeTarget> EmployeeTargets { get; set; }
    }

}