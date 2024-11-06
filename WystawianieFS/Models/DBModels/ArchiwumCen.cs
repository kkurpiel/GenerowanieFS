using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WystawianieFS.Models.DBModels
{
    public class ArchiwumCen
    {
        public virtual int ID { get; set; }
        public virtual Towar Towar { get; set; }
        public virtual DateTime DataNabycia { get; set; }
        public virtual decimal CenaNetto { get; set; }
        public virtual decimal CenaBrutto { get; set; }
        public virtual string Waluta { get; set; } = string.Empty;
        public virtual bool? Aktualny { get; set; }
        public virtual decimal Ilosc { get; set; }
        public virtual DateTime? DataWyzerowania { get; set; } 
        public virtual int CenaID { get; set; }
        public virtual ISet<FS_Cena> FS_Ceny { get; set; } = new HashSet<FS_Cena>();
    }
}
