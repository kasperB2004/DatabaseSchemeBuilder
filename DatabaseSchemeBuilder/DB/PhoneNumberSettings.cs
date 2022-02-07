using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class PhoneNumberSettings
    {
        [Key]
        public long id { get; set; }
        public string Punishment { get; set; } = "Ban";
        public bool permPunishment { get; set; } = true;
        public Nullable<TimeSpan> Time { get; set; } = TimeSpan.FromDays(0);
    }
}
