using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSchemeBuilder.Encryption
{
    public class TransferIvMessage
    {        
        public string Message { get; set; }
        public byte[] IV { get; set; }
    }
}
