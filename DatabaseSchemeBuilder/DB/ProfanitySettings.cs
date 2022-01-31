using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class ProfanitySettings
    {
        [Key]
        public long id { get; set; }
        public string Punishment { get; set; } = "Mute";
        public bool permPunishment { get; set; } = false;
        public Nullable<TimeSpan> Time { get; set; } = TimeSpan.FromHours(12);
        public ICollection<Profanitylist> Profanitylists { get; set; }

    }
}
