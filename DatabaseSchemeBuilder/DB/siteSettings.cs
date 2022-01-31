using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class siteSettings
    {
        [Key]
        public long id { get; set; }
        public string Punishment { get; set; } = "Mute";
        public bool permPunishment { get; set; } = false;
        public Nullable<TimeSpan> Time { get; set; } = TimeSpan.FromDays(1);
        public bool IsWhiteList { get; set; } = false;
        public ICollection<siteList> siteList { get; set; }
    }
}
