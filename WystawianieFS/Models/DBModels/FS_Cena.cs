namespace WystawianieFS.Models.DBModels
{
    public class FS_Cena
    {
        public virtual int ID { get; set; }
        public virtual Cena? Cena { get; set; }
        public virtual ArchiwumCen? ArchiwumCen { get; set; }
        public virtual required FS FS { get; set; }
        public virtual decimal IloscTowaru { get; set; }
        public virtual decimal? CNprzelicz { get; set; }
        public virtual decimal? CBprzelicz { get; set; }
    }
}
