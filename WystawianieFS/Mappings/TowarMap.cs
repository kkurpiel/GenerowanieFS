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
    public class TowarMap : ClassMapping<Towar>
    {
        public TowarMap() 
        {
            Schema("dbo");
            Table("Towary");

            Id(x => x.ID, map => map.Generator(Generators.Identity));
            Property(x => x.Nazwa);
            Property(x => x.Kod);
            Property(x => x.JM);
            Property(x => x.VAT);
            Set(x => x.Ceny, m =>
            {
                m.Key(k => k.Column("TowarID"));
                m.Inverse(true);
                m.Cascade(Cascade.All);
            },
            r => r.OneToMany());
            Set(x => x.ArchiwaCen, m =>
            {
                m.Key(k => k.Column("TowarID"));
                m.Inverse(true);
                m.Cascade(Cascade.All);
            },
r => r.OneToMany());
        }
    }
}
