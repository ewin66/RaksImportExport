using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    public class RaksRozrachunek : XPCustomObject
    {
        public RaksRozrachunek(Session session) : base(session)
        { }

        int id;
        //Unikalny identyfikator rozrachunku
        [Key(false)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }
        string typrozr;
        //N-należność, Z-zobowiązanie
        [Size(1)]
        public string TypRozr
        {
            get => typrozr;
            set => SetPropertyValue(nameof(TypRozr), ref typrozr, value);
        }
        int idkontaktu;
        //Identyfikator kontaktu w zbiorze kontaktów
        public int IdKontaktu
        {
            get => idkontaktu;
            set => SetPropertyValue(nameof(IdKontaktu), ref idkontaktu, value);
        }
        string kodwal;
        //Kod waluty lub PLN
        [Size(3)]
        public string KodWal
        {
            get => kodwal;
            set => SetPropertyValue(nameof(KodWal), ref kodwal, value);
        }
        DateTime dataoper;
        ///Data operacji
        public DateTime DataOper
        {
            get => dataoper;
            set => SetPropertyValue(nameof(DataOper), ref dataoper, value);
        }
        DateTime dataplat;
        ///Data płatności
        public DateTime DataPlat
        {
            get => dataplat;
            set => SetPropertyValue(nameof(DataPlat), ref dataplat, value);
        }
        decimal kwota;

        /// <summary>
        /// 
        /// </summary>

        public decimal Kwota
        {
            get => kwota;
            set => SetPropertyValue(nameof(Kwota), ref kwota, value);
        }
        decimal kwotawal;
        //Kwota początkowa rozrachunku w walucie (lub 0)
        public decimal KwotaWal
        {
            get => kwotawal;
            set => SetPropertyValue(nameof(KwotaWal), ref kwotawal, value);
        }
        string opis;
        //Opis rozrachunku
        [Size(255)]
        public string Opis
        {
            get => opis;
            set => SetPropertyValue(nameof(Opis), ref opis, value);
        }
        string kontaktnazwaskrocona;
        //Nazwa skrócona kontaktu
        [Size(50)]
        public string KontaktNazwaSkrocona
        {
            get => kontaktnazwaskrocona;
            set => SetPropertyValue(nameof(KontaktNazwaSkrocona), ref kontaktnazwaskrocona, value);
        }
        string kontaktnip;
        //NIP kontaktu
        [Size(25)]
        public string KontaktNip
        {
            get => kontaktnip;
            set => SetPropertyValue(nameof(KontaktNip), ref kontaktnip, value);
        }
        int mechanizmpodzielonejplatnosci;
        //Mechanizm podzielonej płatności
        public int MechanizmPodzielonejPlatnosci
        {
            get => mechanizmpodzielonejplatnosci;
            set => SetPropertyValue(nameof(MechanizmPodzielonejPlatnosci), ref mechanizmpodzielonejplatnosci, value);
        }


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
