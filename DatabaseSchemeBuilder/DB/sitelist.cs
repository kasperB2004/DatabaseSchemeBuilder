using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class siteList
    {
        [Key]
        public long ID { get; set; }
        public string word { get; set; }
        public ICollection<siteSettings> siteSettings  { get; set; }
    }
}
