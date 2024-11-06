using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WystawianieFS.Models.NBPModels
{
    public class KursWaluty
    {
        public string Currency { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public decimal Mid { get; set; }
    }
}
