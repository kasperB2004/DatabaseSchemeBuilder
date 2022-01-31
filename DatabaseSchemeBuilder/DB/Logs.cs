using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DatabaseSchemeBuilder.DB
{
    public class Logs
    {
        [Key]
        public long ID { get; set; }
        public long ServerCaseID { get; set; }
        public long PunishedUserId { get; set; }
        public string PunishedUserName { get; set; }
        public string TypeOfPunishment { get; set; }
        public DateTime TimeOfPunishment { get; set; }
        public string MessagePosted { get; set; }
        public byte[] IV { get; set; }
        public DateTime TimePosted { get; set; }
        public string TypeOfForbiddenMessage { get; set; }
        
    }
}
