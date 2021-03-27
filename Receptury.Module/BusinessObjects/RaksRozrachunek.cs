using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    public class RaksRozrachunek : XPObject
    {
        public RaksRozrachunek(Session session) : base(session)
        { }

        //        ID,Integer,0,Unikalny identyfikator rozrachunku,Tak
        //TYP_ROZR, String,1,"N-należność, Z-zobowiązanie", Tak
        //ID_KONTAKTU,Integer,0,Identyfikator kontaktu w zbiorze kontaktów,Tak
        //KOD_WAL, String,3, Kod waluty lub PLN,Tak
        //  DATA_OPER, Date,0, Data operacji,Tak
        //    DATA_PLAT, Date,0, Data płatności,Nie
        //      KWOTA, Float,0, Kwota początkowa rozrachunku, Tak
        //KWOTA_WAL,Float,0,Kwota początkowa rozrachunku w walucie(lub 0),Tak
        //OPIS, String,255, Opis rozrachunku,Nie
        // KONTAKT_NAZWA_SKROCONA, String,50, Nazwa skrócona kontaktu, Nie
        //KONTAKT_NIP,String,25,NIP kontaktu, Nie
        //MECHANIZM_PODZIELONEJ_PLATNOSCI,Integer,0,Mechanizm podzielonej płatności,Nie


        RaksFaktura faktura;

        [Association("RaksFaktura-Rozrachunki")]
        public RaksFaktura Faktura
        {
            get => faktura;
            set => SetPropertyValue(nameof(Faktura), ref faktura, value);
        }

        [Association("RaksRozrachunek-RaksRozliczeniaRozrachunkow")]
     //   [Association("RaksRozrachunek-RaksRozliczeniaRozrachunkow")]
        public XPCollection<RaksRozliczenieRozrachunkow> RaksRozliczeniaRozrachunkow
        {
            get
            {
                return GetCollection<RaksRozliczenieRozrachunkow>(nameof(RaksRozliczeniaRozrachunkow));
            }
        }
    }
}
