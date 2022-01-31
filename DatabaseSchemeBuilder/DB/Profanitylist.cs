using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class Profanitylist
    {
       [Key]
       public long ID { get; set; }
       public string word { get; set; }
       public ICollection<ProfanitySettings> badwordSettings { get; set; }

    }
}
