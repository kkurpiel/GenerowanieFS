using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WystawianieFS.Models.NBPModels
{
    public class KursWalutyResponse
    {
        public string Table { get; set; } = string.Empty;
        public string No { get; set; } = string.Empty;
        public DateTime EffectiveDate { get; set; }
        public List<KursWaluty> Rates { get; set; } = new List<KursWaluty>();
    }
}
