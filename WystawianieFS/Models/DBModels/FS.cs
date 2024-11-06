using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WystawianieFS.Models.DBModels
{
    public class FS
    {
        public virtual int ID { get; set; }
        public virtual required Kontrahent Kontrahent { get; set; }
        public virtual required Firma Firma { get; set; }
        public virtual string Nazwa { get; set; } = string.Empty;
        public virtual string NumerFaktury { get; set; } = string.Empty;
        public virtual DateTime DataWystawienia { get; set; }
        public virtual string MiejsceWystawienia { get; set; } = string.Empty;
        public virtual DateTime DataSprzedazy { get; set; }
        public virtual ISet<FS_Cena> FS_Ceny { get; set; } = new HashSet<FS_Cena>();
    }
}
