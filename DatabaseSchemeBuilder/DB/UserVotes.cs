using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class UserVotes
    {
        [Key]
        public long UserID { get; set; }
        public DateTime Lastvote { get; set; }
        public int VoteCount { get; set; }
    }
}
