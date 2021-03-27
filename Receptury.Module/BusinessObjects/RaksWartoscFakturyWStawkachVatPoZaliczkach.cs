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

        //        _NAZWA,_TYP,_SZEROKOSC,_OPIS,_WYMAGANE
        //ID_STAWKI_VAT, Integer,0, Identyfikator stawki VAT z sekcji STAWKI_VAT,Tak
        //  STAWKA_VAT, Float,0, Wartość procentowa stawki VAT(np. 22 to stawka 22%),Tak
        //   TYP_STAWKI_VAT, Integer,0,"Pole określa typ standardowej stawki VAT. Możliwe wartości to:
        //1 - stawka 22%
        //2 - stawka 7%
        //6 - stawka zwolniona
        //7 - stawka ""nie podlega"" (nie uwzględniana w rejestrach VAT)
        //8 - stawka 0% dla sprzedaży krajowej i eksportowej
        //9 - stawka 3%
        //10- stawka 5% dla rolników ryczałtowych
        //11- stawka 6% dla rolników ryczałtowych
        //Jeśli stawka nie jest standardowa, należy tu wpisać 0 (dla innych wartości pole STAWKA_VAT jest ignorowane)",Tak
        //WARTOSC_NETTO,Float,0,Wartość netto pozycji dokumentu z daną stawką(w walucie dokumentu),Tak
        //KWOTA_VAT, Float,0, Kwota VAT naliczonego w pozycjach dokumentu z daną stawką(w walucie dokumentu),Tak
        //WARTOSC_BRUTTO, Float,0, Wartość brutto pozycji dokumentu z daną stawką(w walucie dokumentu),Tak
        // WARTOSC_NETTO_PLN, Float,0, Wartość netto pozycji dokumentu z daną stawką(w złotówkach),Tak
        //  KWOTA_VAT_PLN, Float,0, Kwota VAT należnego w pozycjach dokumentu z daną stawką(w złotówkach),Tak
        //   WARTOSC_BRUTTO_PLN, Float,0, Wartość brutto pozycji dokumentu z daną stawką(w złotówkach),Tak


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
