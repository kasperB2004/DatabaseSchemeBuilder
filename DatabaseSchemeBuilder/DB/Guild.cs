using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseSchemeBuilder.DB
{
    public class Guild
    {
        [Key]
        public long GuildId { get; set; }
        public string GuildName { get; set; }
        public long LastSetByID { get; set; } = 0;
        public string LastSetBy { get; set; } = "AntiDox";
        public DateTime LastChangedOn { get; set; } = DateTime.Now;
        public PrefixList prefixList { get; set; } 
        public ProfanitySettings ProfanitySettings { get; set; } = new ProfanitySettings();
        public siteSettings siteSettings { get; set; } = new siteSettings();
        public LogSettings logSettings { get; set; } = new LogSettings();
        public ICollection<RemovePunishment> removePunishment { get; set; }
        public EnabledSettings enabledSettings { get; set; } = new EnabledSettings();
        public IpSettings ipSettings { get; set; } = new IpSettings();
        public EmailSettings EmailSettings { get; set; } = new EmailSettings();
        public CreditCardSettings CreditCardSettings { get; set; } = new CreditCardSettings();
        public PostcodeSettings postcodeSettings { get; set; } = new PostcodeSettings();
        public PhoneNumberSettings phoneNumberSettings { get; set; } = new PhoneNumberSettings();
        public PremiumSettings premiumSettings { get; set; } = new PremiumSettings();
       




    }
}
    