using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    public class RaksPlatnosci : XPCustomObject
    {
        public RaksPlatnosci(Session session) : base(session)
        { }


        int idkontaktu;
        //Identyfikator kontrahenta
        public int IdKontaktu
        {
            get => idkontaktu;
            set => SetPropertyValue(nameof(IdKontaktu), ref idkontaktu, value);
        }
        int idsposobuplatnosci;
        //Identyfikator sposobu zapłaty
        public int IdSposobuPlatnosci
        {
            get => idsposobuplatnosci;
            set => SetPropertyValue(nameof(IdSposobuPlatnosci), ref idsposobuplatnosci, value);
        }
        int idmetodyplatnosci;
        //Identyfikator metody płatności
        public int IdMetodyPlatnosci
        {
            get => idmetodyplatnosci;
            set => SetPropertyValue(nameof(IdMetodyPlatnosci), ref idmetodyplatnosci, value);
        }
        int idrozrachunku;
        //Identyfikator rozrachunku
        public int IdRozrachunku
        {
            get => idrozrachunku;
            set => SetPropertyValue(nameof(IdRozrachunku), ref idrozrachunku, value);
        }
        DateTime dataplatnosci;
        //Data płatności
        public DateTime DataPlatnosci
        {
            get => dataplatnosci;
            set => SetPropertyValue(nameof(DataPlatnosci), ref dataplatnosci, value);
        }
        decimal wartoscpln;
        //Kwota w PLN
        public decimal WartoscPln
        {
            get => wartoscpln;
            set => SetPropertyValue(nameof(WartoscPln), ref wartoscpln, value);
        }
        decimal wartoscwal;
        //Kwota w walucie
        public decimal WartoscWal
        {
            get => wartoscwal;
            set => SetPropertyValue(nameof(WartoscWal), ref wartoscwal, value);
        }
        string kodwaluty;
        //Kod waluty dokumentu
        [Size(3)]
        public string KodWaluty
        {
            get => kodwaluty;
            set => SetPropertyValue(nameof(KodWaluty), ref kodwaluty, value);
        }

        string znaczniki;
        //Znaczniki pozycji
        public string Znaczniki
        {
            get => znaczniki;
            set => SetPropertyValue(nameof(Znaczniki), ref znaczniki, value);
        }


        string uwagi;

        [Size(SizeAttribute.Unlimited)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }
        RaksFaktura faktura;

        [Association("RaksFaktura-Platnosci")]
        public RaksFaktura Faktura
        {
            get => faktura;
            set => SetPropertyValue(nameof(Faktura), ref faktura, value);
        }

    }
}
