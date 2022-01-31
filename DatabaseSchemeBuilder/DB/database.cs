

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;


namespace DatabaseSchemeBuilder.DB
{
   public partial class database : DbContext
    {

        //specifiying tables

        public virtual DbSet<Guild> Guilds { get; set; }
        public virtual DbSet<ProfanitySettings> ProfanitySettings { get; set; }
        public virtual DbSet<Profanitylist> Profanitylists { get; set; }
        public virtual DbSet<siteSettings> SiteSettings { get; set; }
        public virtual DbSet<siteList> SiteLists { get; set; }
        public virtual DbSet<PrefixList> PrefixLists { get; set; }
        public virtual DbSet<RemovePunishment> RemovePunishments { get; set; }
        public virtual DbSet<PremuimSettings> PremuimSettings { get; set;}
        public virtual DbSet<Logs> Logs { get; set; }
        public virtual DbSet<LogSettings> LogSettings { get; set; }
        public virtual DbSet<EnabledSettings> EnabledSettings { get; set; } 
        public virtual DbSet<IpSettings> IpSettings { get; set; }   
        public virtual DbSet<EmailSettings> EmailSettings { get; set; }
        public virtual DbSet<CreditCardSettings> CreditCardSettings { get; set; }
        public virtual DbSet<PostcodeSettings> PostcodeSettings { get; set; }





        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            #if DEBUG
            optionsBuilder.UseMySQL("server=localhost;database=antidox;user=AntiDox;password=antidox");

            #else
            //connection strings
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = "antidox.sqlite" };
            var connectionString = connectionStringBuilder.ToString();
            var connection = new SqliteConnection(connectionString);
            optionsBuilder.UseSqlite(connection);
            #endif


        }

    }
}
