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
    public class CenaMap : ClassMapping<Cena>
    {
        public CenaMap() 
        {
            Schema("dbo");
            Table("Ceny");

            Id(x => x.ID, map => map.Generator(Generators.Identity));
            ManyToOne(x => x.Towar, m => m.Column("TowarID"));
            Property(x => x.DataNabycia);
            Property(x => x.CenaNetto);
            Property(x => x.CenaBrutto);
            Property(x => x.Waluta);
            Property(x => x.Aktualny);
            Property(x => x.Ilosc);
            Set(x => x.FS_Ceny, m =>
            {
                m.Key(k => k.Column("CenaID"));
                m.Inverse(true);
                m.Cascade(Cascade.All);
            },
            r => r.OneToMany());
        }
    }
}
