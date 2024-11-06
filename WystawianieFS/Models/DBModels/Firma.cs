using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WystawianieFS.Models.DBModels
{
    public class Firma
    {
        public virtual int ID { get; set; }
        public virtual string Nazwa { get; set; } = string.Empty;
        public virtual string NIP { get; set; } = string.Empty;
        public virtual string Miasto { get; set; } = string.Empty;
        public virtual string Ulica { get; set; } = string.Empty;
        public virtual string KodPocztowy { get; set; } = string.Empty;
        public virtual string Email { get; set; } = string.Empty;
        public virtual ISet<FS> FS { get; set; } = new HashSet<FS>();

        public virtual string CmbBx_firma => $"{Nazwa} {NIP}";
    }
}
