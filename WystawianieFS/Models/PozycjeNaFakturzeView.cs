namespace WystawianieFS.Models
{
    public class PozycjeNaFakturzeView
    {
        public string Nazwa { get; set; } = string.Empty;
        public string Kod {  get; set; } = string.Empty;
        public string JM { get; set; } = string.Empty;
        public int VAT { get; set; }
        public int IDCeny { get; set; }
        public DateTime DataNabycia { get; set; }
        public decimal CenaNetto { get; set; }
        public decimal? CenaBrutto { get; set; }
        public string Waluta { get; set; } = string.Empty;
        public bool? Aktualny { get; set; }
        public decimal Ilosc {  get; set; }
        public decimal? CNprzelicz { get; set; }
        public decimal? CBprzelicz { get; set; }


        public decimal? WymaganaIlosc { get; set; }
        public virtual bool IsClicked { get; set; }
    }
}
