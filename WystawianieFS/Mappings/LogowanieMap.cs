using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WystawianieFS.Models.DBModels;

namespace WystawianieFS.Mappings
{
    public class LogowanieMap : ClassMapping<Logowanie>
    {
        public LogowanieMap() 
        {
            Schema("dbo");
            Table("DaneLogowania");

            Id(x => x.ID, map => map.Generator(Generators.Identity));
            Property(x => x.Kod);
            Property(x => x.Imie);
            Property(x => x.Nazwisko);
            Property(x => x.IsAdmin);
        }
    }
}
