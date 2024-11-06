using NHibernate.Mapping;
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
    public class FSMap : ClassMapping<FS>
    {
        public FSMap() 
        {
            Schema("dbo");
            Table("FS");

            Id(x => x.ID, map => map.Generator(Generators.Identity));
            ManyToOne(x => x.Kontrahent, m => m.Column("KontrahentID"));
            ManyToOne(x => x.Firma, m => m.Column("FirmaID"));
            Property(x => x.Nazwa);
            Property(x => x.NumerFaktury);
            Property(x => x.DataWystawienia);
            Property(x => x.MiejsceWystawienia);
            Property(x => x.DataSprzedazy);
            Set(x => x.FS_Ceny, m =>
            {
                m.Key(k => k.Column("FSID"));
                m.Inverse(true);
                m.Cascade(Cascade.All);
            },
            r => r.OneToMany());
        }
    }
}
