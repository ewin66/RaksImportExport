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
        StawkaVat vat;
        RaksJednostkaMiary jednostka;
        string nazwaProducenta;
        string nipProducenta;
        int idProducenta;
        string kodKreskowy;
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


        public StawkaVat Vat
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

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string KodKreskowy
        {
            get => kodKreskowy;
            set => SetPropertyValue(nameof(KodKreskowy), ref kodKreskowy, value);
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

    }
}
