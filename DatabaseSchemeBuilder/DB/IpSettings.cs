using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class IpSettings
    {
        [Key]
        public long id { get; set; }
        public string Punishment { get; set; } = "Ban";
        public bool permPunishment { get; set; } = false;
        public TimeSpan Time { get; set; } = TimeSpan.FromDays(7);
    }
}
