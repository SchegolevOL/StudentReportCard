using DbConfigLib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentReportCard.App
{
    public class DB : DbContext
    {
        public DbSet<StudentReport> TableStudetReports=>Set<StudentReport>();
        
        public DB()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(DbConfig.ImportFromJson("db.json").ToString());
        }
    }
}
