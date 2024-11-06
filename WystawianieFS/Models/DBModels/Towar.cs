using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WystawianieFS.Models.DBModels
{
    public class Towar
    {
        public virtual int ID { get; set; }
        public virtual string Nazwa { get; set; } = string.Empty;
        public virtual string Kod { get; set; } = string.Empty;
        public virtual string JM { get; set; } = string.Empty;
        public virtual int VAT { get; set; }
        public virtual ISet<Cena> Ceny { get; set; } = new HashSet<Cena>();
        public virtual ISet<ArchiwumCen> ArchiwaCen { get; set; } = new HashSet<ArchiwumCen>();

    }
}
