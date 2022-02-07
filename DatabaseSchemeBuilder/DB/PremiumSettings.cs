using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class PremiumSettings
    {
        [Key]
        public long ID { get; set; }
        public double Ispremium { get; set; }
        public double TrailVersion { get; set; }
        public DateTime GotPremiumOn { get; set; } = DateTime.Now;
    }
}
