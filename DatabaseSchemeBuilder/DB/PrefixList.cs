using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class PrefixList
    {
        [Key]
        public long id { get; set; }
        public string Prefix { get; set; }
        public ICollection<Guild> guilds { get; set; }
    }
}
