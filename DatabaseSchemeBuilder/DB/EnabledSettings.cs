using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public partial class EnabledSettings
    {
        [Key]
        public long ID { get; set; }
        public bool SitesEnabled { get; set; } = true;

        public bool ProfanityEnabled { get; set; } = true;

        public bool IpEnabled { get; set; } = true;

        public bool EmailEnabled { get; set; } =true;


    
    }
}
