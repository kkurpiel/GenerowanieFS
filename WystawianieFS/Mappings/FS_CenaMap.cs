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
    public class FS_CenaMap : ClassMapping<FS_Cena>
    {
        public FS_CenaMap()
        {
            Schema("dbo");
            Table("FS_Cena");

            Id(x => x.ID, map => map.Generator(Generators.Identity));
            ManyToOne(x => x.FS, m => m.Column("FSID"));
            ManyToOne(x => x.Cena, m => m.Column("CenaID"));
            ManyToOne(x => x.ArchiwumCen, m => m.Column("ArchiwumCenID"));
            Property(x => x.IloscTowaru);
            Property(x => x.CNprzelicz);
            Property(x => x.CBprzelicz);
        }
    }
}
