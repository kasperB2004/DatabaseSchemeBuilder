using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSchemeBuilder.DB
{
    public class EmailSettings
    {

        [Key]
        public long id { get; set; }
        public string Punishment { get; set; } = "Mute";
        public bool permPunishment { get; set; } = false;
        public Nullable<TimeSpan> Time { get; set; } = TimeSpan.FromDays(1);
    }
}
