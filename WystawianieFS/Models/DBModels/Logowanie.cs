using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WystawianieFS.Models.DBModels
{
    public class Logowanie
    {
        public virtual int ID { get; set; }
        public virtual string Kod { get; set; } = string.Empty;
        public virtual string Imie { get; set; } = string.Empty;
        public virtual string Nazwisko { get; set; } = string.Empty;
        public virtual bool IsAdmin { get; set; }

    }
}
