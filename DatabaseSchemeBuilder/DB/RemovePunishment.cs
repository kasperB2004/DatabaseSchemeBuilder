using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.DB
{
    public class RemovePunishment
    {
        [Key]
        public long Id { get; set; }
        public long UserId { get; set; }
        public string Username { get; set; }
        public DateTime TimeOfPunishment { get; set; }
        public DateTime PunishmentTime { get; set; }
        public string TypeOfPunishment { get; set; }
       
    }
}
