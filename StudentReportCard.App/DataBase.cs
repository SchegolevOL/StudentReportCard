using DbConfigLib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard.App
{
    public class DataBase : DbContext
    {
        protected DataBase()
        {
            Database.EnsureCreated();
        }

        public DbSet<StudetReport> TableStudetReports=>Set<StudetReport>();
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(DbConfig.ImportFromJson("db.json").ToString());
        }
    }
}
