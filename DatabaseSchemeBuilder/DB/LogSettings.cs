using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class LogSettings
    {
        [Key]
        public long id { get; set; }
        public long channelid { get; set; } 
        public bool DiscordLogsEnabled { get; set; } = false;

        public bool DatabaseLogsEnabled { get; set; } = true;
        public TimeSpan TimeStoredFor { get; set; } = TimeSpan.FromDays(30);
        public ICollection<Logs> Logs {get;set;}
    }
}
