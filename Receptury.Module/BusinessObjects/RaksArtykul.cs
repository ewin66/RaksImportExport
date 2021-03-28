using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receptury.Module.BusinessObjects
{
    [DefaultClassOptions]
    [XafDefaultProperty(nameof(Nazwa))]
    public class RaksArtykul : XPCustomObject
    {
        public RaksArtykul(Session session) : base(session)
        { }


        RaksKontakt dostawca;
        RaksKontakt producent;
        string uwagi;
        RaksStawkaVat vat;
        RaksJednostkaMiary jednostka;
        string nazwaProducenta;
        string nipProducenta;
        int idProducenta;
    
        string nazwaDostawcy;
        string nipDostawcy;
        int idDostawcy;
        string gtuVat;
        bool mPP;
        string gtin;
        decimal sztukWOpakowaniu;
        int idOpakowania;
        bool podzielnosc;
        string nazwaJednostkiMiary;
        string skrotJednostkiMiary;
        int idJednostkiMiary;
        int typStawki;
        decimal stawkaVat;
        int idGrupy;
        int idStawki;
        string pkwiu;
        string indeks2;
        string nazwa;
        string indeks;
        string rodzaj;
        RaksGrupaArtykulow grupa;
        int id;
        [Key(false)]
        public int Id
        {
            get => id;
            set => SetPropertyValue(nameof(Id), ref id, value);
        }

        public RaksGrupaArtykulow Grupa
        {
            get => grupa;
            set => SetPropertyValue(nameof(Grupa), ref grupa, value);
        }


        public int IdGrupy
        {
            get => idGrupy;
            set => SetPropertyValue(nameof(IdGrupy), ref idGrupy, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Rodzaj
        {
            get => rodzaj;
            set => SetPropertyValue(nameof(Rodzaj), ref rodzaj, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Indeks
        {
            get => indeks;
            set => SetPropertyValue(nameof(Indeks), ref indeks, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Nazwa
        {
            get => nazwa;
            set => SetPropertyValue(nameof(Nazwa), ref nazwa, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Indeks2
        {
            get => indeks2;
            set => SetPropertyValue(nameof(Indeks2), ref indeks2, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Pkwiu
        {
            get => pkwiu;
            set => SetPropertyValue(nameof(Pkwiu), ref pkwiu, value);
        }


        public RaksStawkaVat Vat
        {
            get => vat;
            set => SetPropertyValue(nameof(Vat), ref vat, value);
        }

        public int IdStawki
        {
            get => idStawki;
            set => SetPropertyValue(nameof(IdStawki), ref idStawki, value);
        }

        public decimal StawkaVat
        {
            get => stawkaVat;
            set => SetPropertyValue(nameof(StawkaVat), ref stawkaVat, value);
        }


        public int TypStawki
        {
            get => typStawki;
            set => SetPropertyValue(nameof(TypStawki), ref typStawki, value);
        }



        public RaksJednostkaMiary Jednostka
        {
            get => jednostka;
            set => SetPropertyValue(nameof(Jednostka), ref jednostka, value);
        }

        public int IdJednostkiMiary
        {
            get => idJednostkiMiary;
            set => SetPropertyValue(nameof(IdJednostkiMiary), ref idJednostkiMiary, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SkrotJednostkiMiary
        {
            get => skrotJednostkiMiary;
            set => SetPropertyValue(nameof(SkrotJednostkiMiary), ref skrotJednostkiMiary, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NazwaJednostkiMiary
        {
            get => nazwaJednostkiMiary;
            set => SetPropertyValue(nameof(NazwaJednostkiMiary), ref nazwaJednostkiMiary, value);
        }

        public bool Podzielnosc
        {
            get => podzielnosc;
            set => SetPropertyValue(nameof(Podzielnosc), ref podzielnosc, value);
        }

        public int IdOpakowania
        {
            get => idOpakowania;
            set => SetPropertyValue(nameof(IdOpakowania), ref idOpakowania, value);
        }

        public decimal SztukWOpakowaniu
        {
            get => sztukWOpakowaniu;
            set => SetPropertyValue(nameof(SztukWOpakowaniu), ref sztukWOpakowaniu, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Gtin
        {
            get => gtin;
            set => SetPropertyValue(nameof(Gtin), ref gtin, value);
        }

        public bool MPP
        {
            get => mPP;
            set => SetPropertyValue(nameof(MPP), ref mPP, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string GtuVat
        {
            get => gtuVat;
            set => SetPropertyValue(nameof(GtuVat), ref gtuVat, value);
        }



        public int IdDostawcy
        {
            get => idDostawcy;
            set => SetPropertyValue(nameof(IdDostawcy), ref idDostawcy, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NipDostawcy
        {
            get => nipDostawcy;
            set => SetPropertyValue(nameof(NipDostawcy), ref nipDostawcy, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NazwaDostawcy
        {
            get => nazwaDostawcy;
            set => SetPropertyValue(nameof(NazwaDostawcy), ref nazwaDostawcy, value);
        }




        public RaksKontakt Dostawca
        {
            get => dostawca;
            set => SetPropertyValue(nameof(Dostawca), ref dostawca, value);
        }


        public RaksKontakt Producent
        {
            get => producent;
            set => SetPropertyValue(nameof(Producent), ref producent, value);
        }

        public int IdProducenta
        {
            get => idProducenta;
            set => SetPropertyValue(nameof(IdProducenta), ref idProducenta, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NipProducenta
        {
            get => nipProducenta;
            set => SetPropertyValue(nameof(NipProducenta), ref nipProducenta, value);
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NazwaProducenta
        {
            get => nazwaProducenta;
            set => SetPropertyValue(nameof(NazwaProducenta), ref nazwaProducenta, value);
        }


        [Size(SizeAttribute.Unlimited)]
        public string Uwagi
        {
            get => uwagi;
            set => SetPropertyValue(nameof(Uwagi), ref uwagi, value);
        }


        int iddomyslnegorabatu;
        //Identyfikator domyślnego rodzaju rabatu z sekcji RODZAJE_RABATOW
        public int IdDomyslnegoRabatu
        {
            get => iddomyslnegorabatu;
            set => SetPropertyValue(nameof(IdDomyslnegoRabatu), ref iddomyslnegorabatu, value);
        }
        string nazwadomyslnegorabatu;
        //Nazwa domyślnego rodzaju rabatu
        [Size(50)]
        public string NazwaDomyslnegoRabatu
        {
            get => nazwadomyslnegorabatu;
            set => SetPropertyValue(nameof(NazwaDomyslnegoRabatu), ref nazwadomyslnegorabatu, value);
        }
        bool ostrzegajosprzponizejcenyzakupu;
        //Czy program ma generować ostrzeżenia, jeśli nastąpiła sprzedaż tego artykułu z ceną niższą niż cena zakupu
        public bool OstrzegajOSprzPonizejCenyZakupu
        {
            get => ostrzegajosprzponizejcenyzakupu;
            set => SetPropertyValue(nameof(OstrzegajOSprzPonizejCenyZakupu), ref ostrzegajosprzponizejcenyzakupu, value);
        }
        string waganetto;
        //Waga netto artykułu
        public string WagaNetto
        {
            get => waganetto;
            set => SetPropertyValue(nameof(WagaNetto), ref waganetto, value);
        }
        string wagabrutto;
        //Waga brutto artykułu
        public string WagaBrutto
        {
            get => wagabrutto;
            set => SetPropertyValue(nameof(WagaBrutto), ref wagabrutto, value);
        }

        decimal prowizjaakwizytora;
        //Procentowa prowizja od sprzedaży dla akwizytora, ważniejsza od prowizji zdefiniowanej w główce dokumentu
        public decimal ProwizjaAkwizytora
        {
            get => prowizjaakwizytora;
            set => SetPropertyValue(nameof(ProwizjaAkwizytora), ref prowizjaakwizytora, value);
        }
        int dniprzydatnosci;
        //Termin przydatności artykułu w dniach
        public int DniPrzydatnosci
        {
            get => dniprzydatnosci;
            set => SetPropertyValue(nameof(DniPrzydatnosci), ref dniprzydatnosci, value);
        }
        string stanminimalny;
        //Jeśli w magazynie będzie mniej jednostek artykułu niż podana tu wartość, program będzie generował ostrzeżenia; 0 - pole ignorowane, brak ostrzeżeń
        public string StanMinimalny
        {
            get => stanminimalny;
            set => SetPropertyValue(nameof(StanMinimalny), ref stanminimalny, value);
        }
        string stanmaksymalny;
        //Jeśli w magazynie będzie więcej jednostek artykułu niż podana tu wartość, program będzie generował ostrzeżenia; 0 - pole ignorowane, brak ostrzeżeń
        public string StanMaksymalny
        {
            get => stanmaksymalny;
            set => SetPropertyValue(nameof(StanMaksymalny), ref stanmaksymalny, value);
        }


        string kodcn;
        //Kod CN
        [Size(20)]
        public string KodCn
        {
            get => kodcn;
            set => SetPropertyValue(nameof(KodCn), ref kodcn, value);
        }
        string kodcnnazwa;
        //Nazwa kodu CN
        [Size(250)]
        public string KodCnNazwa
        {
            get => kodcnnazwa;
            set => SetPropertyValue(nameof(KodCnNazwa), ref kodcnnazwa, value);
        }
        int jmcn;
        //Jednostka miary według CN
        public int JmCn
        {
            get => jmcn;
            set => SetPropertyValue(nameof(JmCn), ref jmcn, value);
        }
        string skrotjednostkimiarycn;
        //
        [Size(5)]
        public string SkrotJednostkiMiaryCn
        {
            get => skrotjednostkimiarycn;
            set => SetPropertyValue(nameof(SkrotJednostkiMiaryCn), ref skrotjednostkimiarycn, value);
        }
        string nazwajednostkimiarycn;
        //
        [Size(25)]
        public string NazwaJednostkiMiaryCn
        {
            get => nazwajednostkimiarycn;
            set => SetPropertyValue(nameof(NazwaJednostkiMiaryCn), ref nazwajednostkimiarycn, value);
        }
        decimal przelicznikcn;
        //Przelicznik jednostki miary CN
        public decimal PrzelicznikCn
        {
            get => przelicznikcn;
            set => SetPropertyValue(nameof(PrzelicznikCn), ref przelicznikcn, value);
        }
        bool bezmasy;
        //Dla tego towaru nie podaje się masy na deklaracji Intrastat
        public bool BezMasy
        {
            get => bezmasy;
            set => SetPropertyValue(nameof(BezMasy), ref bezmasy, value);
        }
        bool intrastat;
        //Towar jest uwzględniany na deklaracji Intrastat
        public bool Intrastat
        {
            get => intrastat;
            set => SetPropertyValue(nameof(Intrastat), ref intrastat, value);
        }
        string pcn;
        //Kod PCN artykułu
        [Size(15)]
        public string Pcn
        {
            get => pcn;
            set => SetPropertyValue(nameof(Pcn), ref pcn, value);
        }
        string kodkreskowy;
        //Kod kreskowy artykułu (jeśli nie zdefiniowano jego cech, w przeciwnym wypadku nieużywane)
        [Size(30)]
        public string KodKreskowy
        {
            get => kodkreskowy;
            set => SetPropertyValue(nameof(KodKreskowy), ref kodkreskowy, value);
        }
        string maskakodukreskowego;
        //Maska dla generowania kodu kreskowego, jeśli artykuł ma zdefiniowane cechy
        [Size(30)]
        public string MaskaKoduKreskowego
        {
            get => maskakodukreskowego;
            set => SetPropertyValue(nameof(MaskaKoduKreskowego), ref maskakodukreskowego, value);
        }
        decimal miniloscpsp;
        //Najmniejsza ilość możliwa do zmontowania na PSP
        public decimal MinIloscPsp
        {
            get => miniloscpsp;
            set => SetPropertyValue(nameof(MinIloscPsp), ref miniloscpsp, value);
        }
        decimal minilosczd;
        //Najmniejsza ilość możliwa do zamówienia u dostawcy (ZD i ZDwew)
        public decimal MinIloscZd
        {
            get => minilosczd;
            set => SetPropertyValue(nameof(MinIloscZd), ref minilosczd, value);
        }
        decimal minilosczo;
        //Najmniejsza ilość możliwa do zamówienia przez odbiorcę (ZO)
        public decimal MinIloscZo
        {
            get => minilosczo;
            set => SetPropertyValue(nameof(MinIloscZo), ref minilosczo, value);
        }
        decimal miniloscpr;
        //Najmniejsza ilość możliwa do wyprodukowania w produkcji (ZP)
        public decimal MinIloscPr
        {
            get => miniloscpr;
            set => SetPropertyValue(nameof(MinIloscPr), ref miniloscpr, value);
        }
        string funduszpromocji;
        //Nazwa funduszu promocji używanego do naliczania potrąceń przy zakupach od rolników ryczałtowych.
        [Size(60)]
        public string FunduszPromocji
        {
            get => funduszpromocji;
            set => SetPropertyValue(nameof(FunduszPromocji), ref funduszpromocji, value);
        }
    }
}
