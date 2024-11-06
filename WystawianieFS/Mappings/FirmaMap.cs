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
    public class FirmaMap : ClassMapping<Firma>
    {
        public FirmaMap() 
        {
            Schema("dbo");
            Table("Firmy");

            Id(x => x.ID, map => map.Generator(Generators.Identity));
            Property(x => x.Nazwa);
            Property(x => x.NIP);
            Property(x => x.Miasto);
            Property(x => x.Ulica);
            Property(x => x.KodPocztowy);
            Property(x => x.Email);
            Set(x => x.FS, m =>
            {
                m.Key(k => k.Column("FirmaID"));
                m.Inverse(true);
                m.Cascade(Cascade.All);
            },
            r => r.OneToMany());
        }
    }
}
