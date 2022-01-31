using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class PremuimSettings
    {
        [Key]
        public int Id { get; set; }
        public int DefaultMaxWords { get; set; }
        public int PremuimMaxWords { get; set; }
        public int DefaultMaxSites { get;set; }
        public int PremuimMaxSites { get; set; }
        public DateTime DefaultMaxStoredLogs { get; set; }
        public DateTime PremuimMaxStoredLogs { get;set; }



    }
}
