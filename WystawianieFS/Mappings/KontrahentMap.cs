using NHibernate.Mapping.ByCode;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Mapping.ByCode.Conformist;
using WystawianieFS.Models.DBModels;

namespace WystawianieFS.Mappings
{
    public class KontrahentMap : ClassMapping<Kontrahent>
    {
        public KontrahentMap()
        {
            Schema("dbo");
            Table("Kontrahenci");

            Id(x => x.ID, map => map.Generator(Generators.Identity));
            Property(x => x.Nazwa);
            Property(x => x.Akronim);
            Property(x => x.NIP);
            Property(x => x.Miasto);
            Property(x => x.Ulica);
            Property(x => x.KodPocztowy);
            Property(x => x.Email);
            Set(x => x.FS, m =>
            {
                m.Key(k => k.Column("KontrahentID"));
                m.Inverse(true);
                m.Cascade(Cascade.All);
            },
            r => r.OneToMany());
        }
    }
}