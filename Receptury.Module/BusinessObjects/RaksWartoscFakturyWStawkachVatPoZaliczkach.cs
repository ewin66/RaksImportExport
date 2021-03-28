using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    public class RaksWartoscFakturyWStawkachVatPoZaliczkach : XPObject
    {
        public RaksWartoscFakturyWStawkachVatPoZaliczkach(Session session) : base(session)
        { }

        int idstawkivat;
        //Identyfikator stawki VAT z sekcji STAWKI_VAT
        public int IdStawkiVat
        {
            get => idstawkivat;
            set => SetPropertyValue(nameof(IdStawkiVat), ref idstawkivat, value);
        }
        decimal stawkavat;
        //Wartość procentowa stawki VAT (np. 22 to stawka 22%)
        public decimal StawkaVat
        {
            get => stawkavat;
            set => SetPropertyValue(nameof(StawkaVat), ref stawkavat, value);
        }
        int typstawkivat;
        //Pole określa typ standardowej stawki VAT. Możliwe wartości to:
        //1 - stawka 22%
        //2 - stawka 7%
        //6 - stawka zwolniona
        //7 - stawka "nie podlega" (nie uwzględniana w rejestrach VAT)
        //8 - stawka 0% dla sprzedaży krajowej i eksportowej
        //9 - stawka 3%
        //10- stawka 5% dla rolników ryczałtowych
        //11- stawka 6% dla rolników ryczałtowych
        //Jeśli stawka nie jest standardowa, należy tu wpisać 0 (dla innych wartości pole STAWKA_VAT jest ignorowane)
        public int TypStawkiVat
        {
            get => typstawkivat;
            set => SetPropertyValue(nameof(TypStawkiVat), ref typstawkivat, value);
        }
        decimal wartoscnetto;
        //Wartość netto pozycji dokumentu z daną stawką (w walucie dokumentu)
        public decimal WartoscNetto
        {
            get => wartoscnetto;
            set => SetPropertyValue(nameof(WartoscNetto), ref wartoscnetto, value);
        }
        decimal kwotavat;
        //Kwota VAT naliczonego w pozycjach dokumentu z daną stawką (w walucie dokumentu)
        public decimal KwotaVat
        {
            get => kwotavat;
            set => SetPropertyValue(nameof(KwotaVat), ref kwotavat, value);
        }
        decimal wartoscbrutto;
        //Wartość brutto pozycji dokumentu z daną stawką (w walucie dokumentu)
        public decimal WartoscBrutto
        {
            get => wartoscbrutto;
            set => SetPropertyValue(nameof(WartoscBrutto), ref wartoscbrutto, value);
        }
        decimal wartoscnettopln;
        //Wartość netto pozycji dokumentu z daną stawką (w złotówkach)
        public decimal WartoscNettoPln
        {
            get => wartoscnettopln;
            set => SetPropertyValue(nameof(WartoscNettoPln), ref wartoscnettopln, value);
        }
        decimal kwotavatpln;
        //Kwota VAT należnego w pozycjach dokumentu z daną stawką (w złotówkach)
        public decimal KwotaVatPln
        {
            get => kwotavatpln;
            set => SetPropertyValue(nameof(KwotaVatPln), ref kwotavatpln, value);
        }
        decimal wartoscbruttopln;
        //Wartość brutto pozycji dokumentu z daną stawką (w złotówkach)
        public decimal WartoscBruttoPln
        {
            get => wartoscbruttopln;
            set => SetPropertyValue(nameof(WartoscBruttoPln), ref wartoscbruttopln, value);
        }

        string uwagi;

        [Size(SizeAttribute.Unlimited)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }
        RaksFaktura faktura;

        [Association("RaksFaktura-WartoscWstawkachVatPoZaliczkach")]
        public RaksFaktura Faktura
        {
            get => faktura;
            set => SetPropertyValue(nameof(Faktura), ref faktura, value);
        }
    }
}
