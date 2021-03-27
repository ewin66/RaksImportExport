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


        //ID_KONTAKTU, Integer,0, Identyfikator kontrahenta,Nie
        //  ID_SPOSOBU_PLATNOSCI, Integer,0, Identyfikator sposobu zapłaty, Nie
        //ID_METODY_PLATNOSCI,Integer,0,Identyfikator metody płatności,Nie
        //ID_ROZRACHUNKU, Integer,0, Identyfikator rozrachunku,Nie
        //  DATA_PLATNOSCI, Date,0, Data płatności,Nie
        //WARTOSC_PLN, Float,0, Kwota w PLN, Nie
        //WARTOSC_WAL,Float,0,Kwota w walucie,Nie
        //KOD_WALUTY, String,3, Kod waluty dokumentu, Nie
        //UWAGI,String,8190,Uwagi na temat pozycji, Nie
        //ZNACZNIKI,BLOB.text,0,Znaczniki pozycji, Nie


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
